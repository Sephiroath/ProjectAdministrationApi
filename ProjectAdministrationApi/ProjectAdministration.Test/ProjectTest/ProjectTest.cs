using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using ProjectAdministration.Core.Models;
using ProjectAdministration.Service.ProjectServices;
using Xunit;

namespace ProjectAdministration.Test.ProjectTest
{
    public class ProjectTest :BaseTest
    {
        private readonly IProjectService _projectService;

        public ProjectTest(MapperFixture mapperFixture) : base(mapperFixture)
        {
            _projectService = new ProjectService(ProjectRepositoryMock.Object);
        }
        [Fact]
        public async Task CanCreateProject()
        {
            var projectViewModel = TestDataProvider.ProjectViewModel;
            ProjectRepositoryMock.Setup(f => f.AddAsync(It.IsAny<Project>())).Returns(Task.FromResult(TestDataProvider.Project));
            var idProject = await _projectService.CreateProject(projectViewModel);
            Assert.False(idProject == 0);
        }
        [Fact]
        public async Task CanGetProjects()
        {
            ProjectRepositoryMock.Setup(f => f.ListAllAsync()).Returns(Task.FromResult(new List<Project>() { TestDataProvider.Project }));
            var projectList = await _projectService.GetProjectsAsync();
            Assert.True(projectList.Any());
        }
        [Fact]
        public async Task CanGetProjectById()
        {
            ProjectRepositoryMock.Setup(f => f.GetByIdAsync(1)).Returns(Task.FromResult(TestDataProvider.Project));
            var project = await _projectService.GetProjectById(1);
            Assert.True(project.ProjectId == TestDataProvider.Project.ProjectId);
        }
        [Fact]
        public async Task CanGetProjectWithChildren()
        {
            ProjectRepositoryMock.Setup(f => f.GetByIdAsync(1)).Returns(Task.FromResult(TestDataProvider.Project));
            var project = await _projectService.GetProjectById(1);
            Assert.True(project.ProjectId == TestDataProvider.Project.ProjectId);
            Assert.True(project.PhaseViewModel.PhaseId == TestDataProvider.Phase.PhaseId);
            Assert.True(project.StatusViewModel.StatusId == TestDataProvider.StatusViewModel.StatusId);
            Assert.True(project.PriorityViewModel.PriorityId == TestDataProvider.PriorityViewModel.PriorityId);
        }
    }
}
