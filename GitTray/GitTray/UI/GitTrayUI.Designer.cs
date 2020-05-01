namespace GitTray.UI
{
    partial class GitTrayUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripSplitButton GitTraySettingsSplitBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitTrayUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GitStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GitTrayMenuStrip = new System.Windows.Forms.ToolStrip();
            this.GitTrayRepositoryBtn = new System.Windows.Forms.ToolStripButton();
            this.MenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.GitTrayAboutBtn = new System.Windows.Forms.ToolStripButton();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.mainGridView = new MetroFramework.Controls.MetroGrid();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gitStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gitTrayTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gitTrayDataSet = new GitTray.GitTrayDataSet();
            this.StartStopButton = new MetroFramework.Controls.MetroButton();
            this.GitTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.GitTrayNotifierMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.showGitTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gitTrayGitSettingsDataSet = new GitTray.GitTrayGitSettingsDataSet();
            this.gitTrayGitSettingsTableAdapter = new GitTray.GitTrayGitSettingsDataSetTableAdapters.GitSettingsTableAdapter();
            this.gitTraySettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pathDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gitTrayTableAdapter = new GitTray.GitTrayDataSetTableAdapters.GitTrayTableTableAdapter();
            GitTraySettingsSplitBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.GitTrayMenuStrip.SuspendLayout();
            this.viewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitTrayTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitTrayDataSet)).BeginInit();
            this.GitTrayNotifierMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gitTrayGitSettingsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitTraySettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GitTraySettingsSplitBtn
            // 
            GitTraySettingsSplitBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GitStripMenuItem});
            GitTraySettingsSplitBtn.Image = global::GitTray.Properties.Resources.Settings;
            GitTraySettingsSplitBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            GitTraySettingsSplitBtn.ImageTransparentColor = System.Drawing.Color.Transparent;
            GitTraySettingsSplitBtn.Name = "GitTraySettingsSplitBtn";
            GitTraySettingsSplitBtn.Size = new System.Drawing.Size(95, 34);
            GitTraySettingsSplitBtn.Text = "Settings";
            GitTraySettingsSplitBtn.ToolTipText = "Settings";
            GitTraySettingsSplitBtn.ButtonClick += new System.EventHandler(this.SettingsSplitButton_ButtonClick);
            // 
            // GitStripMenuItem
            // 
            this.GitStripMenuItem.Image = global::GitTray.Properties.Resources.Git;
            this.GitStripMenuItem.Name = "GitStripMenuItem";
            this.GitStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.GitStripMenuItem.Text = "Git";
            this.GitStripMenuItem.Click += new System.EventHandler(this.GitStripMenuItem_Click);
            // 
            // GitTrayMenuStrip
            // 
            this.GitTrayMenuStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.GitTrayMenuStrip.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GitTrayMenuStrip.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.GitTrayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GitTrayRepositoryBtn,
            this.MenuSeparator1,
            GitTraySettingsSplitBtn,
            this.MenuSeparator2,
            this.GitTrayAboutBtn});
            this.GitTrayMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.GitTrayMenuStrip.Location = new System.Drawing.Point(15, 49);
            this.GitTrayMenuStrip.Name = "GitTrayMenuStrip";
            this.GitTrayMenuStrip.ShowItemToolTips = false;
            this.GitTrayMenuStrip.Size = new System.Drawing.Size(810, 37);
            this.GitTrayMenuStrip.TabIndex = 0;
            this.GitTrayMenuStrip.TabStop = true;
            // 
            // GitTrayRepositoryBtn
            // 
            this.GitTrayRepositoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("GitTrayRepositoryBtn.Image")));
            this.GitTrayRepositoryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GitTrayRepositoryBtn.Name = "GitTrayRepositoryBtn";
            this.GitTrayRepositoryBtn.Size = new System.Drawing.Size(105, 34);
            this.GitTrayRepositoryBtn.Text = "Repositories";
            this.GitTrayRepositoryBtn.Click += new System.EventHandler(this.ReposButton_Click);
            // 
            // MenuSeparator1
            // 
            this.MenuSeparator1.AutoSize = false;
            this.MenuSeparator1.Name = "MenuSeparator1";
            this.MenuSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // MenuSeparator2
            // 
            this.MenuSeparator2.AutoSize = false;
            this.MenuSeparator2.Name = "MenuSeparator2";
            this.MenuSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // GitTrayAboutBtn
            // 
            this.GitTrayAboutBtn.Image = ((System.Drawing.Image)(resources.GetObject("GitTrayAboutBtn.Image")));
            this.GitTrayAboutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GitTrayAboutBtn.Name = "GitTrayAboutBtn";
            this.GitTrayAboutBtn.Size = new System.Drawing.Size(74, 34);
            this.GitTrayAboutBtn.Text = "About";
            this.GitTrayAboutBtn.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // viewPanel
            // 
            this.viewPanel.BackColor = System.Drawing.Color.White;
            this.viewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewPanel.Controls.Add(this.mainGridView);
            this.viewPanel.Controls.Add(this.StartStopButton);
            this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPanel.Location = new System.Drawing.Point(15, 86);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(810, 137);
            this.viewPanel.TabIndex = 4;
            // 
            // mainGridView
            // 
            this.mainGridView.AllowUserToAddRows = false;
            this.mainGridView.AllowUserToDeleteRows = false;
            this.mainGridView.AllowUserToResizeRows = false;
            this.mainGridView.AutoGenerateColumns = false;
            this.mainGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mainGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mainGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pathDataGridViewTextBoxColumn,
            this.activityDataGridViewTextBoxColumn,
            this.gitStatusDataGridViewTextBoxColumn});
            this.mainGridView.DataSource = this.gitTrayTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.mainGridView.EnableHeadersVisualStyles = false;
            this.mainGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mainGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mainGridView.Location = new System.Drawing.Point(5, 2);
            this.mainGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainGridView.Name = "mainGridView";
            this.mainGridView.ReadOnly = true;
            this.mainGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mainGridView.RowHeadersWidth = 51;
            this.mainGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mainGridView.RowTemplate.Height = 24;
            this.mainGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainGridView.Size = new System.Drawing.Size(800, 105);
            this.mainGridView.TabIndex = 3;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.ReadOnly = true;
            this.pathDataGridViewTextBoxColumn.Width = 695;
            // 
            // activityDataGridViewTextBoxColumn
            // 
            this.activityDataGridViewTextBoxColumn.DataPropertyName = "Activity";
            this.activityDataGridViewTextBoxColumn.HeaderText = "Activity";
            this.activityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.activityDataGridViewTextBoxColumn.Name = "activityDataGridViewTextBoxColumn";
            this.activityDataGridViewTextBoxColumn.ReadOnly = true;
            this.activityDataGridViewTextBoxColumn.Width = 125;
            // 
            // gitStatusDataGridViewTextBoxColumn
            // 
            this.gitStatusDataGridViewTextBoxColumn.DataPropertyName = "Git Status";
            this.gitStatusDataGridViewTextBoxColumn.HeaderText = "Git Status";
            this.gitStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gitStatusDataGridViewTextBoxColumn.Name = "gitStatusDataGridViewTextBoxColumn";
            this.gitStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.gitStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // gitTrayTableBindingSource
            // 
            this.gitTrayTableBindingSource.DataMember = "GitTrayTable";
            this.gitTrayTableBindingSource.DataSource = this.gitTrayDataSet;
            // 
            // gitTrayDataSet
            // 
            this.gitTrayDataSet.DataSetName = "GitTrayDataSet";
            this.gitTrayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StartStopButton
            // 
            this.StartStopButton.BackColor = System.Drawing.Color.LightGray;
            this.StartStopButton.BackgroundImage = global::GitTray.Properties.Resources.power;
            this.StartStopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StartStopButton.Location = new System.Drawing.Point(720, 110);
            this.StartStopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(85, 28);
            this.StartStopButton.TabIndex = 1;
            this.StartStopButton.UseSelectable = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // GitTray
            // 
            this.GitTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.GitTray.ContextMenuStrip = this.GitTrayNotifierMenu;
            this.GitTray.Icon = ((System.Drawing.Icon)(resources.GetObject("GitTray.Icon")));
            this.GitTray.Text = "GitTray";
            this.GitTray.Visible = true;
            this.GitTray.BalloonTipClicked += new System.EventHandler(this.GitTrayNewUI_Load);
            this.GitTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GitTray_MouseDoubleClick);
            // 
            // GitTrayNotifierMenu
            // 
            this.GitTrayNotifierMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.GitTrayNotifierMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGitTrayToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.GitTrayNotifierMenu.Name = "GitTrayNotifierMenu";
            this.GitTrayNotifierMenu.Size = new System.Drawing.Size(104, 48);
            // 
            // showGitTrayToolStripMenuItem
            // 
            this.showGitTrayToolStripMenuItem.Name = "showGitTrayToolStripMenuItem";
            this.showGitTrayToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showGitTrayToolStripMenuItem.Text = "Show";
            this.showGitTrayToolStripMenuItem.Click += new System.EventHandler(this.ShowGitTrayToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn1.FillWeight = 14.45643F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Status";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // gitTrayGitSettingsDataSet
            // 
            this.gitTrayGitSettingsDataSet.DataSetName = "GitTrayGitSettingsDataSet";
            this.gitTrayGitSettingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gitTrayGitSettingsTableAdapter
            // 
            this.gitTrayGitSettingsTableAdapter.ClearBeforeFill = true;
            // 
            // pathDataGridViewTextBoxColumn1
            // 
            this.pathDataGridViewTextBoxColumn1.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn1.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.pathDataGridViewTextBoxColumn1.Name = "pathDataGridViewTextBoxColumn1";
            this.pathDataGridViewTextBoxColumn1.Width = 525;
            // 
            // gitTrayTableAdapter
            // 
            this.gitTrayTableAdapter.ClearBeforeFill = true;
            // 
            // GitTrayUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(840, 239);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.GitTrayMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "GitTrayUI";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Resizable = false;
            this.Text = "GitTray Main Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GitTrayNewUI_FormClosing);
            this.Load += new System.EventHandler(this.GitTrayNewUI_Load);
            this.Resize += new System.EventHandler(this.GitTrayNewUI_Resize);
            this.GitTrayMenuStrip.ResumeLayout(false);
            this.GitTrayMenuStrip.PerformLayout();
            this.viewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitTrayTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitTrayDataSet)).EndInit();
            this.GitTrayNotifierMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gitTrayGitSettingsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitTraySettingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip GitTrayMenuStrip;
        private System.Windows.Forms.ToolStripButton GitTrayRepositoryBtn;
        private System.Windows.Forms.ToolStripMenuItem GitStripMenuItem;
        private System.Windows.Forms.ToolStripButton GitTrayAboutBtn;
        private System.Windows.Forms.ToolStripSeparator MenuSeparator1;
        private System.Windows.Forms.ToolStripSeparator MenuSeparator2;
        private System.Windows.Forms.Panel viewPanel;
        private MetroFramework.Controls.MetroButton StartStopButton;
        private System.Windows.Forms.NotifyIcon GitTray;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private MetroFramework.Controls.MetroGrid mainGridView;
        private GitTrayDataSet gitTrayDataSet;
        private System.Windows.Forms.BindingSource gitTrayTableBindingSource;
        private GitTrayDataSetTableAdapters.GitTrayTableTableAdapter gitTrayTableAdapter;
        private MetroFramework.Controls.MetroContextMenu GitTrayNotifierMenu;
        private System.Windows.Forms.ToolStripMenuItem showGitTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private GitTrayGitSettingsDataSet gitTrayGitSettingsDataSet;
        private GitTrayGitSettingsDataSetTableAdapters.GitSettingsTableAdapter gitTrayGitSettingsTableAdapter;
        private System.Windows.Forms.BindingSource gitTraySettingsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gitStatusDataGridViewTextBoxColumn;
    }
}