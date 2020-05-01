using System;
using System.Timers;
using MetroFramework;
using GitTray.Utility;
using Microsoft.Win32;
using System.Threading;
using System.Windows.Forms;
using GitTray.DataStructure;
using System.Collections.Generic;

namespace GitTray.UI
{
    struct DisplayText
    {
        public string Branch;
        public string Log;
        public string Name;
    }

    enum GitTrayStatusType
    {
        Running,
        Stopped,
        Sleep
    }

    public partial class GitTrayUI : MetroFramework.Forms.MetroForm
    {
        internal static System.Timers.Timer TrayTimer = new System.Timers.Timer();

        internal UsersGitConfiguration _gitSettings = new UsersGitConfiguration() { IsInititialised = false };

        private readonly Dictionary<string, List<string>> _statusHolder  = new Dictionary<string, List<string>>();
        
        public static bool IsTableRefreshed { get; set; }

        private static GitTrayStatusType _trayStatus;

        private static void AddToRegistry()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (rk != null) rk.SetValue("Git Tray", Application.ExecutablePath);
        }

        public GitTrayUI()
        {
            InitializeComponent();
            AddToRegistry();
            _trayStatus = GitTrayStatusType.Running;
        }

        private void RefreshTable()
        {
            gitTrayTableAdapter.Fill(gitTrayDataSet.GitTrayTable);
            gitTrayTableBindingSource.DataSource = gitTrayDataSet.GitTrayTable;
            IsTableRefreshed = true;

            if (gitTrayDataSet.GitTrayTable.Rows.Count > 0)
            {
                StartStopButton.Visible = false;
                StartStopButton.BackgroundImage = Properties.Resources.play;
                StartStopButton.Visible = true;
            }
            else
            {
                StartStopButton.Visible = false;
                StartStopButton.BackgroundImage = Properties.Resources.power;
                StartStopButton.Visible = true;
            }

        }

        /// <summary>
        /// Load Git Settings from DataBase
        /// </summary>
        private void LoadGitSettings()
        {
            // Load Git Settings from DataBase
            this.gitTrayGitSettingsTableAdapter.Fill(this.gitTrayGitSettingsDataSet.GitSettings);
            gitTraySettingsBindingSource.DataSource = this.gitTrayGitSettingsDataSet.GitSettings;

            try
            {
                _gitSettings.GitLocation = this.gitTrayGitSettingsDataSet.GitSettings[0].GitLocation;
                _gitSettings.PollTime = this.gitTrayGitSettingsDataSet.GitSettings[0].PollPeriod;
                _gitSettings.FetchType = this.gitTrayGitSettingsDataSet.GitSettings[0].FetchType;
                _gitSettings.RecursiveSubmoduleSearch = this.gitTrayGitSettingsDataSet.GitSettings[0].RecursiveSubmoduleSearch;
                _gitSettings.AutoMerge = this.gitTrayGitSettingsDataSet.GitSettings[0].AutoMerge;
                _gitSettings.LogFormat = this.gitTrayGitSettingsDataSet.GitSettings[0].LogFormat;

                GitExtensions.UpdateGitConfiguration(_gitSettings);
            }
            catch (Exception e)
            {
                var result = MetroMessageBox.Show(this, e.Message, "Git Tray Warining Message", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Abort)
                {
                    Application.Exit();
                }
                else if (result == DialogResult.Retry)
                {
                    SettingsSplitButton_ButtonClick(new object(), new EventArgs());
                }
                else
                {
                    /*NAR*/
                }
            }
        }

        private void GitTrayNotification(object source, ElapsedEventArgs e)
        {
            TrayTimer.Stop();

            for (int index = 0; index < gitTrayDataSet.GitTrayTable.Rows.Count; index++)
            {
                if (IsTableRefreshed == true)
                {
                    IsTableRefreshed = false; //Reset the flag
                    _statusHolder.Clear(); //Remove all entries
                    break; // break the loop
                }

                if (_trayStatus == GitTrayStatusType.Stopped || _trayStatus == GitTrayStatusType.Sleep)
                {
                    break; // break the loop
                }

                GitTrayDataSet.GitTrayTableRow currRow = (GitTrayDataSet.GitTrayTableRow)gitTrayDataSet.GitTrayTable.Rows[index];

                string gitFetchResult = string.Empty;
                string gitStatus = string.Empty;
                string gerritResult = string.Empty;

                currRow.Activity = "Running"; /* Start Processing the row */

                #region Setup Threads
                Thread gitThread = new Thread(() => gitFetchResult = GitExtensions.ProcessGitRepo(ref gitStatus, currRow.Path))
                {
                    IsBackground = true
                };
                #endregion

                gitThread.Start();

                #region Git Status
                gitThread.Join();
                currRow.Git_Status = gitStatus;
                if (!string.IsNullOrEmpty(gitFetchResult) && IsTableRefreshed == false)
                {
                    bool isPresent = false;
                    if(_statusHolder.ContainsKey(currRow.Path))
                    {
                        if (gitFetchResult.Equals(_statusHolder[currRow.Path][0]))
                        {
                            isPresent = true;
                        }
                        else
                        {
                            _statusHolder[currRow.Path][0] = gitFetchResult;
                        }
                    }

                    if (isPresent == false && gitFetchResult.Contains("fatal:"))
                    {
                        //GitTray.ShowBalloonTip(1000, "Error", gitFetchResult, ToolTipIcon.Error);
                    }
                    else if (isPresent == false)
                    {
                        GitTray.ShowBalloonTip(1000, "New Software Available!", gitFetchResult, ToolTipIcon.Info);
                    }
                    else
                    {
                        //skip
                    }
                }
                #endregion

                currRow.Activity = "Sleeping"; /* Processing completed */

                if(!_statusHolder.ContainsKey(currRow.Path))
                {
                    _statusHolder.Add(currRow.Path, new List<string> { gitFetchResult, gerritResult });
                }
            }

            if (_trayStatus == GitTrayStatusType.Running)
            {
                //Restart the timer if user has not requested to stop/halt
                TrayTimer.Start();
            }
            else
            {
                _trayStatus = GitTrayStatusType.Sleep;
            }
        }

        private void SettingsSplitButton_ButtonClick(object sender, EventArgs e)
        {
            var oFrm = new SettingWindowUI
            {
                Owner = this,
                StartPosition = FormStartPosition.CenterParent
            };
            oFrm.ShowDialog(this);
            oFrm.Dispose();

            //Load the new settings
            LoadGitSettings();
        }

        private void GitStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsSplitButton_ButtonClick(new object(), new EventArgs());
        }

        private void ReposButton_Click(object sender, EventArgs e)
        {
            var oFrm = new RepositoryWindowUI
            {
                Owner = this,
                StartPosition = FormStartPosition.CenterParent
            };
            oFrm.ShowDialog(this);
            oFrm.Dispose();

            //Refresh the data Grid
            RefreshTable();           
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            var oFrm = new Version
            {
                Owner = this,
                StartPosition = FormStartPosition.CenterParent
            };
            oFrm.ShowDialog(this);
            oFrm.Dispose();
        }

        /// <summary>
        /// Load the GUI and Initialise the timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GitTrayNewUI_Load(object sender, EventArgs e)
        {
            RefreshTable(); // Loads the Repository details from Database

            LoadGitSettings(); // Loads the Git Settings from Database

            BringToFront(); // Bring the Form to focus (done for quick access using keyboard)

            TrayTimer.Elapsed += GitTrayNotification; // Set delegate for timer

            TrayTimer.Start(); //Start monitoring Based on Time
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowGitTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void GitTrayNewUI_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void GitTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.BringToFront();
            this.Focus();
        }

        private void GitTrayNewUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Hide();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (gitTrayDataSet.GitTrayTable.Rows.Count > 0)
            {
                switch (_trayStatus)
                {
                    case GitTrayStatusType.Stopped:
                        _trayStatus = GitTrayStatusType.Running; // Toggle
                        StartStopButton.Visible = false;
                        StartStopButton.BackgroundImage = Properties.Resources.play;
                        StartStopButton.Visible = true;
                        break;
                    case GitTrayStatusType.Running:
                        _trayStatus = GitTrayStatusType.Stopped; // Toggle
                        StartStopButton.Visible = false;
                        StartStopButton.BackgroundImage = Properties.Resources.stopped;
                        StartStopButton.Visible = true;
                        break;
                    case GitTrayStatusType.Sleep:
                        TrayTimer.Start(); //Restart the timert
                        _trayStatus = GitTrayStatusType.Running;
                        StartStopButton.Visible = false;
                        StartStopButton.BackgroundImage = Properties.Resources.play;
                        StartStopButton.Visible = true;
                        break;
                }
            }
        }
    }
}

