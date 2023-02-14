using AutoMapper;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.QuizUp.ViewModels;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration
{
    public class QuizUpMap : Profile
    {
        public QuizUpMap()
        {
            CreateMap<QuizUP, QuizUpDto>().ReverseMap();
            CreateMap<QuizUP, QuizUpVm>().ReverseMap();
        }
    }
}
