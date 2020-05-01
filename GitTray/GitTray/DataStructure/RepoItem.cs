using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTray.DataStructure
{
    public class RepoItem
    {
        public string Path { get; set; }

        public GitStatusType Activity { get; set; }
    }
}

