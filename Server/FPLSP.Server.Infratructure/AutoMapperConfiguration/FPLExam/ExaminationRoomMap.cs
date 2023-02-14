using AutoMapper;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration.FPLExam
{
    public class ExaminationRoomMap : Profile
    {
        public ExaminationRoomMap()
        {
            CreateMap<ExaminationRoomDetail, ExaminationRoomDetailViewModel>().ReverseMap();

        }
    }
}
