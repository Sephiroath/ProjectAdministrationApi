namespace ProjectAdministration.Core.ViewModels
{
    public class ProjectViewModel : BaseViewModel
    {
        public int ProjectId { get; set; }
        public string Identifier { get; set; }
        public string Description { get; set; }
        public int Phase { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }
        public int TotalHours { get; set; }
        public PhaseViewModel PhaseViewModel { get; set; }
        public StatusViewModel StatusViewModel { get; set; }
        public PriorityViewModel PriorityViewModel { get; set; }
    }
}