using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.LessonContentUP;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class LessonContentUPServices : ILessonContentUPServices
    {
        private readonly IRepository<LessonContentUP> _LessonContentUPRepository;
        private readonly IMapper _mapper;
        public LessonContentUPServices(IRepository<LessonContentUP> LessonContentUPRepository, IMapper mapper)
        {
            _LessonContentUPRepository = LessonContentUPRepository ?? throw new ArgumentNullException(nameof(LessonContentUPRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper)); ;
        }

        //Tạo mới và trả về 1 đối tượng vừa tạo
        public async Task<LessonContentUPViewModel> Create(LessonContentUPCreateRequest request)
        {
            var LessonContentUP = new LessonContentUP
            {
                Id = request.Id,
                Content = request.Content,
                Descriptions = request.Descriptions,
                LessonContentCode = request.LessonContentCode,
                LessonContentName = request.LessonContentName,
                Status = request.Status,
                LessonId = request.LessonId,
                ResuorceLinkId = request.ResuorceLinkId
            };
            var check = await _LessonContentUPRepository.AsQueryable().AnyAsync(c => String.Equals(LessonContentUP.LessonContentCode, c.LessonContentCode));
            await _LessonContentUPRepository.AddAsync(LessonContentUP);
            await _LessonContentUPRepository.SaveChangesAsync();
            return await GetById(LessonContentUP.Id);
        }

        //Xóa và trả về số lượng bản ghi bị ảnh hưởng
        public async Task<int> Delete(Guid id)
        {
            var LessonContentUP = _LessonContentUPRepository.AsQueryable().FirstOrDefault(c => Guid.Equals(id, c.Id));

            if (LessonContentUP != null)
            {
                await _LessonContentUPRepository.RemoveAsync(LessonContentUP);
            }

            return await _LessonContentUPRepository.SaveChangesAsync();
        }

        //Lấy toàn bộ danh sách
        public Task<IQueryable<LessonContentUPViewModel>> GetAll()
        {
            var lessonContentUPs = _LessonContentUPRepository.AsQueryable().Where(x => x.IsDeleted == false).ProjectTo<LessonContentUPViewModel>(_mapper.ConfigurationProvider);
            return Task.FromResult(lessonContentUPs);
        }

        //Tìm kiếm đối tượng dựa vào ID
        public async Task<LessonContentUPViewModel> GetById(Guid id)
        {
            var LessonContentUP = await _LessonContentUPRepository.AsQueryable().ProjectTo<LessonContentUPViewModel>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(c => Guid.Equals(id, c.Id));
            return await Task.FromResult(LessonContentUP);
        }

        //Lấy danh sách theo trang
        public async Task<PageList<LessonContentUPViewModel>> GetLessonContentUPs(LessonContentUPListSearch search)
        {
            var query = _LessonContentUPRepository.AsQueryable().Where(x => x.IsDeleted == false).ProjectTo<LessonContentUPViewModel>(_mapper.ConfigurationProvider);
            if (!string.IsNullOrEmpty(search.Name))
                query = query.Where(x => x.LessonContentName.ToLower().Contains(search.Name.ToLower()) || x.Descriptions.ToLower().Contains(search.Name.ToLower()) || x.LessonContentCode.ToLower().Contains(search.Name.ToLower()));
            if (search.Status != null)
                query = query.Where(x => x.Status == search.Status);
            if (search.LessonId != null)
                query = query.Where(x => x.LessonId == search.LessonId);
            if (search.ResuorceLinkId != null)
                query = query.Where(x => x.ResuorceLinkId == search.ResuorceLinkId);

            var count = await query.CountAsync();

            var data = await query.OrderBy(x => x.LessonContentName)
                .Skip((search.PageNumber - 1) * search.PageSize)
                .Take(search.PageSize)
                .ToListAsync();

            var temp = new PageList<LessonContentUPViewModel>(data, count, search.PageNumber, search.PageSize);

            return temp;
        }

        public async Task<bool> RemoveAll(List<Guid> lstLesson)
        {
            try
            {
                List<LessonContentUP> lessonUP = new List<LessonContentUP>();
                foreach (var item in lstLesson)
                {
                    lessonUP.AddRange(_LessonContentUPRepository.AsQueryable().Where(c => c.Id == item));
                }
                var result = _LessonContentUPRepository.RemoveRangeAsync(lessonUP);
                await _LessonContentUPRepository.SaveChangesAsync();
                return result.IsCompletedSuccessfully;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Cập nhật và trả về số lượng bản ghi bị ảnh hưởng
        public async Task<int> Update(Guid id, LessonContentUPUpdateRequest request)
        {
            var LessonContentUP = _LessonContentUPRepository.AsQueryable().FirstOrDefault(c => Guid.Equals(id, c.Id));

            if (LessonContentUP != null)
            {
                LessonContentUP.Content = request.Content;
                LessonContentUP.Descriptions = request.Descriptions;
                LessonContentUP.LessonContentCode = request.LessonContentCode;
                LessonContentUP.LessonContentName = request.LessonContentName;
                LessonContentUP.Status = request.Status;
                LessonContentUP.LessonId = request.LessonId;
                LessonContentUP.ResuorceLinkId = request.ResuorceLinkId;
                await _LessonContentUPRepository.UpdateAsync(LessonContentUP);
            }

            return await _LessonContentUPRepository.SaveChangesAsync();
        }
    }
}
