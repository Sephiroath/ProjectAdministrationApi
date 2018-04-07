using System;
using System.Collections.Generic;

namespace ProjectAdministration.Core.Models
{
    public partial class ImpedimentComment
    {
        public int ImpedimentCommentId { get; set; }
        public string Comment { get; set; }
        public int CommentedBy { get; set; }
        public int Impediment { get; set; }

        public HumanPersonInProject CommentedByNavigation { get; set; }
        public ProjectImpediment ImpedimentNavigation { get; set; }
    }
}
