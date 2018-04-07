using AutoMapper;
using ProjectAdministration.Core.Models;
using ProjectAdministration.Core.ViewModels;

namespace ProjectAdministration.Core.Mappers
{
    public class PriorityMapper : Profile
    {
        public PriorityMapper()
        {
            CreateMap<Priority, PriorityViewModel>().ReverseMap();
        }
    }
}