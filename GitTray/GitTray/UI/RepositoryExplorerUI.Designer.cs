namespace GitTray.UI
{
    partial class RepositoryExplorerUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepositoryExplorerUI));
            this.BckBtn = new MetroFramework.Controls.MetroLink();
            this.repoDirectoryExplorer = new GitTray.Utility.DirectoryExplorer();
            this.repositoryLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // BckBtn
            // 
            this.BckBtn.BackColor = System.Drawing.Color.Transparent;
            this.BckBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BckBtn.Image = global::GitTray.Properties.Resources.backBtn;
            this.BckBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BckBtn.ImageSize = 60;
            this.BckBtn.Location = new System.Drawing.Point(3, 22);
            this.BckBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BckBtn.Name = "BckBtn";
            this.BckBtn.Size = new System.Drawing.Size(49, 34);
            this.BckBtn.TabIndex = 4;
            this.BckBtn.UseSelectable = true;
            this.BckBtn.Click += new System.EventHandler(this.BckBtn_Click);
            // 
            // repoDirectoryExplorer
            // 
            this.repoDirectoryExplorer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.repoDirectoryExplorer.Location = new System.Drawing.Point(176, 84);
            this.repoDirectoryExplorer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.repoDirectoryExplorer.Name = "repoDirectoryExplorer";
            this.repoDirectoryExplorer.Size = new System.Drawing.Size(830, 34);
            this.repoDirectoryExplorer.TabIndex = 0;
            // 
            // repositoryLabel
            // 
            this.repositoryLabel.AutoSize = true;
            this.repositoryLabel.Location = new System.Drawing.Point(23, 89);
            this.repositoryLabel.Name = "repositoryLabel";
            this.repositoryLabel.Size = new System.Drawing.Size(107, 20);
            this.repositoryLabel.TabIndex = 5;
            this.repositoryLabel.Text = "Local Repo Path";
            // 
            // RepositoryExplorerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 135);
            this.Controls.Add(this.repositoryLabel);
            this.Controls.Add(this.repoDirectoryExplorer);
            this.Controls.Add(this.BckBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RepositoryExplorerUI";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowInTaskbar = false;
            this.Text = "    Repository Explorer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RepositoryBrowser_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLink BckBtn;
        public Utility.DirectoryExplorer repoDirectoryExplorer;
        private MetroFramework.Controls.MetroLabel repositoryLabel;
    }
}