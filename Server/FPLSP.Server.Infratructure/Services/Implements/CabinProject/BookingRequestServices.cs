using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;

using FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingRequest;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.GroupCabin;
using FPLSP.Server.Infratructure.AutoMapperConfiguration;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements.CabinProject
{
    public class BookingRequestServices : IBookingRequestServices
    {
        private readonly IRepository<BookingRequest> _Irepository;
        private readonly IMapper _mapper;

        public BookingRequestServices(IRepository<BookingRequest> Irepository, IMapper mapper)
        {
            _Irepository = Irepository;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<BookingRequestViewModel> CreateBookingRequest(BookingRequestCreateViewModel request)
        {
            try
            {
                int index = 0;
                var objCollection = _Irepository.AsQueryable().ToList();
                if (objCollection.Count > 0)
                {
                    index = objCollection.Max(c => c.IndexOfBookingRequest) + 1;
                }

                var obj = new BookingRequest
                {
                    Id = request.Id,
                    IndexOfBookingRequest = index,
                    ContentOfRequest = request.ContentOfRequest,
                    SendingTime = request.SendingTime,
                    IdLectuter = request.IdLectuter,
                    SubjectId = request.SubjectId,
                    ClassId = request.ClassId,
                    FeedBackTime = request.FeedBackTime,
                    Status = request.Status,
                    StartTime = request.StartTime,
                    ContenOfFeedBack = request.ContenOfFeedBack,
                    EndTime = request.EndTime
                };
                await _Irepository.AddAsync(obj);
                await _Irepository.SaveChangesAsync();
                return await GetBookingRequestListById(obj.Id);
            }
            catch
            {
                return null;
            }

        }

        public async Task<bool> DeleteBookingRequest(Guid Id)
        {
            try
            {
                var obj = await _Irepository.AsQueryable().FirstOrDefaultAsync(c => Equals(Id, c.Id));
                await _Irepository.RemoveAsync(obj);
                await _Irepository.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<BookingRequestViewModel>> GetAllBookingRequestAsync()
        {
            try
            {
                var objCollection = _Irepository.AsQueryable().ProjectTo<BookingRequestViewModel>(_mapper.ConfigurationProvider).ToList();
                return objCollection;
            }
            catch
            {
                return null;
            }
        }

        public async Task<BookingRequestViewModel> GetBookingRequestListById(Guid Id)
        {
            try
            {
                var obj = await _Irepository.AsQueryable().SingleOrDefaultAsync(c => c.Id == Id);
                var objModel = _mapper.Map<BookingRequestViewModel>(obj);
                return objModel;
            }
            catch
            {
                return null;
            }
        }

        public async Task<PageList<BookingRequestViewModel>> GetBookingRequestListSearch(BookingRequestSearchViewModel search)
        {
            try
            {
                var objCollection = _Irepository.AsQueryable().Where(x => x.Status != 1).ProjectTo<BookingRequestViewModel>(_mapper.ConfigurationProvider).ToList();

                var count = objCollection.Count();

                var data = objCollection.Skip((search.PageNumber - 1) * search.PageSize).Take(search.PageSize).ToList();
                var result = new PageList<BookingRequestViewModel>(data, count, search.PageNumber, search.PageSize);
                return result;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> RemoveListBookingRequest(List<Guid> listIdSpecCabin)
        {
            try
            {
                List<BookingRequest> objCollection = new List<BookingRequest>();
                foreach (var item in listIdSpecCabin)
                {
                    objCollection.AddRange(_Irepository.AsQueryable().Where(c => c.Id == item));
                }
                var result = _Irepository.RemoveRangeAsync(objCollection);
                await _Irepository.SaveChangesAsync();
                return result.IsCompletedSuccessfully;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateBookingRequest(Guid Id, BookingRequestUpdateViewModel request)
        {
            try
            {
                var obj = await _Irepository.AsQueryable().FirstOrDefaultAsync(c => c.Id == Id);

                obj.IndexOfBookingRequest = request.IndexOfBookingRequest;
                obj.ContentOfRequest = request.ContentOfRequest;
                obj.SendingTime = request.SendingTime;
                obj.IdLectuter = request.IdLectuter;
                obj.SubjectId = request.SubjectId;
                obj.ClassId = request.ClassId;
                obj.Status = request.Status;
                obj.StartTime = request.StartTime;
                obj.FeedBackTime = request.FeedBackTime;
                obj.EndTime = request.EndTime;
                await _Irepository.UpdateAsync(obj);
                await _Irepository.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}