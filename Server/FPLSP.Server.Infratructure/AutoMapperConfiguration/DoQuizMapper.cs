using AutoMapper;
using FPLSP.Server.Domain.Dtos.DoQuizDtos;
using FPLSP.Server.Domain.Entities.UsesParts;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration;

public class DoQuizMapper : Profile
{
    public DoQuizMapper()
    {
        CreateMap<AnswerDto, AnswerUP>().ReverseMap();
    }
}