using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingCabin;

namespace FPLSP.Server.Infrastructure.Services.Implements.CabinProject
{
    public class BookingCabinServices : IBookingCabinServices
    {
        private IRepository<BookingCabin> _bookingcabinrep;

        public BookingCabinServices(IRepository<BookingCabin> bookingcabinrep)
        {
            _bookingcabinrep = bookingcabinrep ?? throw new ArgumentNullException(nameof(bookingcabinrep));
        }
        /// <summary>
        /// Thêm mới phòng với thông tin của đối tượng được truyền vào
        /// </summary>
        /// <param name="bookingCabinVM">Thông tin của đối tượng được thêm mới</param>
        /// <returns>Trả về true nếu thêm thành công, trả về false nếu thêm mới không thành công</returns>
        public async Task<bool> Add(BookingCabinCreateVM bookingCabinVM)
        {
            try
            {
                int index = 0;
                var cabins = _bookingcabinrep.AsQueryable().ToList();
                if (cabins.Count > 0)
                {
                    index = cabins.Max(c => c.IndexOfBookingCabin) + 1;
                }
                var cabin = new BookingCabin
                {
                    Id = bookingCabinVM.Id,
                    SubjectId = bookingCabinVM.SubjectId,
                    ClassId = bookingCabinVM.ClassId,
                    IdCabin = bookingCabinVM.IdCabin,
                    IdShift = bookingCabinVM.IdShift,
                    CheckinImage = bookingCabinVM.CheckinImage,
                    CheckinTime = bookingCabinVM.CheckinTime,
                    CheckoutTime = bookingCabinVM.CheckoutTime,
                    DateCreated = bookingCabinVM.DateCreated,
                    IndexOfBookingCabin = index,
                    Note = bookingCabinVM.Note,
                    Status = bookingCabinVM.Status,
                    IdLectuter = bookingCabinVM.IdLectuter
                };

                await _bookingcabinrep.AddAsync(cabin);
                await _bookingcabinrep.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// Xóa phòng theo id bằng với id được truyền vào
        /// </summary>
        /// <param name="IdCabin">id cabin</param>
        /// <param name="SubjectId">id môn học</param>
        /// <param name="ClassId">id lớp học</param>
        /// <param name="IdShift">id ca học</param>
        /// <returns>Trả về true nếu xóa thành công, trả về false nếu xóa không thành công</returns>
        public async Task<bool> Delete(Guid Id, Guid IdCabin, Guid SubjectId, Guid ClassId, Guid IdShift)
        {
            try
            {
                var bookingCabins = _bookingcabinrep.AsQueryable().FirstOrDefault(c => c.Id == Id && c.Status != 1 && c.IdCabin == IdCabin && c.SubjectId == SubjectId && c.ClassId == ClassId && c.IdShift == IdShift);
                bookingCabins.Status = 1;//Đổi trạng thái thành đã xóa

                var result = _bookingcabinrep.UpdateAsync(bookingCabins);
                await _bookingcabinrep.SaveChangesAsync();
                return result.IsCompletedSuccessfully;
            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// Lấy tất cả phòng
        /// </summary>
        /// <returns>Trả về danh sách tất cả các phòng</returns>
        public async Task<List<BookingCabinVM>> GetAll()
        {
            var bookingCabins = _bookingcabinrep.AsQueryable().ToList();
            var result = bookingCabins.Select(c => new BookingCabinVM
            {
                Id = c.Id,
                SubjectId = c.SubjectId,
                ClassId = c.ClassId,
                IdCabin = c.IdCabin,
                IdShift = c.IdShift,
                CheckinImage = c.CheckinImage,
                DateCreated = c.DateCreated,
                CheckinTime = c.CheckinTime,
                CheckoutTime = c.CheckoutTime,
                IndexOfBookingCabin = c.IndexOfBookingCabin,
                Note = c.Note,
                Status = c.Status,
                IdLectuter = c.IdLectuter
            }).ToList();

            return result;
        }
        /// <summary>
        /// Lấy phòng theo id bằng với id được truyền vào 
        /// </summary>
        /// <param name="IdCabin">id cabin</param>
        /// <param name="SubjectId">id môn học</param>
        /// <param name="ClassId">id lớp học</param>
        /// <param name="IdShift">id ca học</param>
        /// <returns>Trả vê phòng theo id được chuyền vào</returns>
        public async Task<BookingCabinVM> GetById(Guid Id, Guid IdCabin, Guid SubjectId, Guid ClassId, Guid IdShift)
        {
            var bookingCabins = _bookingcabinrep.AsQueryable().FirstOrDefault(c => c.Id == Id && c.Status != 1 && c.IdCabin == IdCabin && c.SubjectId == SubjectId && c.ClassId == ClassId && c.IdShift == IdShift);
            var result = new BookingCabinVM
            {
                Id = bookingCabins.Id,
                SubjectId = bookingCabins.SubjectId,
                ClassId = bookingCabins.ClassId,
                IdCabin = bookingCabins.IdCabin,
                IdShift = bookingCabins.IdShift,
                CheckinImage = bookingCabins.CheckinImage,
                DateCreated = bookingCabins.DateCreated,
                CheckinTime = bookingCabins.CheckinTime,
                CheckoutTime = bookingCabins.CheckoutTime,
                IndexOfBookingCabin = bookingCabins.IndexOfBookingCabin,
                Note = bookingCabins.Note,
                Status = bookingCabins.Status,
                IdLectuter = bookingCabins.IdLectuter
            };

            return result;
        }
        /// <summary>
        /// Lấy danh sách theo keyword search
        /// </summary>
        /// <param name="search">keyword để search</param>
        /// <returns>Trả về danh sách đặt phòng theo keyword</returns>
        public async Task<PageList<BookingCabinVM>> GetForSearch(BookingCabinSearch search)
        {
            var bookingCabins = _bookingcabinrep.AsQueryable().Where(c => c.Status != 1).ToList();
            var result = bookingCabins.Select(c => new BookingCabinVM
            {
                Id = c.Id,
                SubjectId = c.SubjectId,
                ClassId = c.ClassId,
                IdCabin = c.IdCabin,
                IdShift = c.IdShift,
                CheckinImage = c.CheckinImage,
                CheckinTime = c.CheckinTime,
                DateCreated = c.DateCreated,
                CheckoutTime = c.CheckoutTime,
                IndexOfBookingCabin = c.IndexOfBookingCabin,
                Note = c.Note,
                Status = c.Status,
                IdLectuter = c.IdLectuter
            }).ToList();

            if (!string.IsNullOrEmpty(search.Note))
            {
                result = result.Where(c => c.Note.Contains(search.Note)).ToList();
            }
            var count = result.Count();
            var data = result
                .Skip((search.PageNumber - 1) * search.PageSize)
                .Take(search.PageSize)
                .ToList();

            return new PageList<BookingCabinVM>(data, count
                , search.PageNumber
                , search.PageSize);
        }
        /// <summary>
        /// Xóa BookingCabin vừa được book
        /// </summary>
        /// <param name="Id">Id của BookingCabin</param>
        /// <returns>Trả về true nếu xóa thành công, false nếu thất bại<returns>
        public async Task<bool> UndoDelete(Guid Id)
        {
            try
            {
                var bookingCabins = _bookingcabinrep.AsQueryable().FirstOrDefault(c => c.Id == Id);
                if (bookingCabins == null)
                {
                    return false;
                }
                await _bookingcabinrep.RemoveAsync(bookingCabins);
                await _bookingcabinrep.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Cập nhật phòng có id bằng với id chuyền vào và theo thông tin đối tượng được truyền xuống
        /// </summary>
        /// <param name="IdCabin">id Cabin</param>
        /// <param name="SubjectId">id môn học</param>
        /// <param name="ClassId">id lớp học</param>
        /// <param name="IdShift">id ca học</param>
        /// <param name="bookingCabinVM">keyword search</param>
        /// <returns>trả về true nếu thành công, trả về false nếu không thành công</returns>
        public async Task<bool> Update(Guid Id, Guid IdCabin, Guid SubjectId, Guid ClassId, Guid IdShift, BookingCabinUpdateVM bookingCabinVM)
        {
            try
            {
                var bookingCabins = _bookingcabinrep.AsQueryable().FirstOrDefault(c => c.Id == Id && c.IdCabin == IdCabin && c.SubjectId == SubjectId && c.ClassId == ClassId && c.IdShift == IdShift);
                bookingCabins.SubjectId = bookingCabinVM.SubjectId;
                bookingCabins.ClassId = bookingCabinVM.ClassId;
                bookingCabins.IdCabin = bookingCabinVM.IdCabin;
                bookingCabins.IdShift = bookingCabinVM.IdShift;
                bookingCabins.CheckinImage = bookingCabinVM.CheckinImage;
                bookingCabins.CheckinTime = bookingCabinVM.CheckinTime;
                bookingCabins.CheckoutTime = bookingCabinVM.CheckoutTime;
                bookingCabins.DateCreated = bookingCabinVM.DateCreated;
                //bookingCabins.IndexOfBookingCabin = bookingCabinVM.IndexOfBookingCabin;
                bookingCabins.Note = bookingCabinVM.Note;
                bookingCabins.Status = bookingCabinVM.Status;
                bookingCabins.IdLectuter = bookingCabinVM.IdLectuter;

                await _bookingcabinrep.UpdateAsync(bookingCabins);

                await _bookingcabinrep.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
