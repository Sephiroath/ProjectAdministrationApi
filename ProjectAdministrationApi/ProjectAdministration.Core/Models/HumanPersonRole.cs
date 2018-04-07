using System;
using System.Collections.Generic;

namespace ProjectAdministration.Core.Models
{
    public partial class HumanPersonRole
    {
        public int Role { get; set; }
        public int HumanPerson { get; set; }
        public int HumanPersonRoleId { get; set; }

        public HumanPerson HumanPersonNavigation { get; set; }
        public Role RoleNavigation { get; set; }
    }
}
