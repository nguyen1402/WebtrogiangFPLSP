using AutoMapper;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration
{
    internal class SemesterMap : Profile
    {
        public SemesterMap()
        {
            CreateMap<Semester, SemesterDto>().ReverseMap();
            CreateMap<Semester, SemesterVM>().ReverseMap();
        }
    }
}
