using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.BookMark;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookMarkClassesController : ControllerBase
    {
        private readonly IBookMarkClassService _iBookSer;
        public BookMarkClassesController(IBookMarkClassService iBookSer)
        {
            _iBookSer = iBookSer;
        }


        [HttpPost]
        public async Task<bool> AddToBookMark([FromBody] BookMarkClassVM bookMarkClass)
        {

            var results = await _iBookSer.AddToBookMark(bookMarkClass);

            return results;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<List<BookMarkClass>> GeListBookMark(Guid id)
        {
            var results = await _iBookSer.GetListBookMarkForUser(id);
            return results;
        }
        [HttpPut]

        public async Task<bool> UpdateBookMark(Guid IdBookMark, [FromBody] BookMarkClassVM bookMarkClass)
        {
            var results = await _iBookSer.AddToBookMark(bookMarkClass);
            return results;
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<bool> ĐeleteBookMark(Guid id)
        {
            var results = await _iBookSer.RemoveBookMark(id);
            return results;
        }
    }
}
