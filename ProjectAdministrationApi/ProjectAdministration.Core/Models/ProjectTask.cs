using System;
using System.Collections.Generic;

namespace ProjectAdministration.Core.Models
{
    public partial class ProjectTask
    {
        public int ProjectTaskId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ActualStartDate { get; set; }
        public DateTime ActualEndDate { get; set; }
        public int Status { get; set; }
        public int Phase { get; set; }
        public int Project { get; set; }
        public int Role { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string EditedBy { get; set; }
        public DateTime EditedAt { get; set; }
        public int? Actor { get; set; }

        public HumanPersonInProject ActorNavigation { get; set; }
        public Phase PhaseNavigation { get; set; }
        public Project ProjectNavigation { get; set; }
        public Role RoleNavigation { get; set; }
        public Status StatusNavigation { get; set; }
    }
}
