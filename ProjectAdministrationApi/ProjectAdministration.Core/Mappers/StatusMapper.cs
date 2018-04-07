using AutoMapper;
using ProjectAdministration.Core.Models;
using ProjectAdministration.Core.ViewModels;

namespace ProjectAdministration.Core.Mappers
{
    public class StatusMapper : Profile
    {
        public StatusMapper()
        {
            CreateMap<Priority, PriorityViewModel>().ReverseMap();
        }
    }
}