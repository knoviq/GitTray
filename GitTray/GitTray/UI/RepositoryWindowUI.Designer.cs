namespace GitTray.UI
{
    partial class RepositoryWindowUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepositoryWindowUI));
            this.mLabel = new MetroFramework.Controls.MetroLabel();
            this.mAddBtn = new MetroFramework.Controls.MetroTile();
            this.mdataGridView = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mGrid = new MetroFramework.Controls.MetroGrid();
            this.selectBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gitTrayTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gitTrayDataSet = new GitTray.GitTrayDataSet();
            this.gitTrayTableAdapter = new GitTray.GitTrayDataSetTableAdapters.GitTrayTableTableAdapter();
            this.BckBtn = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.mdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitTrayTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitTrayDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.BackColor = System.Drawing.Color.Transparent;
            this.mLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mLabel.Location = new System.Drawing.Point(251, 41);
            this.mLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(319, 25);
            this.mLabel.TabIndex = 2;
            this.mLabel.Text = "Add/Delete local Repositories to monitor";
            this.mLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mAddBtn
            // 
            this.mAddBtn.ActiveControl = null;
            this.mAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.mAddBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mAddBtn.Location = new System.Drawing.Point(744, 52);
            this.mAddBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mAddBtn.Name = "mAddBtn";
            this.mAddBtn.Size = new System.Drawing.Size(44, 174);
            this.mAddBtn.TabIndex = 0;
            this.mAddBtn.TileImage = global::GitTray.Properties.Resources.add;
            this.mAddBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mAddBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mAddBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mAddBtn.UseSelectable = true;
            this.mAddBtn.UseTileImage = true;
            this.mAddBtn.Click += new System.EventHandler(this.MBtn_Click);
            // 
            // mdataGridView
            // 
            this.mdataGridView.AllowUserToDeleteRows = false;
            this.mdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.mdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.mdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mdataGridView.Location = new System.Drawing.Point(18, 52);
            this.mdataGridView.Name = "mdataGridView";
            this.mdataGridView.Size = new System.Drawing.Size(721, 174);
            this.mdataGridView.TabIndex = 1;
            // 
            // mGrid
            // 
            this.mGrid.AllowUserToAddRows = false;
            this.mGrid.AllowUserToDeleteRows = false;
            this.mGrid.AllowUserToResizeRows = false;
            this.mGrid.AutoGenerateColumns = false;
            this.mGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectBox,
            this.pathDataGridViewTextBoxColumn,
            this.Delete});
            this.mGrid.DataSource = this.gitTrayTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.mGrid.EnableHeadersVisualStyles = false;
            this.mGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGrid.Location = new System.Drawing.Point(29, 67);
            this.mGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mGrid.Name = "mGrid";
            this.mGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGrid.RowTemplate.Height = 24;
            this.mGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGrid.Size = new System.Drawing.Size(704, 149);
            this.mGrid.TabIndex = 6;
            this.mGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MGrid_CellContentClick);
            // 
            // selectBox
            // 
            this.selectBox.HeaderText = "";
            this.selectBox.Name = "selectBox";
            this.selectBox.Width = 20;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.Width = 775;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Deletes the current row.";
            this.Delete.UseColumnTextForButtonValue = true;
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
            // gitTrayTableAdapter
            // 
            this.gitTrayTableAdapter.ClearBeforeFill = true;
            // 
            // BckBtn
            // 
            this.BckBtn.BackColor = System.Drawing.Color.Transparent;
            this.BckBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BckBtn.Image = global::GitTray.Properties.Resources.backBtn;
            this.BckBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BckBtn.ImageSize = 60;
            this.BckBtn.Location = new System.Drawing.Point(2, 18);
            this.BckBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BckBtn.Name = "BckBtn";
            this.BckBtn.Size = new System.Drawing.Size(37, 28);
            this.BckBtn.TabIndex = 7;
            this.BckBtn.UseSelectable = true;
            this.BckBtn.Click += new System.EventHandler(this.BckBtn_Click);
            // 
            // RepositoryWindowUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(792, 235);
            this.Controls.Add(this.BckBtn);
            this.Controls.Add(this.mGrid);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.mAddBtn);
            this.Controls.Add(this.mdataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RepositoryWindowUI";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "    Repository Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RepoWindowNewUI_FormClosing);
            this.Load += new System.EventHandler(this.RepoWindowNewUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitTrayTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitTrayDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel mLabel;
        private MetroFramework.Controls.MetroTile mAddBtn;
        private System.Windows.Forms.DataGridView mdataGridView;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private MetroFramework.Controls.MetroGrid mGrid;
        private GitTrayDataSet gitTrayDataSet;
        private System.Windows.Forms.BindingSource gitTrayTableBindingSource;
        private GitTrayDataSetTableAdapters.GitTrayTableTableAdapter gitTrayTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private MetroFramework.Controls.MetroLink BckBtn;
    }
}