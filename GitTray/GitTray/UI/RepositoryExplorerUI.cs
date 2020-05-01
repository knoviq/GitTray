using System;
using MetroFramework;
using GitTray.Utility;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GitTray.UI
{
    public partial class RepositoryExplorerUI : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// User Defined Path
        /// </summary>
        public string Path { get; internal set; }

        /// <summary>
        /// List of SubModules
        /// </summary>
        public List<string> SubModules { get; set; }

        public RepositoryExplorerUI()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter || keyData == Keys.Escape)
            {
                this.Close();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BckBtn_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void RepositoryBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Path = repoDirectoryExplorer.mDirPath.Text;

            //Check is the path a valid git repository.
            if (!System.IO.Directory.Exists(Path + @"\.git") && !System.IO.File.Exists(Path + @"\.git"))
            {
                var result = MetroMessageBox.Show(this, "Path is not a valid git repository !", "Git Tray Warining Message", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
                if (result == DialogResult.Abort || result == DialogResult.Ignore)
                {
                    Path = string.Empty;
                }
                else
                {
                    e.Cancel = true; //Cancel closing of the form
                }
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                //Check and get the list of submodules
                SubModules = GitExtensions.PreProcessGitRepo(Path);
            }
        }
    }
}
