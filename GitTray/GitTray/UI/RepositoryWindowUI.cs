using System;
using MetroFramework;
using GitTray.Utility;
using System.Windows.Forms;
using GitTray.DataStructure;

namespace GitTray.UI
{
    public partial class RepositoryWindowUI : MetroFramework.Forms.MetroForm
    {
        private static volatile int _selectedCheckBoxCount = 0;
        private static volatile bool _changeIcon = false;

        public RepositoryWindowUI()
        {
            InitializeComponent();
        }

        private void MBtn_Click(object sender, EventArgs e)
        {
            // Remove Selected rows
            if(_selectedCheckBoxCount > 0)
            {
                if (MetroMessageBox.Show(this, "Are you sure you want to delete these record(s) ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int index = mGrid.Rows.Count - 1; index >= 0; index--)
                    {
                        if ((bool)mGrid.Rows[index].Cells[0].FormattedValue)
                        {
                            gitTrayTableBindingSource.RemoveAt(index);
                            _selectedCheckBoxCount--;
                        }
                    }

                    if (_changeIcon == true)
                    {
                        this.mAddBtn.Visible = false;
                        this.mAddBtn.TileImage = global::GitTray.Properties.Resources.add;
                        this.mAddBtn.Visible = true;

                        _changeIcon = false;
                    }
                }
            }
            
            //Add local repo
            else
            {
                var odir = new RepositoryExplorerUI
                {
                    Owner = this
                };
                odir.ShowDialog(this);

                if (odir.SubModules != null && odir.SubModules.Count > 0)
                {
                    foreach (var submodule in odir.SubModules)
                    {
                        var fullPath = String.Format(@"{0}/{1}", odir.Path, submodule);
                        GitTrayDataSet.GitTrayTableRow newItem = CreateTabEntry(fullPath);
                        this.gitTrayDataSet.GitTrayTable.AddGitTrayTableRow(newItem);
                        gitTrayTableBindingSource.MoveLast();
                    }
                }
                else if (!string.IsNullOrEmpty(odir.Path))
                {
                    GitTrayDataSet.GitTrayTableRow newItem = CreateTabEntry(odir.Path);

                    this.gitTrayDataSet.GitTrayTable.AddGitTrayTableRow(newItem);
                    gitTrayTableBindingSource.MoveLast();
                }
            }
        }

        private GitTrayDataSet.GitTrayTableRow CreateTabEntry(string Path)
        {
            var newItem = this.gitTrayDataSet.GitTrayTable.NewGitTrayTableRow();
            newItem.Path = Path;
            newItem.Activity = "Sleeping";
            newItem.Git_Status = GitStatusType.NoChange.ToString();
            return newItem;
        }

        /// <summary>
        /// Save the changes to DB
        /// </summary>
        private void SaveAndUpdateTable()
        {
            gitTrayTableBindingSource.EndEdit();
            gitTrayTableAdapter.Update(this.gitTrayDataSet.GitTrayTable);
        }

        private void MGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Detele through Check Box
            if (mGrid.Columns[e.ColumnIndex].Name == "selectBox")
            {
                // Check checkbox selected
                if ((bool)mGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue)
                {
                    _selectedCheckBoxCount++;
                }
                else
                {
                    if (_selectedCheckBoxCount > 0)
                    {
                        _selectedCheckBoxCount--;
                    }
                }
            }

            // Delete through embedded delete button
            if (mGrid.Columns[e.ColumnIndex].Name=="Delete")
            {
                if(MetroMessageBox.Show(this, "Are you sure you want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    // Is the row also selected via Check Box?
                    if ((bool)mGrid.Rows[e.RowIndex].Cells[0].EditedFormattedValue && _selectedCheckBoxCount > 0)
                    {
                        _selectedCheckBoxCount--;
                    }

                    gitTrayTableBindingSource.RemoveCurrent();
                }
            }

            // Change Icon of the button based to Add/Delete.
            switch (_changeIcon)
            {
                case true:
                    if (_selectedCheckBoxCount == 0)
                    {
                        this.mAddBtn.Visible = false;
                        this.mAddBtn.TileImage = global::GitTray.Properties.Resources.add;
                        this.mAddBtn.Visible = true;
                        _changeIcon = false;
                    }
                    break;

                case false:
                    if (_selectedCheckBoxCount > 0)
                    {
                        this.mAddBtn.Visible = false;
                        this.mAddBtn.TileImage = global::GitTray.Properties.Resources.delete;
                        this.mAddBtn.Visible = true;
                        _changeIcon = true;
                    }
                    break;
            }
        }

        private void RepoWindowNewUI_Load(object sender, EventArgs e)
        {
            this.gitTrayTableAdapter.Fill(this.gitTrayDataSet.GitTrayTable);
            gitTrayTableBindingSource.DataSource = this.gitTrayDataSet.GitTrayTable;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BckBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RepoWindowNewUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            //Wait till current process is over
            while (GitExtensions.IsGitProcessRunning) ;

            SaveAndUpdateTable();
        }
    }
}
