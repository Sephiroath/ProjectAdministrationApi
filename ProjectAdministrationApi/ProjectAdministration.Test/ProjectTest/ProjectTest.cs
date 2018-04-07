using System.Threading.Tasks;
using AutoMapper;
using Moq;
using ProjectAdministration.Core.Interfaces;
using ProjectAdministration.Core.Mappers;
using ProjectAdministration.Core.Models;
using ProjectAdministration.Service.ProjectServices;
using Xunit;

namespace ProjectAdministration.Test.ProjectTest
{
    public class ProjectTest
    {
        private readonly Mock<IAsyncRepository<Project>> _projectRepositoryMock = new Mock<IAsyncRepository<Project>>();
        private readonly IProjectService _projectService;
        private readonly TestDataProvider _testDataProvider;

        public ProjectTest()
        {
            _projectService = new ProjectService(_projectRepositoryMock.Object);
            _testDataProvider = new TestDataProvider();
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ProjectMapper>();
            });
        }
        [Fact]
        public async Task CanCreateProject()
        {
            var projectViewModel = _testDataProvider.ProjectViewModel;
            _projectRepositoryMock.Setup(f => f.AddAsync(It.IsAny<Project>())).Returns(Task.FromResult(new Project(){ProjectId = 1}));
            var idProject = await _projectService.CreateProject(projectViewModel);
            Assert.False(idProject == 0);
        }
    }
}
