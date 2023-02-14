using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.BookMark;

namespace FPLSP.Repositories.Interfaces
{
    public interface IBookMarkClassRepo
    {

        Task<List<BookMarkClass>> GetListBookMarkForUser(Guid IdUser);
        Task<bool> AddToBookMark(BookMarkClassVM bookMarkClass);
        Task<bool> UpdateBookMark(Guid IdBookMark, BookMarkClassVM bookMarkClass);
        Task<bool> RemoveBookMark(Guid IdBookMark);
    }
}
