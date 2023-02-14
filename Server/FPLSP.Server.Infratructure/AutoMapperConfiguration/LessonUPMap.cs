using AutoMapper;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.LessonUP;

namespace FPLSP.Server.Infratructure.AutoMapperConfiguration;

public class LessonUPMap : Profile // phải kế thừa Profile của Automaper Khi tạo mới
{
    public LessonUPMap() // Tạo Constructor cho Class và Create map tại Đây
    {
        CreateMap<LessonUP, LessonUPViewModel>().ReverseMap(); // ReverseMap() dùng để máp ngược lại từ LessonUPViewModel => LessonUP ||| 
    }
}
