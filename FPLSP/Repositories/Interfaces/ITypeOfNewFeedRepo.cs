using FPLSP.Server.Domain.Entities.UserParts;

namespace FPLSP.Repositories.Interfaces
{
    public interface ITypeOfNewFeedRepo
    {
        Task<List<TypeOfNewFeed>> GetNewFeedsAsync();
    }
}
