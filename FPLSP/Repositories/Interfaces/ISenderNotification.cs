using FPLSP.Server.Infrastructure.ViewModels.NewFeed;

namespace FPLSP.Repositories.Interfaces
{
    public interface ISenderNotification
    {

        Task<bool> SendAsync(NewFeedVM newFeedVM);
    }
}
