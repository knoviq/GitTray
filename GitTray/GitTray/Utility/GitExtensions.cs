using System;
using GitTray.UI;
using System.Data;
using System.Text;
using System.Linq;
using System.Diagnostics;
using GitTray.DataStructure;
using System.Collections.Generic;

namespace GitTray.Utility
{
    internal class GitStreamReader
    {
        public List<string> StandardError;
        public List<string> StandardOutput;

        public GitStreamReader()
        {
            StandardError = new List<string>();
            StandardOutput = new List<string>();
        }
    }

    internal struct GitSSHRevisions
    {
        public string LocalHead;
        public string RemoteHead;
        public string BaseHead;
    }

    class GitProcess
    {
        private Process _gitProcess;

        public GitStreamReader StdData { get; set; }

        public GitProcess(ProcessStartInfo Config)
        {
            StdData = new GitStreamReader();

            _gitProcess = new Process();

            _gitProcess.StartInfo = Config;
        }

        public GitStreamReader RunProcess()
        {            
            _gitProcess.Start();

            string stream = String.Empty;
            try
            {
                while ((stream = _gitProcess.StandardOutput.ReadLine()) != null)
                {
                    StdData.StandardOutput.Add(stream);
                }
                while ((stream = _gitProcess.StandardError.ReadLine()) != null)
                {
                    StdData.StandardError.Add(stream);
                }
            }
            catch (InvalidOperationException)
            {
                //Skip the process
            }

            _gitProcess.Close();

            return StdData;
        }
    }

    public static class GitExtensions
    {
        private const string DryFetch = @"fetch origin --dry-run";
        private const string AutoFetch = @"fetch origin";
        private const string showRemote = @"remote -v";
        private const string BaseRevParse = @"merge-base @ @{u}";
        private const string LocalRevParse = @"rev-parse @";
        private const string RemoteRevParse = @"rev-parse @{u}";
        private const string SubmodulesSearch = @"submodule status";
        private const string RecursiveSubmodulesSearch = @"submodule status --recursive";
        private const string Log = @"log --pretty=format:[%s][%an][%ad] --decorate --date=relative -1 ";

        private static string _getSubmodulesCmd;
        private static string _logCmd;
        private static string _fetchCmd;
        private static string _logFormat;

        public static bool IsGitProcessRunning { get; private set; }

        private static ProcessStartInfo GitConfig { get; set; }

        private static ProcessStartInfo CreateGitProcess(UsersGitConfiguration Settings)//, out Process gitProcess)
        {
            ProcessStartInfo gitInfo = new ProcessStartInfo
            {
                CreateNoWindow = true,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                FileName = Settings.GitLocation + @"\git.exe",
                UseShellExecute = false
            };

            return gitInfo;
        }

        private static void CreateMessage(StringBuilder message, DisplayText displayText)
        {
            if (_logFormat == @"Detail Log (Max 256 char)")
            {
                message.AppendLine("\n" + displayText.Branch.Trim());
                message.AppendLine(displayText.Log.Trim() + " (" + displayText.Name.Trim() + ")");
            }
            else
            {
                message.AppendLine("\n" + displayText.Branch.Trim());
            }
        }

        private static void CreateMessage(StringBuilder message, string errorLog)
        {
            message.AppendLine("\n" + errorLog);
        }

        private static void GetCommitLog(List<string> fetchResult, StringBuilder message)
        {
            foreach (var br in fetchResult)
            {
                if (!br.Contains("fatal:"))
                {
                    //Get commit message of remote
                    var getLog = GetCommitLog(br);

                    DisplayText displayText;
                    displayText.Branch = br.Trim();
                    displayText.Log = getLog[0];
                    displayText.Name = getLog[1];

                    CreateMessage(message, displayText);
                }
                else
                {
                    CreateMessage(message, br);
                }
            }
        }

        private static List<string> GetCommitLog(string remotebranch)
        {
            List<string> result = new List<string>();
            char[] delimiter = { '[', ']', '\r', '\n' };
            string[] space = { "\b" };

            GitConfig.Arguments = _logCmd + remotebranch.Split(space, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();

            GitProcess newProcess = new GitProcess(GitConfig);

            var stdOut = newProcess.RunProcess().StandardOutput;
            foreach (var item in stdOut)
            {
                if (item == null) continue;
                var splitLine = item.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(splitLine);
            }            

            return result;
        }

        private static string ProcessGitRepo(ref List<string> fetchResult, string GitRepo)
        {
            string repoStatus = String.Empty;

            GitConfig.WorkingDirectory = GitRepo;

            bool isError = FetchGitRepo(ref fetchResult);

            if (isError == false)
            {
                GitSSHRevisions rev = GetSSHDiffernce();

                if (rev.LocalHead != null && rev.RemoteHead != null && rev.BaseHead != null)
                {
                    SetStatus(ref repoStatus, rev);
                }
            }
            else
            {
                repoStatus = "fatal: Connection Error!";
            }

            return repoStatus;
        }

        private static bool FetchGitRepo(ref List<string> fetchResult)
        {
            char[] delimiter = { '>', '\r', '\n' };
            bool isError = false;
            GitConfig.Arguments = _fetchCmd;

            GitProcess newProcess = new GitProcess(GitConfig);
            GitStreamReader stdFetchData = newProcess.RunProcess();

            foreach (var item in stdFetchData.StandardError)
            {
                if (item != null && item.Contains("->"))
                {
                    var splitLine = item.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                    fetchResult.AddRange(splitLine.Where(o => o.Contains("origin")));
                }
                else if (item != null && item.Contains("fatal:"))
                {
                    var splitLine = item.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                    fetchResult.AddRange(splitLine);
                    isError = true;
                }
            }

            return isError;
        }

        private static GitSSHRevisions GetSSHDiffernce()
        {
            GitSSHRevisions rev;
            rev.BaseHead = rev.LocalHead = rev.RemoteHead = null;

            GitConfig.Arguments = LocalRevParse;

            GitProcess newProcess = new GitProcess(GitConfig);
            var stdData = newProcess.RunProcess();
            foreach (var item in stdData.StandardOutput)
            {
                rev.LocalHead = item;
            }

            GitConfig.Arguments = BaseRevParse;

            newProcess = new GitProcess(GitConfig);
            stdData = newProcess.RunProcess();
            foreach (var item in stdData.StandardOutput)
            {
                rev.BaseHead = item;
            }

            //Debug : ls-remote origin -h refs/heads/master
            GitConfig.Arguments = RemoteRevParse;

            newProcess = new GitProcess(GitConfig);
            stdData = newProcess.RunProcess();
            foreach (var item in stdData.StandardOutput)
            {
                rev.RemoteHead = item;
            }

            return rev;
        }

        private static List<string> GetSubmodulesList()
        {
            var submoduleList = new List<string>();

            GitConfig.Arguments = _getSubmodulesCmd;

            GitProcess newProcess = new GitProcess(GitConfig);
            GitStreamReader getSubmodules = newProcess.RunProcess();
            foreach (var item in getSubmodules.StandardOutput)
            {
                if (item != null)
                {
                    var submodule = item.TrimStart().Split(null).Skip(1).FirstOrDefault();
                    if (!string.IsNullOrEmpty(submodule))
                    {
                        submoduleList.Add(submodule);
                    }
                }
            }

            return submoduleList;
        }

        private static void SetStatus(ref string repoStatus, GitSSHRevisions Rev)
        {
            if (Rev.LocalHead.Equals(Rev.RemoteHead))
                repoStatus = "Up-to-date";

            else if (Rev.LocalHead.Equals(Rev.BaseHead))
                repoStatus = "Pull-Requested";

            else if (Rev.RemoteHead.Equals(Rev.BaseHead))
                repoStatus = "Push-Changes";

            else
                repoStatus = "Diverged";
        }

        /// <summary>
        /// Set-up Git environment.
        /// </summary>
        /// <param name="Settings"></param>
        public static void UpdateGitConfiguration(UsersGitConfiguration Settings)
        {
            while (IsGitProcessRunning) ;  // wait till the current thread is complete

            _logCmd = Log;
            _logFormat = Settings.LogFormat;

            _getSubmodulesCmd = Settings.RecursiveSubmoduleSearch == true ? RecursiveSubmodulesSearch : SubmodulesSearch;

            _fetchCmd = Settings.FetchType == @"Manual" ? DryFetch : AutoFetch;
#if DEBUG
            GitTrayUI.TrayTimer.Interval = Convert.ToInt32(Settings.PollTime) * 100;
#else
            GitTrayUI.TrayTimer.Interval = Convert.ToInt32(Settings.PollTime) * 10000;
#endif
            GitConfig = CreateGitProcess(Settings);
        }

        /// <summary>
        /// Process each items in the Table
        /// </summary>
        /// <param name="repoList"></param>
        /// <returns>A string that is dispayed as the notification to user</returns>
        public static string ProcessGitRepo(ref string GitStatus, string RepoPath)
        {
            StringBuilder message = new StringBuilder();
            var fetchResult = new List<string>();           

            IsGitProcessRunning = true;

            GitStatus = ProcessGitRepo(ref fetchResult, RepoPath);
            GetCommitLog(fetchResult, message);

            IsGitProcessRunning = false;

            return message.ToString();
        }

        /// <summary>
        /// This method will fetch the submodules(if any) in the path passed 
        /// </summary>
        /// <param name="Path"></param>
        /// <returns>List of all the avaliable submodules or else empty</returns>
        public static List<string> PreProcessGitRepo(string Path)
        {
            GitConfig.WorkingDirectory = Path;
            return GetSubmodulesList();
        }

        /// <summary>
        /// Get the remote repository name
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        public static string GetRemoteRepo(string Path)
        {
            List<string> remoteRepo = new List<string>();
            bool isErr = false;

            GitConfig.WorkingDirectory = Path;
            GitConfig.Arguments = showRemote;

            GitProcess newProcess = new GitProcess(GitConfig);
            var stdData = newProcess.RunProcess();

            foreach (var item in stdData.StandardError)
            {
                if (item == null || item.Contains("fatal:"))
                {
                    isErr = true;
                    break;
                }
            }

            if (isErr == false)
            {
                foreach (var item in stdData.StandardOutput)
                {
                    remoteRepo.Add(item);
                }
            }

            return remoteRepo[0]; // return only fetch repo
        }
    }
}
