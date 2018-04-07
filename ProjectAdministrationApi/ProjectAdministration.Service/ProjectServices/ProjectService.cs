using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ProjectAdministration.Core.Interfaces;
using ProjectAdministration.Core.Models;
using ProjectAdministration.Core.ViewModels;

namespace ProjectAdministration.Service.ProjectServices
{
    public class ProjectService : IProjectService
    {
        private readonly IAsyncRepository<Project> _projectRepository;
        public ProjectService(IAsyncRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<int> CreateProject(ProjectViewModel projectViewModel)
        {
            var result = await _projectRepository.AddAsync(Mapper.Map<Project>(projectViewModel));
            return result.ProjectId;
        }

        public async Task<IEnumerable<ProjectViewModel>> GetProjectsAsync()
        {
            var result = await _projectRepository.ListAllAsync();
            return Mapper.Map<IEnumerable<ProjectViewModel>>(result);
        }

        public async Task<ProjectViewModel> GetProjectById(int projectId)
        {
            var result = await _projectRepository.GetByIdAsync(projectId);
            return Mapper.Map<ProjectViewModel>(result);
        }
    }
}