using System;
using System.Collections.Generic;

namespace ProjectAdministration.Core.Models
{
    public partial class Role
    {
        public Role()
        {
            HumanPersonRole = new HashSet<HumanPersonRole>();
            ProjectTask = new HashSet<ProjectTask>();
        }

        public int RoleId { get; set; }
        public string Description { get; set; }

        public ICollection<HumanPersonRole> HumanPersonRole { get; set; }
        public ICollection<ProjectTask> ProjectTask { get; set; }
    }
}
