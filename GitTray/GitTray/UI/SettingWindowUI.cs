using System;
using MetroFramework;
using System.Windows.Forms;

namespace GitTray.UI
{

    public partial class SettingWindowUI : MetroFramework.Forms.MetroForm
    {
        private bool _isChangedProgrametically = false;

        public string GitPath { get; set; }

        public string GerritPvtKey { get; set; }

        public SettingWindowUI()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape || keyData == Keys.Enter)
            {
                this.Close();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Save the changes to DataBase
        /// </summary>
        private void SaveAndUpdateTable()
        {
            gitSettingsBindingSource.EndEdit();
            gitSettingsTableAdapter.Update(this.gitTrayGitSettingsDataSet.GitSettings);
        }
        
        private void SettingWindowNewUI_Load(object sender, EventArgs e)
        {
            #region Git Settings
            // Load Git Settings from DataBase
            this.gitSettingsTableAdapter.Fill(this.gitTrayGitSettingsDataSet.GitSettings);
            gitSettingsBindingSource.DataSource = this.gitTrayGitSettingsDataSet.GitSettings;

            LoadGitSettings();
            #endregion
        }
        
        private void LoadGitDirectoryExplorer()
        {
            GitPath = this.gitTrayGitSettingsDataSet.GitSettings[0].GitLocation;
            gitDirectoryExplorer.mDirPath.Text = GitPath;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingWindowNewUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            ValidateGitSettings(e);

            SaveAndUpdateTable();
        }

        private void ValidateGitSettings(FormClosingEventArgs e)
        {
            this.gitTrayGitSettingsDataSet.GitSettings[0].FetchType = fetchTypeComboBox.Text;
            this.gitTrayGitSettingsDataSet.GitSettings[0].LogFormat = logFormatComboBox.Text;
            this.gitTrayGitSettingsDataSet.GitSettings[0].PollPeriod = (int)pollCycle.Value;
            this.gitTrayGitSettingsDataSet.GitSettings[0].AutoMerge = false; ;

            if (_isChangedProgrametically != true) // skip on cancel
            {
                DialogResult result = MetroMessageBox.Show(this, "Changes will be reflected only for repositories added in future !", "Git Tray Info Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                {
                    _isChangedProgrametically = true;
                    recursiveSubmoduleEnable.Checked = recursiveSubmoduleEnable.Checked == true ? false : true;
                }
                else
                {
                    this.gitTrayGitSettingsDataSet.GitSettings[0].RecursiveSubmoduleSearch = recursiveSubmoduleEnable.Checked;
                }
            }
            else
            {
                _isChangedProgrametically = false;
            }

            if (System.IO.File.Exists(gitDirectoryExplorer.mDirPath.Text + @"\git.exe"))
            {
                GitPath = gitDirectoryExplorer.mDirPath.Text;
                this.gitTrayGitSettingsDataSet.GitSettings[0].GitLocation = GitPath;
            }
            else
            {
                DialogResult result;
                if (string.IsNullOrEmpty(gitDirectoryExplorer.mDirPath.Text))
                {
                    result = MetroMessageBox.Show(this, "Git Location cannot be empty !", "Git Tray Warining Message", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
                }
                else
                {
                    result = MetroMessageBox.Show(this, "Git not found ! Please enter a vaild path !", "Git Tray Warining Message", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
                }

                if (result == DialogResult.Abort || result == DialogResult.Ignore)
                {
                    GitPath = string.Empty;
                }
                else
                {
                    e.Cancel = true; //Cancel closing of the form
                }
            }
        }

        private void LoadGitSettings()
        {
            pollCycle.Value        = this.gitTrayGitSettingsDataSet.GitSettings[0].PollPeriod;
            logFormatComboBox.Text = this.gitTrayGitSettingsDataSet.GitSettings[0].LogFormat;
            fetchTypeComboBox.Text = this.gitTrayGitSettingsDataSet.GitSettings[0].FetchType;
            recursiveSubmoduleEnable.Checked = this.gitTrayGitSettingsDataSet.GitSettings[0].RecursiveSubmoduleSearch;
            LoadGitDirectoryExplorer();
        }
    }
}
