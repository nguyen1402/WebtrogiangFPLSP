using AutoMapper;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration.FPLExam
{
    public class ExamStorageMap : Profile
    {

        public ExamStorageMap()
        {

            CreateMap<ExamStorage, ExamStorageViewModel>().ReverseMap();
            CreateMap<List<ExamStorage>, List<ExamStorageViewModel>>().ReverseMap();
        }
    }
}
