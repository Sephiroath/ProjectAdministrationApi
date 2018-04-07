using System;
using System.Collections.Generic;

namespace ProjectAdministration.Core.Models
{
    public partial class Phase
    {
        public Phase()
        {
            Project = new HashSet<Project>();
            ProjectImpediment = new HashSet<ProjectImpediment>();
            ProjectTask = new HashSet<ProjectTask>();
        }

        public int PhaseId { get; set; }
        public string Description { get; set; }
        public int CompletedPercentage { get; set; }

        public ICollection<Project> Project { get; set; }
        public ICollection<ProjectImpediment> ProjectImpediment { get; set; }
        public ICollection<ProjectTask> ProjectTask { get; set; }
    }
}
