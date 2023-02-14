using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.ViewModels.NewFeed;

namespace FPLSP.Repositories.Interfaces
{
    public interface INewFeedRepo
    {

        Task<List<NewFeedOverView>> GetListNewForUser(Guid IdUser);
        Task<PageList<NewFeedOverView>> GetListAllNewFeed(SearchNewFeed searchNewFeed);
        Task<bool> AddToNewFeed(NewFeedVM newFeedVM);
        Task<bool> RemoveNewFeed(Guid IdNewFeed);
        Task<List<NewFeedOverView>> GetListNewForClass(Guid? IdClass, Guid? IdSubject);
        Task<bool> UpdateNewFeed(Guid IdNewFeed, NewFeedVM newFeedVM);
    }
}
