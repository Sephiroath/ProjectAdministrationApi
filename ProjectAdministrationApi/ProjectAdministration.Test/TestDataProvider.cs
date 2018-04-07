using System.Collections.Generic;
using ProjectAdministration.Core.Models;
using ProjectAdministration.Core.ViewModels;

namespace ProjectAdministration.Test
{
    public class TestDataProvider
    {
        public TestDataProvider()
        {
            InitializeData();
        }

        public void InitializeData()
        {
            Phase = new Phase()
            {
                PhaseId = 1,
                Description = "Planning",
                CompletedPercentage = 0
            };
            Status = new Status()
            {
                StatusId = 1,
                Description = "TODO",
                CompletedPercentage = 0
            };
            Priority = new Priority()
            {
                PriorityId = 1,
                Description = "LOW"
            };
            Project = new Project()
            {
                ProjectId = 1,
                Identifier = "Project 1",
                Description = "Test Project 1",
                Phase = 1,
                Priority = 1,
                TotalHours = 720,
                Status = 1,
                PhaseNavigation = Phase,
                StatusNavigation = Status,
                PriorityNavigation = Priority
            };
            PhaseViewModel = new PhaseViewModel()
            {
                PhaseId = 1,
                Description = "Planning",
                CompletedPercentage = 0
            };
            StatusViewModel = new StatusViewModel()
            {
                StatusId = 1,
                Description = "TODO",
                CompletedPercentage = 0
            };
            PriorityViewModel = new PriorityViewModel()
            {
                PriorityId = 1,
                Description = "LOW"
            };
            ProjectViewModel = new ProjectViewModel()
            {
                ProjectId = 1,
                Identifier = "Project 1",
                Description = "Test Project 1",
                Phase = 1,
                Priority = 1,
                TotalHours = 720,
                Status = 1
            };
            Projects = new List<Project>()
            {
                Project,
                new Project()
                {
                    ProjectId = 2,
                    Identifier = "Project 2",
                    Description = "Test Project 2",
                    Phase = 1,
                    Priority = 1,
                    TotalHours = 720,
                    Status = 1,
                    PhaseNavigation = Phase,
                    StatusNavigation = Status,
                    PriorityNavigation = Priority
                }
            };
        }

        public Project Project { get; set; }
        public Phase Phase { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public ProjectViewModel ProjectViewModel { get; set; }
        public PhaseViewModel PhaseViewModel { get; set; }
        public StatusViewModel StatusViewModel { get; set; }
        public PriorityViewModel PriorityViewModel { get; set; }
        public List<Project> Projects { get; set; }
        public List<HumanPerson> HumanPersons { get; set; }
        public List<ProjectImpediment> ProjectImpediments { get; set; }
    }
}