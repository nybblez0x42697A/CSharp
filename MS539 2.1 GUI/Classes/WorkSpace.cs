using System.Collections.Generic;

namespace TODO.Classes
{
    public partial class Rootspace : Workspace
    {
        public Dictionary<string, Workspace> Workspaces { get; set; }

        public Rootspace()
        {
            Workspaces = new Dictionary<string, Workspace>();
        }
    }

    public class Workspace
    {
        public string WorkspaceName { get; set; }
        public Dictionary<string, Task> Tasks { get; set; }

        public Workspace()
        {
            Tasks = new Dictionary<string, Task>();
        }
    }
}
