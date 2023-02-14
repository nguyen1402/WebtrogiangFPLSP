using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.LessonUP;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class LessonUPServices : ILessonUPServices
    {
        private readonly IRepository<LessonUP> _lessonUPRepository;
        private readonly IRepository<LessonContentCP> _LessonContentCPRepository;
        private readonly IRepository<LessonCP> _LessonCPRepository;
        private readonly IRepository<ResourceLink> _ResourceLinkCPRepository;
        private readonly IMapper _mapper;

        public LessonUPServices(IRepository<LessonUP> lessonUPRepository, IRepository<LessonContentCP> lessonContentCPRepository, IRepository<LessonCP> lessonCPRepository, IRepository<ResourceLink> resourceLinkCPRepository, IMapper mapper)
        {
            _lessonUPRepository = lessonUPRepository;
            _LessonContentCPRepository = lessonContentCPRepository;
            _LessonCPRepository = lessonCPRepository;
            _ResourceLinkCPRepository = resourceLinkCPRepository;
            _mapper = mapper;
        }





        //Tạo mới và trả về 1 đối tượng vừa tạo
        public async Task<LessonUPViewModel> Create(LessonUPCreateRequest request)
        {
            var LessonUP = new LessonUP
            {
                Id = request.Id,
                LessonName = request.LessonName,
                LessonCode = request.LessonCode,
                Descriptions = request.Descriptions,
                IsCompleted = request.IsCompleted,
                Status = request.Status,
                SubjectId = request.SubjectId
            };
            await _lessonUPRepository.AddAsync(LessonUP);
            await _lessonUPRepository.SaveChangesAsync();
            return await GetById(LessonUP.Id);
        }

        //Xóa và trả về số lượng bản ghi bị ảnh hưởng
        public async Task<int> Delete(Guid id)
        {
            var LessonUP = _lessonUPRepository.AsQueryable().FirstOrDefault(c => Guid.Equals(id, c.Id));

            if (LessonUP != null)
            {
                await _lessonUPRepository.RemoveAsync(LessonUP);
            }

            return await _lessonUPRepository.SaveChangesAsync();
        }

        //Lấy toàn bộ danh sách
        public Task<IQueryable<LessonUPViewModel>> GetAll()
        {
            var lessonUPs = _lessonUPRepository.AsQueryable().Where(x => x.IsDeleted == false).ProjectTo<LessonUPViewModel>(_mapper.ConfigurationProvider);
            return Task.FromResult(lessonUPs);
        }

        public async Task<IQueryable<LessonContentCP>> GetAllLessonContentCP()
        {
            var SubjectCP = _LessonContentCPRepository.AsQueryable();
            return SubjectCP;
        }
        public async Task<IQueryable<LessonCP>> GetAllLessonCP()
        {
            var LessonCP = _LessonCPRepository.AsQueryable();
            return LessonCP;
        }
        public async Task<IQueryable<ResourceLink>> GetAllResourceLinkCP()
        {
            var LessonCP = _ResourceLinkCPRepository.AsQueryable();
            return LessonCP;
        }

        //Tìm kiếm đối tượng dựa vào ID
        public async Task<LessonUPViewModel> GetById(Guid id)
        {
            var LessonUP = await _lessonUPRepository.AsQueryable().ProjectTo<LessonUPViewModel>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(c => Guid.Equals(id, c.Id));
            return await Task.FromResult(LessonUP);
        }

        //Lấy danh sách theo trang
        public async Task<PageList<LessonUPViewModel>> GetLessonUPs(LessonUPListSearch search)
        {
            var query = _lessonUPRepository.AsQueryable().Where(x => x.IsDeleted == false).ProjectTo<LessonUPViewModel>(_mapper.ConfigurationProvider);
            if (!string.IsNullOrEmpty(search.Name))
                query = query.Where(x => x.LessonName.ToLower().Contains(search.Name.ToLower()) || x.LessonCode.ToLower().Contains(search.Name.ToLower()));
            if (search.IsCompleted.HasValue)
                query = query.Where(x => x.IsCompleted == search.IsCompleted);
            if (search.Status != null)
                query = query.Where(x => x.Status == search.Status);
            if (search.SubjectId != null)
                query = query.Where(x => x.SubjectId == search.SubjectId);

            var count = query.Count();

            var data = await query.OrderBy(c=>c.LessonName)
                .Skip((search.PageNumber - 1) * search.PageSize)
                .Take(search.PageSize)
                .ToListAsync();

            return new PageList<LessonUPViewModel>(data, count
                    , search.PageNumber
                    , search.PageSize);
        }

        public async Task<bool> RemoveListLessonUP(List<Guid> listIdLesson)
        {
            try
            {
                List<LessonUP> lessonUP = new List<LessonUP>();
                foreach (var item in listIdLesson)
                {
                    lessonUP.AddRange(_lessonUPRepository.AsQueryable().Where(c => c.Id == item));
                }
                var result = _lessonUPRepository.RemoveRangeAsync(lessonUP);
                await _lessonUPRepository.SaveChangesAsync();
                return result.IsCompletedSuccessfully;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Cập nhật và trả về số lượng bản ghi bị ảnh hưởng
        public async Task<int> Update(Guid id, LessonUPUpdateRequest request)
        {
            var LessonUP = _lessonUPRepository.AsQueryable().FirstOrDefault(c => Guid.Equals(id, c.Id));

            if (LessonUP != null)
            {
                LessonUP.LessonName = request.LessonName;
                LessonUP.LessonCode = request.LessonCode;
                LessonUP.Descriptions = request.Descriptions;
                LessonUP.IsCompleted = request.IsCompleted;
                LessonUP.Status = request.Status;
                LessonUP.SubjectId = request.SubjectId;
                await _lessonUPRepository.UpdateAsync(LessonUP);
            }

            return await _lessonUPRepository.SaveChangesAsync();
        }
    }
}
