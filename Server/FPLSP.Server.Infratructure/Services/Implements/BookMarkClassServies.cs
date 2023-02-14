using AutoMapper;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.BookMark;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class BookMarkClassServies : IBookMarkClassService
    {


        private readonly IRepository<BookMarkClass> _bookMarkIser;
        private readonly IMapper _mapper;
        public BookMarkClassServies(IRepository<BookMarkClass> bookMarkIser, IMapper mapper)
        {
            _bookMarkIser = bookMarkIser;
            _mapper = mapper;
        }
        public async Task<List<BookMarkClass>> GetListBookMarkForUser(Guid IdUser)
        {
            var query = _bookMarkIser.AsQueryable().ToList();

            return query;
        }
        public async Task<bool> AddToBookMark(BookMarkClassVM bookMarkClass)
        {
            if (bookMarkClass == null)
            {
                return false;
            }
            if (_bookMarkIser.AsQueryable().ToList().Any(c => c.IdClass == bookMarkClass.IdClass && c.IdSubject == bookMarkClass.IdSubject) == true)
            {
                foreach (var x in _bookMarkIser.AsQueryable().ToList().Where(c => c.IdClass == bookMarkClass.IdClass && c.IdSubject == bookMarkClass.IdSubject))
                {
                    x.IsBookMark = true;
                    await _bookMarkIser.UpdateAsync(x);
                    await _bookMarkIser.SaveChangesAsync();
                }
                return true;
            }

            var bookClass = _mapper.Map<BookMarkClass>(bookMarkClass);

            await _bookMarkIser.AddAsync(bookClass);
            await _bookMarkIser.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateBookMark(Guid IdBookMark, BookMarkClassVM bookMarkClass)
        {
            if (bookMarkClass == null)
            {
                return false;
            }
            var bookClass = _mapper.Map<BookMarkClass>(bookMarkClass);

            await _bookMarkIser.UpdateAsync(bookClass);
            await _bookMarkIser.SaveChangesAsync();
            return true;
        }
        public async Task<bool> RemoveBookMark(Guid IdBookMark)
        {
            if (IdBookMark == null)
            {
                return false;
            }

            foreach (var x in _bookMarkIser.AsQueryable().ToList().Where(c => c.Id == IdBookMark))
            {
                x.IsBookMark = false;
                await _bookMarkIser.RemoveAsync(x);
                await _bookMarkIser.SaveChangesAsync();
            }

            return true;
        }
    }
}
