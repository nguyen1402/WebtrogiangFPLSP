using AutoMapper;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.VideoHistoryVm;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration
{
    public class VideoHistoryMap : Profile
    {
        public VideoHistoryMap()
        {
            CreateMap<VideoHistory, VideoHistoryViewModel>().ReverseMap();
        }
    }
}
