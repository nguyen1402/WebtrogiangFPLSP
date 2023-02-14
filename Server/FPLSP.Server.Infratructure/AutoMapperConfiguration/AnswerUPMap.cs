using AutoMapper;
using FPLSP.Server.Domain.Dtos.AnswerUPDtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.AnswerUp;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration
{
    public class AnswerUPMap : Profile
    {
        public AnswerUPMap()
        {
            CreateMap<AnswerUP, AnswerUPDto>().ReverseMap();
            CreateMap<AnswerUP, AnswerUpVm>().ReverseMap();
        }
    }
}
