using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.VideoHistoryVm;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class VideoHistoryServices : IVideoHistoryServices
    {
        private readonly IRepository<VideoHistory> _videoHistoryRepository;
        private readonly IRepository<LessonContentUP> _lessonCtrepository;
        private readonly IRepository<ResourceLinkUP> _linkrepository;
        private readonly IRepository<StudentUP> _studentrep;
        private readonly IMapper _mapper;

        public VideoHistoryServices(IRepository<VideoHistory> videoHistoryRepository, IRepository<LessonContentUP> lessonCtrepository, IRepository<ResourceLinkUP> linkrepository, IRepository<StudentUP> studentrep, IMapper mapper)
        {
            _videoHistoryRepository = videoHistoryRepository;
            _lessonCtrepository = lessonCtrepository;
            _linkrepository = linkrepository;
            _studentrep = studentrep;
            _mapper = mapper;
        }


        //Tìm kiếm đối tượng dựa vào ID
        public async Task<VideoHistoryViewModel> GetById(Guid IdStudent, Guid IdLessonContent)
        {
            var VideoHistory = _videoHistoryRepository.AsQueryable().ToList().Where(c => c.IsBookMarked == true && c.IdStudent == IdStudent && c.IdLessonContent == IdLessonContent);
            var lessonct = _lessonCtrepository.AsQueryable().ToList().Where(c => c.IsDeleted == false);
            var link = _linkrepository.AsQueryable().ToList();
            var resutls = (from vd in VideoHistory
                                 join ls in lessonct
                                 on vd.IdLessonContent equals ls.Id
                                 join lk in link
                                 on ls.ResuorceLinkId equals lk.Id
                                 select new VideoHistoryViewModel()
                                 {
                                     WatchedTime = vd.WatchedTime,
                                     IsBookMarked = vd.IsBookMarked,
                                     Status = vd.Status,
                                     Path = lk.Path,
                                     LessonContentCode = ls.LessonContentCode,
                                     LessonContentName = ls.LessonContentName
                                 }).ToList();

            var resutl = resutls.FirstOrDefault();
            return resutl;
        }

        //Tạo mới và trả về 1 đối tượng vừa tạo
        public async Task<bool> Create(VideoHistoryCreateRequest request)
        {
            var VideoHistory = new VideoHistory
            {
                IdStudent = request.IdStudent,
                IdLessonContent = request.IdLessonContent,
                TimeOfSaveHistory = DateTime.Now,
                WatchedTime = DateTime.MinValue,
                IsBookMarked = request.IsBookMarked,
                Status = request.Status
            };
            var resutl = _videoHistoryRepository.AddAsync(VideoHistory);
            await _videoHistoryRepository.SaveChangesAsync();
            return resutl.IsCompletedSuccessfully;
        }


        //Cập nhật và trả về số lượng bản ghi bị ảnh hưởng
        public async Task<int> Update(Guid IdStudent, Guid IdLessonContent, VideoHistoryUpdateRequest request)
        {
            var VideoHistory = _videoHistoryRepository.AsQueryable().ToList().FirstOrDefault(c => Guid.Equals(IdStudent, c.IdStudent) && Guid.Equals(IdLessonContent, c.IdLessonContent));

            if (VideoHistory != null)
            {
                VideoHistory.TimeOfSaveHistory = DateTime.Now;
                VideoHistory.WatchedTime = request.WatchedTime;
                VideoHistory.WatchedTime = request.WatchedTime;
                VideoHistory.IsBookMarked = request.IsBookMarked;
                VideoHistory.Status = request.Status;
                await _videoHistoryRepository.UpdateAsync(VideoHistory);
            }

            return await _videoHistoryRepository.SaveChangesAsync();
        }

        //Xóa và trả về số lượng bản ghi bị ảnh hưởng
        public async Task<int> Delete(Guid IdStudent, Guid IdLessonContent)
        {
            var VideoHistory = _videoHistoryRepository.AsQueryable().ToList().FirstOrDefault(c => Guid.Equals(IdStudent, c.IdStudent) && Guid.Equals(IdLessonContent, c.IdLessonContent));

            if (VideoHistory != null)
            {
                await _videoHistoryRepository.RemoveAsync(VideoHistory);
            }

            return await _videoHistoryRepository.SaveChangesAsync();
        }

        //Lấy toàn bộ danh sách
        public Task<IQueryable<VideoHistoryViewModel>> GetAll()
        {
            var VideoHistorys = _videoHistoryRepository.AsQueryable().ProjectTo<VideoHistoryViewModel>(_mapper.ConfigurationProvider);
            return Task.FromResult(VideoHistorys);
        }

        public async Task<PageList<VideoHistoryDto>> ListGetVideo(Guid IdStudent, Guid IdLesson, VideoHistoryListSearch search)
        {
            var video = _videoHistoryRepository.AsQueryable().ToList().Where(c => c.IsBookMarked == true).OrderByDescending(c => c.TimeOfSaveHistory);
            var lesssonct = _lessonCtrepository.AsQueryable().ToList().Where(c => c.LessonId == IdLesson);
            var linkall = _linkrepository.AsQueryable().ToList();
            var resutl = from vd in video
                         join ls in lesssonct
                         on vd.IdLessonContent equals ls.Id
                         join lk in linkall on ls.ResuorceLinkId equals lk.Id
                         where vd.IsBookMarked == true && vd.IdLessonContent == ls.Id && vd.IdStudent == IdStudent
                         select new VideoHistoryDto()
                         {
                             IdStuden = vd.IdStudent,
                             Path = lk.Path,
                             LessonContenCode = ls.LessonContentCode,
                             LessonContenName = ls.LessonContentName,
                             TimeOfSaveHistory = vd.TimeOfSaveHistory,
                             IdLessonConten = vd.IdLessonContent

                         };
            if (search.LessonContentName != null)
                resutl = resutl.Where(x => x.LessonContenName.ToUpper() == search.LessonContentName.ToUpper() || x.LessonContenCode.ToUpper().Contains(search.LessonContentName.ToUpper()));
            var count = resutl.Count();

            var data = resutl
                .Skip((search.PageNumber - 1) * search.PageSize)
                .Take(search.PageSize)
                .ToList();

            var temp = new PageList<VideoHistoryDto>(data, count, search.PageNumber, search.PageSize);

            return temp;
        }

        public async Task<bool> UpdateListVideo(List<VideoHistoryDto> listvideo)
        {
            List<VideoHistory> videohistory = new List<VideoHistory>();
            foreach (var item in listvideo)
            {
                videohistory.AddRange(_videoHistoryRepository.AsQueryable().ToList().Where(c => c.IdStudent == item.IdStuden && c.IdLessonContent == item.IdLessonConten));
                videohistory.All(c => c.IsBookMarked = false);
            }
            var result = _videoHistoryRepository.UpdateRangeAsync(videohistory);
            await _videoHistoryRepository.SaveChangesAsync();
            return result.IsCompletedSuccessfully;
        }
    }
}
