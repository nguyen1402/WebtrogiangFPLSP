using AutoMapper;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.LessonContentUP;

namespace FPLSP.Server.Infratructure.AutoMapperConfiguration;

public class LessonContentUPMap : Profile // phải kế thừa Profile của Automaper Khi tạo mới
{
    public LessonContentUPMap() // Tạo Constructor cho Class và Create map tại Đây
    {
        CreateMap<LessonContentUP, LessonContentUPViewModel>().ReverseMap(); // ReverseMap() dùng để máp ngược lại từ LessonContentUPViewModel => LessonContentUP ||| 
    }
}
