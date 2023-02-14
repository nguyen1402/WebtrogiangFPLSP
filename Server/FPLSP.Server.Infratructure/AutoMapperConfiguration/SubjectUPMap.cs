using AutoMapper;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.Subject;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration
{
    public class SubjectUPMap : Profile
    {
        public SubjectUPMap()
        {
            CreateMap<SubjectUP, SubjectDto>().ReverseMap();
            CreateMap<SubjectUP, SubjectCreateVM>().ReverseMap();
            CreateMap<SubjectUP, SubjectUpdateVM>().ReverseMap();
        }
    }
}
