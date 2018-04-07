using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectAdministration.Core.Models;
using ProjectAdministration.Core.ViewModels;

namespace ProjectAdministration.Service.ProjectServices
{
    public interface IProjectService
    {
        Task<int> CreateProject(ProjectViewModel projectViewModel);
        Task<IEnumerable<ProjectViewModel>> GetProjectsAsync();
        Task<ProjectViewModel> GetProjectById(int projectId);
    }
}