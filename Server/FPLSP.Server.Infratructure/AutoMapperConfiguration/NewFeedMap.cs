using AutoMapper;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.NewFeed;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration
{
    public class NewFeedMap : Profile
    {
        public NewFeedMap()
        {

            CreateMap<News, NewFeedVM>().ReverseMap();

        }
    }
}
