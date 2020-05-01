namespace GitTray.UI
{
    public partial class Version
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Version));
            this.Description = new MetroFramework.Controls.MetroLabel();
            this.VersionInfo = new MetroFramework.Controls.MetroLabel();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(30, 62);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(108, 20);
            this.Description.TabIndex = 1;
            this.Description.Text = "Tool Information";
            // 
            // VersionInfo
            // 
            this.VersionInfo.AutoSize = true;
            this.VersionInfo.Location = new System.Drawing.Point(30, 103);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.Size = new System.Drawing.Size(78, 20);
            this.VersionInfo.TabIndex = 4;
            this.VersionInfo.Text = "VersionInfo";
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.Image = global::GitTray.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(341, 25);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(265, 126);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 6;
            this.Logo.TabStop = false;
            // 
            // Version
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(628, 166);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.VersionInfo);
            this.Controls.Add(this.Description);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Version";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GitTray";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Description;
        private MetroFramework.Controls.MetroLabel VersionInfo;
        private System.Windows.Forms.PictureBox Logo;
    }
}