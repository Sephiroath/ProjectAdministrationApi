using System;
using System.Collections.Generic;

namespace ProjectAdministration.Core.Models
{
    public partial class Project
    {
        public Project()
        {
            HumanPersonInProject = new HashSet<HumanPersonInProject>();
            ProjectTask = new HashSet<ProjectTask>();
        }

        public int ProjectId { get; set; }
        public string Identifier { get; set; }
        public string Description { get; set; }
        public int Phase { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }
        public int TotalHours { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string EditedBy { get; set; }
        public DateTime EditedAt { get; set; }

        public Phase PhaseNavigation { get; set; }
        public Priority PriorityNavigation { get; set; }
        public Status StatusNavigation { get; set; }
        public ICollection<HumanPersonInProject> HumanPersonInProject { get; set; }
        public ICollection<ProjectTask> ProjectTask { get; set; }
    }
}
