using System;
using System.Collections.Generic;

namespace ProjectAdministration.Core.Models
{
    public partial class Status
    {
        public Status()
        {
            Project = new HashSet<Project>();
            ProjectTask = new HashSet<ProjectTask>();
        }

        public int StatusId { get; set; }
        public int? CompletedPercentage { get; set; }
        public string Description { get; set; }

        public ICollection<Project> Project { get; set; }
        public ICollection<ProjectTask> ProjectTask { get; set; }
    }
}
