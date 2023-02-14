using AutoMapper;
using FPLSP.Server.Domain.Dtos.QuizQuestionUPDto;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuestionUp;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration
{
    public class QuizQuestionUPMap : Profile
    {
        public QuizQuestionUPMap()
        {
            CreateMap<QuizQuestionUP, QuizQuestionUpDto>().ReverseMap();
            CreateMap<QuizQuestionUP, QuizQuestionUpVm>().ReverseMap();
        }
    }
}
