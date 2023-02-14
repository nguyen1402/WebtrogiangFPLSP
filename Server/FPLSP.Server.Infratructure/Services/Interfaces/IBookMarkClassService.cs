using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.BookMark;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IBookMarkClassService
    {

        Task<List<BookMarkClass>> GetListBookMarkForUser(Guid IdUser);
        Task<bool> AddToBookMark(BookMarkClassVM bookMarkClass);
        Task<bool> UpdateBookMark(Guid IdBookMark, BookMarkClassVM bookMarkClass);
        Task<bool> RemoveBookMark(Guid IdBookMark);
    }
}
