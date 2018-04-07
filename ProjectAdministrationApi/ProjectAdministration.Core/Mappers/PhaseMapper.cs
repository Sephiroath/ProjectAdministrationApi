using AutoMapper;
using ProjectAdministration.Core.Models;
using ProjectAdministration.Core.ViewModels;

namespace ProjectAdministration.Core.Mappers
{
    public class PhaseMapper : Profile
    {
        public PhaseMapper()
        {
            CreateMap<Phase, PhaseViewModel>().ReverseMap();
        }
    }
}