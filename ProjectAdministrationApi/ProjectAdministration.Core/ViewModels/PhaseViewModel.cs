namespace ProjectAdministration.Core.ViewModels
{
    public class PhaseViewModel : BaseViewModel
    {
        public int PhaseId { get; set; }
        public string Description { get; set; }
        public int CompletedPercentage { get; set; }
    }
}