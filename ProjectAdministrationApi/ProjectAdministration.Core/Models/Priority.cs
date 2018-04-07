using System;
using System.Collections.Generic;

namespace ProjectAdministration.Core.Models
{
    public partial class Priority
    {
        public Priority()
        {
            Project = new HashSet<Project>();
        }

        public int PriorityId { get; set; }
        public string Description { get; set; }

        public ICollection<Project> Project { get; set; }
    }
}
