using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.ResourceLinkUP;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class ResourceLinkUPServices : IResourceLinkUPServices
    {
        private readonly IRepository<ResourceLinkUP> _resourceLinkRepository;
        private readonly IMapper _mapper;

        public ResourceLinkUPServices(IRepository<ResourceLinkUP> resourceLinkRepository, IMapper mapper)
        {
            _resourceLinkRepository = resourceLinkRepository ?? throw new ArgumentNullException(nameof(resourceLinkRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper)); ;
        }

        //Lấy danh sách theo trang
        public async Task<PageList<ResourceLinkUPDto>> GetResourceLinkUPs(ResourceLinkUPListSearch search)
        {
            var query = _resourceLinkRepository.AsQueryable().ProjectTo<ResourceLinkUPDto>(_mapper.ConfigurationProvider);
            if (!string.IsNullOrEmpty(search.Name))
                query = query.Where(x => x.Descriptions.ToUpper().Contains(search.Name.ToUpper()) || x.ResourcesTitle.ToUpper().Contains(search.Name.ToUpper()));
            if (search.Status != null)
                query = query.Where(x => x.Status == search.Status);

            var count = await query.CountAsync();

            var data = await query.OrderBy(x => x.ResourcesTitle)
                .Skip((search.PageNumber - 1) * search.PageSize)
                .Take(search.PageSize)
                .ToListAsync();

            var temp = new PageList<ResourceLinkUPDto>(data, count, search.PageNumber, search.PageSize);

            return temp;
        }

        //Tìm kiếm đối tượng dựa vào ID
        public async Task<ResourceLinkUPViewModel> GetById(Guid id)
        {
            var resourceLinkUP = await _resourceLinkRepository.AsQueryable().ProjectTo<ResourceLinkUPViewModel>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(c => Guid.Equals(id, c.Id));

            return await Task.FromResult(resourceLinkUP);
        }

        //Tạo mới và trả về 1 đối tượng vừa tạo
        public async Task<ResourceLinkUPViewModel> Create(ResourceLinkUPCreateRequest request)
        {
            var resourceLinkUP = new ResourceLinkUP
            {
                Id = request.Id,
                ResourcesTitle = request.ResourcesTitle,
                Path = request.Path,
                Descriptions = request.Descriptions,
                Status = request.Status
            };
            await _resourceLinkRepository.AddAsync(resourceLinkUP);
            await _resourceLinkRepository.SaveChangesAsync();
            return await GetById(resourceLinkUP.Id);
        }

        //Cập nhật và trả về số lượng bản ghi bị ảnh hưởng
        public async Task<int> Update(Guid id, ResourceLinkUPViewModel request)
        {
            var resourceLinkUP = _resourceLinkRepository.AsQueryable().FirstOrDefault(c => Guid.Equals(id, c.Id));

            if (resourceLinkUP != null)
            {
                resourceLinkUP.ResourcesTitle = request.ResourcesTitle;
                resourceLinkUP.Path = request.Path;
                resourceLinkUP.Descriptions = request.Descriptions;
                resourceLinkUP.Status = request.Status;
                await _resourceLinkRepository.UpdateAsync(resourceLinkUP);
            }

            return await _resourceLinkRepository.SaveChangesAsync();
        }

        //Xóa và trả về số lượng bản ghi bị ảnh hưởng
        public async Task<int> Delete(Guid id)
        {
            var resourceLinkUP = _resourceLinkRepository.AsQueryable().FirstOrDefault(c => Guid.Equals(id, c.Id));

            if (resourceLinkUP != null)
            {
                await _resourceLinkRepository.RemoveAsync(resourceLinkUP);
            }

            return await _resourceLinkRepository.SaveChangesAsync();
        }

        //Lấy toàn bộ danh sách
        public Task<IQueryable<ResourceLinkUPViewModel>> GetAll()
        {
            var resourceLinkUPs = _resourceLinkRepository.AsQueryable().ProjectTo<ResourceLinkUPViewModel>(_mapper.ConfigurationProvider);
            return Task.FromResult(resourceLinkUPs);
        }

        public async Task<bool> DeleteList(List<Guid> listIdLink, int method)
        {
            List<ResourceLinkUP> resourceLink = new List<ResourceLinkUP>();
            if (method == 0)
            {
                foreach (var item in listIdLink)
                {
                    resourceLink.AddRange(_resourceLinkRepository.AsQueryable().Where(c => c.Id == item));
                }
                var result = _resourceLinkRepository.RemoveRangeAsync(resourceLink);
                await _resourceLinkRepository.SaveChangesAsync();
                return result.IsCompletedSuccessfully;
            }
            else if (method == 1)
            {
                foreach (var item in listIdLink)
                {
                    var subject = _resourceLinkRepository.AsQueryable().FirstOrDefault(c => c.Id == item);
                    subject.Status = 2;
                    _resourceLinkRepository.UpdateAsync(subject);
                }
                await _resourceLinkRepository.SaveChangesAsync();
                return true;
            }
            return false;

        }
    }
}
