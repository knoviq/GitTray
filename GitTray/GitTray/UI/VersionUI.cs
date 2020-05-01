using System;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;

namespace GitTray.UI
{
    struct SwInfoFormat
    {
        internal string AuthorInfo;
        internal string CopyrightInfo;
        internal VersionFormat SwVersionInfo;
    }

    struct VersionFormat
    {
        internal string SwMajorVersion;
        internal string SwMinorVersion;
        internal string SwBuildVersion;
        internal string BuildDate;
    }

    public partial class Version : MetroFramework.Forms.MetroForm
    {
        private static readonly int _buildVersionCalibration = 6485;

        private readonly SwInfoFormat _swInfo;

        public Version()
        {
            InitializeComponent();
            _swInfo = SwInfoFormat();
            Load += Version_Load;
            Text = Text + @" v" + _swInfo.SwVersionInfo.SwMajorVersion + @"." + _swInfo.SwVersionInfo.SwMinorVersion;
        }

        public void Version_Load(object sender, EventArgs e)
        {
            StringBuilder details = new StringBuilder();
            details.AppendFormat("Author: {0}", _swInfo.AuthorInfo + Environment.NewLine);
            details.AppendFormat("Version: v{0}.{1} (Build: {2})", _swInfo.SwVersionInfo.SwMajorVersion,
            _swInfo.SwVersionInfo.SwMinorVersion, _swInfo.SwVersionInfo.SwBuildVersion);
            details.AppendFormat(Environment.NewLine + "Last Build: {0}", _swInfo.SwVersionInfo.BuildDate);
            details.Append(Environment.NewLine + _swInfo.CopyrightInfo);
            VersionInfo.Text = (details.ToString());
        }

        private static SwInfoFormat SwInfoFormat()
        {
            SwInfoFormat swInfoFormat;
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            var compInf = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
            DateTime buildDate = new DateTime(2000, 1, 1).AddDays(version.Build).AddSeconds(version.Revision * 2);

            #region About Information
            int buildVersion = version.Build - _buildVersionCalibration; // To have zero based build version
            
            swInfoFormat.AuthorInfo = @"Shuvam Das";
            swInfoFormat.CopyrightInfo = compInf.LegalCopyright;
            swInfoFormat.SwVersionInfo.SwMajorVersion = version.Major.ToString();
            swInfoFormat.SwVersionInfo.SwMinorVersion = version.Minor.ToString();
            swInfoFormat.SwVersionInfo.SwBuildVersion = buildVersion.ToString();
            swInfoFormat.SwVersionInfo.BuildDate = buildDate.ToString();
            #endregion

            return swInfoFormat;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter || keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
