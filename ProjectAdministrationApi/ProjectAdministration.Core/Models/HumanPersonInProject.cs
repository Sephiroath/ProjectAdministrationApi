using System;
using System.Collections.Generic;

namespace ProjectAdministration.Core.Models
{
    public partial class HumanPersonInProject
    {
        public HumanPersonInProject()
        {
            ImpedimentComment = new HashSet<ImpedimentComment>();
            ProjectImpedimentReportedAtNavigation = new HashSet<ProjectImpediment>();
            ProjectImpedimentReportedByNavigation = new HashSet<ProjectImpediment>();
            ProjectTask = new HashSet<ProjectTask>();
        }

        public int HumanPerson { get; set; }
        public int HumanPersonInProjectId { get; set; }
        public int Project { get; set; }

        public HumanPerson HumanPersonNavigation { get; set; }
        public Project ProjectNavigation { get; set; }
        public ICollection<ImpedimentComment> ImpedimentComment { get; set; }
        public ICollection<ProjectImpediment> ProjectImpedimentReportedAtNavigation { get; set; }
        public ICollection<ProjectImpediment> ProjectImpedimentReportedByNavigation { get; set; }
        public ICollection<ProjectTask> ProjectTask { get; set; }
    }
}
