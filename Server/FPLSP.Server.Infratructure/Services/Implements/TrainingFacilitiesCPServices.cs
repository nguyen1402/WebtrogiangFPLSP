using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.TrainingFacilitiesCPVm;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements;

public class TrainingFacilitiesCPServices : ITrainingFacilitiesCPServices
{
    private readonly IRepository<TrainingFacilitiesCP> _Irepository;
    private readonly IMapper _mapper;

    public TrainingFacilitiesCPServices(IRepository<TrainingFacilitiesCP> trainingFacilityRepository, IMapper mapper)
    {
        _Irepository = trainingFacilityRepository;
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }


    /// <summary>
    /// Tạo Cơ sở đào tạo
    /// </summary>
    /// <param name="trainingFacilityCPViewModel"></param> Yêu cầu tạo TrainingFacilitiesCP
    /// <returns> Cơ sở đào tạo vừa tạo </returns>
    public async Task<TrainingFacilitiesCPViewModel> CreateTrainingFacility(TrainingFacilitiesCPRequest trainingFacilityCPRequest)
    {
        try
        {
            var trainingFacility = new TrainingFacilitiesCP
            {
                Id = Guid.NewGuid(),
                TrainingFacilitiesCode = trainingFacilityCPRequest.TrainingFacilitiesCode,
                TrainingInstitutionName = trainingFacilityCPRequest.TrainingInstitutionName,
                ImageUrl = trainingFacilityCPRequest.ImageUrl,
                TrainingInstitution = trainingFacilityCPRequest.TrainingInstitution,
                Status = trainingFacilityCPRequest.Status
            };
            await _Irepository.AddAsync(trainingFacility);
            await _Irepository.SaveChangesAsync();
            return await GetTrainingFacilityListById(trainingFacility.Id);
        }
        catch (Exception)
        {
            return null;
        }

    }

    /// <summary>
    /// Xóa Cơ sở đào tạo
    /// </summary>
    /// <param name="Id"></param> truyền vào Id cơ sở đào tạo
    /// <returns> True: xóa thành công, False: thất bại </returns>
    public async Task<bool> DeleteTrainingFacility(Guid Id)
    {
        try
        {
            var trainingFacilitiesCP = await _Irepository.AsQueryable().FirstOrDefaultAsync(c => c.Id == Id);
            if (trainingFacilitiesCP == null)
            {
                return false;
            }
            if (trainingFacilitiesCP.Status == 0)
            {
                trainingFacilitiesCP.Status = 1;
            }
            else
            {
                trainingFacilitiesCP.Status = 0;
            }
           
            await _Irepository.UpdateAsync(trainingFacilitiesCP);
            await _Irepository.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }

    }

    /// <summary>
    /// Lấy tất cả danh sách Cơ sở đào tạo
    /// </summary>
    /// <returns> Danh sách Cơ sở đào tạo </returns>
    public async Task<List<TrainingFacilitiesCP>> GetTrainingFacilitiesAsync()
    {
        try
        {
            var trainingFacilityCollection = _Irepository.AsQueryable().ToList();

            return trainingFacilityCollection;
        }
        catch (Exception)
        {
            return null;
        }
    }

    /// <summary>
    /// Lấy danh sách cơ sở đào tạo theo trang
    /// </summary>
    /// <param name="pagingParameters"></param> truyền vào PagingParameters
    /// <returns> Danh sách cơ sở đào tạo theo trang </returns> 
    public async Task<PageList<TrainingFacilitiesCPViewModel>> GetTrainingFacilityList(TrainingFacilitiesCPListSearch search)
    {
        try
        {
            var query = _Irepository.AsQueryable().ProjectTo<TrainingFacilitiesCPViewModel>(_mapper.ConfigurationProvider);

            if (!string.IsNullOrEmpty(search.Name))
                query = query.Where(x => x.TrainingFacilitiesCode.ToLower().Contains(search.Name.ToLower()) || x.TrainingInstitutionName.ToLower().Contains(search.Name.ToLower()));
            if (search.Status != null)
                query = query.Where(x => x.Status == search.Status);

            var count = await query.CountAsync();

            var data = await query.Skip((search.PageNumber - 1) * search.PageSize).Take(search.PageSize).ToListAsync();
            var result = new PageList<TrainingFacilitiesCPViewModel>(data, count, search.PageNumber, search.PageSize);
            return result;
        }
        catch (Exception)
        {
            return null;
        }
    }

    /// <summary>
    /// Tìm kiếm cơ sở đào tạo dựa vào ID
    /// </summary>
    /// <param name="Id"></param> Id của cơ sở đào tạo
    /// <returns> Cơ sở đào tạo có ID trùng khớp  </returns>
    public async Task<TrainingFacilitiesCPViewModel> GetTrainingFacilityListById(Guid Id)
    {
        try
        {
            var trainingFacilityCP = await _Irepository.AsQueryable().SingleOrDefaultAsync(c => c.Id == Id);
            var trainingFacilityModel = _mapper.Map<TrainingFacilitiesCPViewModel>(trainingFacilityCP);
            return trainingFacilityModel;
        }
        catch (Exception)
        {
            return null;
        }
    }

    /// <summary>
    /// Lấy danh sách TrainingFacilitiesCPViewModel
    /// </summary>
    /// <returns> danh sách TrainingFacilitiesCPViewModel </returns>
    public async Task<IQueryable<TrainingFacilitiesCPViewModel>> GetTrainingFacilityMapper()
    {
        try
        {
            var trainingFacilityCollection = _Irepository.AsQueryable().ProjectTo<TrainingFacilitiesCPViewModel>(_mapper.ConfigurationProvider);
            return trainingFacilityCollection;
        }
        catch (Exception)
        {
            return null;
        }
    }

    /// <summary>
    /// Lấy mã cơ sở đào tạo lớn nhất
    /// </summary>
    /// <returns> Mã cơ sở đào tạo lớn nhất </returns>
    private async Task<string> GetMaxCode()
    {
        try
        {
            var trainingFacilityCollection = await GetTrainingFacilitiesAsync();

            string result = "CS" + trainingFacilityCollection.Max(x => Convert.ToInt32(x.TrainingFacilitiesCode.Substring(2, x.TrainingFacilitiesCode.Length - 2))).ToString();

            return result;
        }
        catch (Exception)
        {
            return null;
        }
    }

    /// <summary>
    /// Lấy đối tượng có mã Cơ sở đào tạo lớn nhất
    /// </summary>
    /// <returns> Đối tượng có mã Cơ sở đào tạo lớn nhất </returns>
    public async Task<TrainingFacilitiesCP> GetTrainingFacilityMaxCode()
    {
        try
        {
            string maxCode = await GetMaxCode();
            var result = _Irepository.AsQueryable().FirstOrDefault(p => string.Equals(p.TrainingFacilitiesCode, maxCode));
            return result;
        }
        catch (Exception)
        {
            return null;
        }
    }

    /// <summary>
    /// Cập nhật TrainingFacilitiesCP
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="trainingFacilitiesCPRequest"></param> Yêu cầu cập nhật Cơ sở đào tạo
    /// <returns> True: xóa thành công, False: thất bại </returns>
    public async Task<bool> UpdateTrainingFacility(Guid Id, TrainingFacilitiesCPRequest trainingFacilitiesCPRequest)
    {
        try
        {
            var trainingFacilitydb = await _Irepository.AsQueryable().FirstOrDefaultAsync(c => Equals(Id, c.Id));
            if (trainingFacilitydb == null)
            {
                return false;
            }
            trainingFacilitydb.TrainingInstitutionName = trainingFacilitiesCPRequest.TrainingInstitutionName;
            trainingFacilitydb.TrainingInstitution = trainingFacilitiesCPRequest.TrainingInstitution;
            trainingFacilitydb.Status = trainingFacilitiesCPRequest.Status;
            trainingFacilitydb.ImageUrl = trainingFacilitiesCPRequest.ImageUrl;

            await _Irepository.UpdateAsync(trainingFacilitydb);
            await _Irepository.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }

    }

    public async Task<bool> RemoveListTF(List<Guid> listId)
    {
        try
        {
            List<TrainingFacilitiesCP> tfCP = new List<TrainingFacilitiesCP>();
            foreach (var item in listId)
            {
                tfCP.AddRange(_Irepository.AsQueryable().Where(c => c.Id == item));
            }
            foreach (var item in tfCP)
            {
                item.Status = 1;
            }
            var result = _Irepository.UpdateRangeAsync(tfCP);
            await _Irepository.SaveChangesAsync();
            return result.IsCompletedSuccessfully;
        }
        catch (Exception)
        {
            return false;
        }
    }
}