using System.Collections.Generic;
using FizzWare.NBuilder;
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
            Project = new Project()
            {
                ProjectId = 1,
                Identifier = "Project 1",
                Description = "Test Project 1",
                Phase = 1,
                Priority = 1,
                TotalHours = 720,
                Status = 1
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
                Project
            };
        }

        public Project Project { get; set; }
        public ProjectViewModel ProjectViewModel { get; set; }
        public List<Project> Projects { get; set; }
        public List<HumanPerson> HumanPersons { get; set; }
        public List<ProjectImpediment> ProjectImpediments { get; set; }
    }
}