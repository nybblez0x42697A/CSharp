using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO.Classes
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Workspace { get; set; }
        public string StartDate { get; set; }
        public string Deadline { get; set; }
        public string TaskDuration { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
