namespace GitTray.Utility
{
    partial class DirectoryExplorer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mDirPath = new MetroFramework.Controls.MetroTextBox();
            this.BrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.direxplore = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mDirPath
            // 
            // 
            // 
            // 
            this.mDirPath.CustomButton.Image = null;
            this.mDirPath.CustomButton.Location = new System.Drawing.Point(606, 2);
            this.mDirPath.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mDirPath.CustomButton.Name = "";
            this.mDirPath.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mDirPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mDirPath.CustomButton.TabIndex = 1;
            this.mDirPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mDirPath.CustomButton.UseSelectable = true;
            this.mDirPath.CustomButton.Visible = false;
            this.mDirPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.mDirPath.Lines = new string[0];
            this.mDirPath.Location = new System.Drawing.Point(0, 0);
            this.mDirPath.Margin = new System.Windows.Forms.Padding(2);
            this.mDirPath.MaxLength = 32767;
            this.mDirPath.Name = "mDirPath";
            this.mDirPath.PasswordChar = '\0';
            this.mDirPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mDirPath.SelectedText = "";
            this.mDirPath.SelectionLength = 0;
            this.mDirPath.SelectionStart = 0;
            this.mDirPath.ShortcutsEnabled = true;
            this.mDirPath.Size = new System.Drawing.Size(719, 44);
            this.mDirPath.TabIndex = 0;
            this.mDirPath.UseSelectable = true;
            this.mDirPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mDirPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // direxplore
            // 
            this.direxplore.Dock = System.Windows.Forms.DockStyle.Right;
            this.direxplore.Image = global::GitTray.Properties.Resources.Search;
            this.direxplore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.direxplore.ImageSize = 50;
            this.direxplore.Location = new System.Drawing.Point(760, 0);
            this.direxplore.Margin = new System.Windows.Forms.Padding(2);
            this.direxplore.Name = "direxplore";
            this.direxplore.Size = new System.Drawing.Size(56, 44);
            this.direxplore.TabIndex = 2;
            this.direxplore.UseSelectable = true;
            this.direxplore.Click += new System.EventHandler(this.direxplore_Click);
            // 
            // DirectoryExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.direxplore);
            this.Controls.Add(this.mDirPath);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DirectoryExplorer";
            this.Size = new System.Drawing.Size(816, 44);
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Controls.MetroTextBox mDirPath;
        private MetroFramework.Controls.MetroLink direxplore;
        private System.Windows.Forms.FolderBrowserDialog BrowserDialog;
    }
}
