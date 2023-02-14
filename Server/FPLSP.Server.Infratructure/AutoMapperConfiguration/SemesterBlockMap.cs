using AutoMapper;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration
{
    public class SemesterBlockMap : Profile
    {
        public SemesterBlockMap()
        {
            CreateMap<SemesterBlock, SemesterBlockVM>().ReverseMap();
            CreateMap<SemesterBlock, SemesterBlockDto>().ReverseMap();
        }
    }
}
