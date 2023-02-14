using AutoMapper;
using FPLSP.Server.Domain.Dtos.QuestionType;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.QuestionType;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration
{
    public class QuestionTypeMap : Profile
    {
        public QuestionTypeMap()
        {
            CreateMap<QuestionType, QuestionTypeDto>().ReverseMap();
            CreateMap<QuestionType, QuestionTypeVm>().ReverseMap();
        }
    }
}
