
namespace GitTray.DataStructure
{
    public class UsersGitConfiguration
    {
        public int PollTime { get; set; }
        public bool RecursiveSubmoduleSearch { get; set; }
        public bool AutoMerge { get; set; }
        public string LogFormat { get; set; }
        public string FetchType { get; set; }
        public string GitLocation { get; set; }
        public bool IsInititialised { get; set; }
    }
}
