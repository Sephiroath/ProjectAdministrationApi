using System;
using System.Collections.Generic;

namespace ProjectAdministration.Core.Models
{
    public partial class HumanPerson
    {
        public HumanPerson()
        {
            HumanPersonInProject = new HashSet<HumanPersonInProject>();
            HumanPersonRole = new HashSet<HumanPersonRole>();
        }

        public int HumanPersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactNumber { get; set; }
        public string EMail { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string EditedBy { get; set; }
        public DateTime EditedAt { get; set; }

        public ICollection<HumanPersonInProject> HumanPersonInProject { get; set; }
        public ICollection<HumanPersonRole> HumanPersonRole { get; set; }
    }
}
