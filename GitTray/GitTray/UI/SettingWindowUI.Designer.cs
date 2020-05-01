namespace GitTray.UI
{
    partial class SettingWindowUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingWindowUI));
            this.ControlTab = new MetroFramework.Controls.MetroTabControl();
            this.GitControlTab = new MetroFramework.Controls.MetroTabPage();
            this.gitPathLabel = new MetroFramework.Controls.MetroLabel();
            this.gitDirectoryExplorer = new GitTray.Utility.DirectoryExplorer();
            this.recursiveSubmoduleEnable = new MetroFramework.Controls.MetroToggle();
            this.chckoutNewBrLabel = new MetroFramework.Controls.MetroLabel();
            this.autoMergeLabel = new MetroFramework.Controls.MetroLabel();
            this.autoMergeEnable = new MetroFramework.Controls.MetroToggle();
            this.logFormatComboBox = new MetroFramework.Controls.MetroComboBox();
            this.logFormatLabel = new MetroFramework.Controls.MetroLabel();
            this.fetchTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.fetchTypeLable = new MetroFramework.Controls.MetroLabel();
            this.timeUnitLabel = new MetroFramework.Controls.MetroLabel();
            this.pollCycle = new System.Windows.Forms.NumericUpDown();
            this.PollLabel = new MetroFramework.Controls.MetroLabel();
            this.gitTrayGitSettingsDataSet = new GitTray.GitTrayGitSettingsDataSet();
            this.gitSettingsTableAdapter = new GitTray.GitTrayGitSettingsDataSetTableAdapters.GitSettingsTableAdapter();
            this.gitSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BackBtn = new MetroFramework.Controls.MetroLink();
            this.ControlTab.SuspendLayout();
            this.GitControlTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pollCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitTrayGitSettingsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlTab
            // 
            this.ControlTab.Controls.Add(this.GitControlTab);
            this.ControlTab.Location = new System.Drawing.Point(8, 64);
            this.ControlTab.Margin = new System.Windows.Forms.Padding(2);
            this.ControlTab.Name = "ControlTab";
            this.ControlTab.SelectedIndex = 0;
            this.ControlTab.Size = new System.Drawing.Size(901, 325);
            this.ControlTab.TabIndex = 0;
            this.ControlTab.UseSelectable = true;
            // 
            // GitControlTab
            // 
            this.GitControlTab.Controls.Add(this.gitPathLabel);
            this.GitControlTab.Controls.Add(this.gitDirectoryExplorer);
            this.GitControlTab.Controls.Add(this.recursiveSubmoduleEnable);
            this.GitControlTab.Controls.Add(this.chckoutNewBrLabel);
            this.GitControlTab.Controls.Add(this.autoMergeLabel);
            this.GitControlTab.Controls.Add(this.autoMergeEnable);
            this.GitControlTab.Controls.Add(this.logFormatComboBox);
            this.GitControlTab.Controls.Add(this.logFormatLabel);
            this.GitControlTab.Controls.Add(this.fetchTypeComboBox);
            this.GitControlTab.Controls.Add(this.fetchTypeLable);
            this.GitControlTab.Controls.Add(this.timeUnitLabel);
            this.GitControlTab.Controls.Add(this.pollCycle);
            this.GitControlTab.Controls.Add(this.PollLabel);
            this.GitControlTab.HorizontalScrollbarBarColor = true;
            this.GitControlTab.HorizontalScrollbarHighlightOnWheel = false;
            this.GitControlTab.HorizontalScrollbarSize = 10;
            this.GitControlTab.Location = new System.Drawing.Point(4, 38);
            this.GitControlTab.Margin = new System.Windows.Forms.Padding(2);
            this.GitControlTab.Name = "GitControlTab";
            this.GitControlTab.Size = new System.Drawing.Size(893, 283);
            this.GitControlTab.TabIndex = 0;
            this.GitControlTab.Text = "Git Settings";
            this.GitControlTab.VerticalScrollbarBarColor = true;
            this.GitControlTab.VerticalScrollbarHighlightOnWheel = false;
            this.GitControlTab.VerticalScrollbarSize = 10;
            // 
            // gitPathLabel
            // 
            this.gitPathLabel.AutoSize = true;
            this.gitPathLabel.Location = new System.Drawing.Point(0, 225);
            this.gitPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gitPathLabel.Name = "gitPathLabel";
            this.gitPathLabel.Size = new System.Drawing.Size(56, 20);
            this.gitPathLabel.TabIndex = 6;
            this.gitPathLabel.Text = "Git Path";
            // 
            // gitDirectoryExplorer
            // 
            this.gitDirectoryExplorer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gitDirectoryExplorer.BackColor = System.Drawing.Color.Transparent;
            this.gitDirectoryExplorer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gitDirectoryExplorer.Location = new System.Drawing.Point(96, 224);
            this.gitDirectoryExplorer.Margin = new System.Windows.Forms.Padding(2);
            this.gitDirectoryExplorer.Name = "gitDirectoryExplorer";
            this.gitDirectoryExplorer.Size = new System.Drawing.Size(776, 30);
            this.gitDirectoryExplorer.TabIndex = 0;
            // 
            // recursiveSubmoduleEnable
            // 
            this.recursiveSubmoduleEnable.AutoSize = true;
            this.recursiveSubmoduleEnable.Location = new System.Drawing.Point(252, 88);
            this.recursiveSubmoduleEnable.Margin = new System.Windows.Forms.Padding(2);
            this.recursiveSubmoduleEnable.Name = "recursiveSubmoduleEnable";
            this.recursiveSubmoduleEnable.Size = new System.Drawing.Size(80, 21);
            this.recursiveSubmoduleEnable.TabIndex = 17;
            this.recursiveSubmoduleEnable.Text = "Off";
            this.recursiveSubmoduleEnable.UseSelectable = true;
            // 
            // chckoutNewBrLabel
            // 
            this.chckoutNewBrLabel.AutoSize = true;
            this.chckoutNewBrLabel.Location = new System.Drawing.Point(0, 88);
            this.chckoutNewBrLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chckoutNewBrLabel.Name = "chckoutNewBrLabel";
            this.chckoutNewBrLabel.Size = new System.Drawing.Size(143, 20);
            this.chckoutNewBrLabel.TabIndex = 16;
            this.chckoutNewBrLabel.Text = "Recursive Submodule";
            // 
            // autoMergeLabel
            // 
            this.autoMergeLabel.AutoSize = true;
            this.autoMergeLabel.Location = new System.Drawing.Point(0, 152);
            this.autoMergeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autoMergeLabel.Name = "autoMergeLabel";
            this.autoMergeLabel.Size = new System.Drawing.Size(83, 20);
            this.autoMergeLabel.TabIndex = 15;
            this.autoMergeLabel.Text = "Auto Merge";
            // 
            // autoMergeEnable
            // 
            this.autoMergeEnable.AutoSize = true;
            this.autoMergeEnable.Enabled = false;
            this.autoMergeEnable.Location = new System.Drawing.Point(252, 152);
            this.autoMergeEnable.Margin = new System.Windows.Forms.Padding(2);
            this.autoMergeEnable.Name = "autoMergeEnable";
            this.autoMergeEnable.Size = new System.Drawing.Size(80, 21);
            this.autoMergeEnable.TabIndex = 14;
            this.autoMergeEnable.Text = "Off";
            this.autoMergeEnable.UseSelectable = true;
            // 
            // logFormatComboBox
            // 
            this.logFormatComboBox.FormattingEnabled = true;
            this.logFormatComboBox.ItemHeight = 24;
            this.logFormatComboBox.Items.AddRange(new object[] {
            "Detail Log (Max 256 char)",
            "Branch Info Only"});
            this.logFormatComboBox.Location = new System.Drawing.Point(550, 17);
            this.logFormatComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.logFormatComboBox.Name = "logFormatComboBox";
            this.logFormatComboBox.Size = new System.Drawing.Size(322, 30);
            this.logFormatComboBox.TabIndex = 11;
            this.logFormatComboBox.UseSelectable = true;
            // 
            // logFormatLabel
            // 
            this.logFormatLabel.AutoSize = true;
            this.logFormatLabel.Location = new System.Drawing.Point(454, 22);
            this.logFormatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logFormatLabel.Name = "logFormatLabel";
            this.logFormatLabel.Size = new System.Drawing.Size(79, 20);
            this.logFormatLabel.TabIndex = 10;
            this.logFormatLabel.Text = "Log Format";
            // 
            // fetchTypeComboBox
            // 
            this.fetchTypeComboBox.FormattingEnabled = true;
            this.fetchTypeComboBox.ItemHeight = 24;
            this.fetchTypeComboBox.Items.AddRange(new object[] {
            "Auto (update refs)",
            "Manual"});
            this.fetchTypeComboBox.Location = new System.Drawing.Point(550, 117);
            this.fetchTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.fetchTypeComboBox.Name = "fetchTypeComboBox";
            this.fetchTypeComboBox.Size = new System.Drawing.Size(322, 30);
            this.fetchTypeComboBox.TabIndex = 7;
            this.fetchTypeComboBox.UseSelectable = true;
            // 
            // fetchTypeLable
            // 
            this.fetchTypeLable.AutoSize = true;
            this.fetchTypeLable.Location = new System.Drawing.Point(454, 122);
            this.fetchTypeLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fetchTypeLable.Name = "fetchTypeLable";
            this.fetchTypeLable.Size = new System.Drawing.Size(77, 20);
            this.fetchTypeLable.TabIndex = 5;
            this.fetchTypeLable.Text = "Fetch Type";
            // 
            // timeUnitLabel
            // 
            this.timeUnitLabel.AutoSize = true;
            this.timeUnitLabel.Location = new System.Drawing.Point(231, 22);
            this.timeUnitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeUnitLabel.Name = "timeUnitLabel";
            this.timeUnitLabel.Size = new System.Drawing.Size(46, 20);
            this.timeUnitLabel.TabIndex = 4;
            this.timeUnitLabel.Text = "min(s)";
            // 
            // pollCycle
            // 
            this.pollCycle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pollCycle.Location = new System.Drawing.Point(85, 21);
            this.pollCycle.Margin = new System.Windows.Forms.Padding(4);
            this.pollCycle.Name = "pollCycle";
            this.pollCycle.Size = new System.Drawing.Size(141, 22);
            this.pollCycle.TabIndex = 3;
            // 
            // PollLabel
            // 
            this.PollLabel.AutoSize = true;
            this.PollLabel.Location = new System.Drawing.Point(0, 22);
            this.PollLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PollLabel.Name = "PollLabel";
            this.PollLabel.Size = new System.Drawing.Size(68, 20);
            this.PollLabel.TabIndex = 2;
            this.PollLabel.Text = "Poll Cycle";
            // 
            // gitTrayGitSettingsDataSet
            // 
            this.gitTrayGitSettingsDataSet.DataSetName = "GitTrayGitSettingsDataSet";
            this.gitTrayGitSettingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gitSettingsTableAdapter
            // 
            this.gitSettingsTableAdapter.ClearBeforeFill = true;
            // 
            // gitSettingsBindingSource
            // 
            this.gitSettingsBindingSource.DataMember = "GitSettings";
            this.gitSettingsBindingSource.DataSource = this.gitTrayGitSettingsDataSet;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackBtn.Image = global::GitTray.Properties.Resources.backBtn;
            this.BackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackBtn.ImageSize = 60;
            this.BackBtn.Location = new System.Drawing.Point(2, 22);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(48, 34);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.UseSelectable = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SettingWindowUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(915, 393);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ControlTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingWindowUI";
            this.Padding = new System.Windows.Forms.Padding(20, 75, 20, 20);
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "    Settings Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingWindowNewUI_FormClosing);
            this.Load += new System.EventHandler(this.SettingWindowNewUI_Load);
            this.ControlTab.ResumeLayout(false);
            this.GitControlTab.ResumeLayout(false);
            this.GitControlTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pollCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitTrayGitSettingsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl ControlTab;
        private MetroFramework.Controls.MetroTabPage GitControlTab;
        private MetroFramework.Controls.MetroLabel PollLabel;
        private MetroFramework.Controls.MetroLabel timeUnitLabel;
        internal System.Windows.Forms.NumericUpDown pollCycle;
        private MetroFramework.Controls.MetroLabel fetchTypeLable;
        private MetroFramework.Controls.MetroLabel gitPathLabel;
        private MetroFramework.Controls.MetroComboBox fetchTypeComboBox;
        private MetroFramework.Controls.MetroLabel logFormatLabel;
        private MetroFramework.Controls.MetroComboBox logFormatComboBox;
        private MetroFramework.Controls.MetroToggle recursiveSubmoduleEnable;
        private MetroFramework.Controls.MetroLabel chckoutNewBrLabel;
        private MetroFramework.Controls.MetroLabel autoMergeLabel;
        private MetroFramework.Controls.MetroToggle autoMergeEnable;
        private GitTrayGitSettingsDataSet gitTrayGitSettingsDataSet;
        private GitTrayGitSettingsDataSetTableAdapters.GitSettingsTableAdapter gitSettingsTableAdapter;
        private Utility.DirectoryExplorer gitDirectoryExplorer;
        private MetroFramework.Controls.MetroLink BackBtn;
        private System.Windows.Forms.BindingSource gitSettingsBindingSource;
    }
}