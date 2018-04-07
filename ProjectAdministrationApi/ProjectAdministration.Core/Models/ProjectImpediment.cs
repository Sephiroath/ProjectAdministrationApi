using System;
using System.Collections.Generic;

namespace ProjectAdministration.Core.Models
{
    public partial class ProjectImpediment
    {
        public ProjectImpediment()
        {
            ImpedimentComment = new HashSet<ImpedimentComment>();
        }

        public int ProjectImpedimentId { get; set; }
        public string Description { get; set; }
        public int ReportedBy { get; set; }
        public int ReportedAt { get; set; }
        public int Phase { get; set; }
        public bool CanBlockProject { get; set; }
        public bool ApprovedByReporter { get; set; }

        public Phase PhaseNavigation { get; set; }
        public HumanPersonInProject ReportedAtNavigation { get; set; }
        public HumanPersonInProject ReportedByNavigation { get; set; }
        public ICollection<ImpedimentComment> ImpedimentComment { get; set; }
    }
}
