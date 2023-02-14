using AutoMapper;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.ReportClassUP;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration
{
    public class ReportUPMap : Profile
    {
        public ReportUPMap()
        {
            CreateMap<ReportClassUP, ReportUPViewModel>().ReverseMap();
            CreateMap<ReportClassUP, ReportUPDto>().ReverseMap();
        }
    }
}
