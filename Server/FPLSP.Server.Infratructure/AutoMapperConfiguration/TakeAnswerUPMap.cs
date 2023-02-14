using AutoMapper;
using FPLSP.Server.Domain.Dtos.TakeAnswerDtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.TakeAnswerViewModel;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration;

public class TakeAnswerUPMap : Profile
{
    public TakeAnswerUPMap()
    {
        CreateMap<TakeAnswerUP, TakeAnswerUPDto>().ReverseMap();
        CreateMap<TakeAnswerUP, TakeAnswerWm>().ReverseMap();
    }
}