using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTray.Utility
{
    public partial class DirectoryExplorer : UserControl
    {
        public DirectoryExplorer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get Path from Folder Explorer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void direxplore_Click(object sender, EventArgs e)
        {
            DialogResult result = BrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                mDirPath.Text = BrowserDialog.SelectedPath;
            }
        }
    }
}
