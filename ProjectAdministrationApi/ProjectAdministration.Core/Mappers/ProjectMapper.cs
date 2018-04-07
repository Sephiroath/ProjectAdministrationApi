using AutoMapper;
using ProjectAdministration.Core.Models;
using ProjectAdministration.Core.ViewModels;

namespace ProjectAdministration.Core.Mappers
{
    public class ProjectMapper : Profile
    {
        public ProjectMapper()
        {
            CreateMap<Project, ProjectViewModel>()
                .ForMember(d => d.PhaseViewModel, o => o.MapFrom(c => c.PhaseNavigation))
                .ForMember(d => d.StatusViewModel, o => o.MapFrom(c => c.StatusNavigation))
                .ForMember(d => d.PriorityViewModel, o => o.MapFrom(c => c.PriorityNavigation));
            CreateMap<ProjectViewModel, Project>();
        }
    }
}