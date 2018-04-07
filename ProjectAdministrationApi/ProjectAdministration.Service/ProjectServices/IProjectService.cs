using System.Threading.Tasks;
using ProjectAdministration.Core.ViewModels;

namespace ProjectAdministration.Service.ProjectServices
{
    public interface IProjectService
    {
        Task<int> CreateProject(ProjectViewModel projectViewModel);
    }
}