using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.ImagesCP;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class ImageCPServices : IImageCPServices
    {
        private readonly IRepository<ImageCP> _repository;

        public ImageCPServices(IRepository<ImageCP> repository)
        {
            _repository = repository;
        }

        public async Task<ImageCP> CreateImageCP(ImageCP imageCP)
        {
            await _repository.AddAsync(imageCP);
            await _repository.SaveChangesAsync();
            return imageCP;
        }

        public async Task<ImageCP> DeleteImageCP(Guid id)
        {
            var delete = _repository.AsQueryable().FirstOrDefault(c => Guid.Equals(id, c.Id));
            await _repository.RemoveAsync(delete);
            await _repository.SaveChangesAsync();
            return delete;
        }

        public async Task<ImageCP> GetImageCPById(Guid id)
        {
            var query = await _repository.AsQueryable().FirstOrDefaultAsync(c => c.Id == id);

            return query;
        }

        public async Task<PageList<ImageCP>> GetImageCPList(ImageCPListSearchVm SearchVm)
        {
            var query = _repository.AsQueryable();
            if (SearchVm.Status != null)
            {
                query = query.Where(x => x.Status == Convert.ToInt32(SearchVm.Status));
            }
            if (SearchVm.Descriptions != null)
            {
                query = query.Where(x => x.Descriptions.ToLower().Contains(SearchVm.Descriptions.ToLower()) || x.Descriptions.ToLower().Contains(SearchVm.Descriptions.ToLower()));
            }
            if (SearchVm.Path != null)
            {
                query = query.Where(x => x.Path.ToLower().Contains(SearchVm.Path.ToLower()) || x.Path.ToLower().Contains(SearchVm.Path.ToLower()));
            }

            var count = await query.CountAsync();
            var data = await query.Skip((SearchVm.PageNumber - 1) * SearchVm.PageSize).Take(SearchVm.PageSize).ToListAsync();
            return new PageList<ImageCP>(data, count, SearchVm.PageNumber, SearchVm.PageSize);
        }

        public async Task<PageList<ImageCP>> GetImageCPListByCoeId(Guid Id, ImageCPListSearchVm SearchVm)
        {
            var query = _repository.AsQueryable().Where(c => c.Id == Id);

            var count = await query.CountAsync();
            var data = await query.Skip((SearchVm.PageNumber - 1) * SearchVm.PageSize).Take(SearchVm.PageSize).ToListAsync();
            return new PageList<ImageCP>(data, count, SearchVm.PageNumber, SearchVm.PageSize);

        }

        public async Task<ImageCP> UpdateImageCP(Guid id, ImageCPUpdateVm coeUpdateVm)
        {
            var updateCP = _repository.AsQueryable().FirstOrDefault(c => Guid.Equals(id, c.Id));
            updateCP = new ImageCP()
            {
                Id = id,
                Path = coeUpdateVm.Path,
                Descriptions = coeUpdateVm.Descriptions,
                CoeId = coeUpdateVm.CoeId,
                Status = coeUpdateVm.Status,
            };

            await _repository.UpdateAsync(updateCP);
            await _repository.SaveChangesAsync();
            return updateCP;
        }
    }
}
