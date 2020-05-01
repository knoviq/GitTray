using GitTray.Utility;
using NUnit.Framework;

namespace GitTray.Test
{
    [TestFixture]
    public class GitExtensionTests
    {
        [Test]
        public void GitInvalidPath()
        {
            string path = @"D:\04_SideProjects";
            string gitFetchResult = string.Empty;
            string gitStatus = string.Empty;

            gitFetchResult = GitExtensions.ProcessGitRepo(ref gitStatus, path);
            string expectedResult = "";

            Assert.That(expectedResult, Is.EqualTo(15));
        }
    }
}
