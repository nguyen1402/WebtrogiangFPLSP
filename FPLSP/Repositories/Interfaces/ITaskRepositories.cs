using FPLSP.Data;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels;
using Microsoft.AspNetCore.Components.Forms;

namespace FPLSP.Repositories.Interfaces
{
    public interface ITaskRepositories<TEntity> where TEntity : class
    {

        Task<bool> AddAsync(CreateClassVM entity);
        Task<CreateClassVM> GetClassModel();
        Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);
        Task<bool> UpdateAsync(string Id, CreateClassVM entity);
        Task<CreateClassVM> GetClassById(string Id);
        Task<IEnumerable<TEntity>> UpdateRangeAsync(IEnumerable<TEntity> entities);
        Task<bool> RemoveAsync(string Id);
        Task<IEnumerable<TEntity>> RemoveRangeAsync(IEnumerable<TEntity> entities);
        Task<PageList<ClassUPViewModel>> GetListDataAsync(ClassSearchDTO classSearchDTO);
        Task<List<StudentViewModel>> LoadingBigData(IBrowserFile file);
        IQueryable<TEntity> AsQueryable();
        Task<List<StudentViewModel>> GetListST(string getfileName);
        Task<List<ExcelErrors>> GetListErr();
        Task<List<StudentViewModel>> GetAllStudent();
        Task<int> CountAsync();
        //tạo các phương thức lấy dữ liệu các bảng liên đới
        Task<List<SubjectUP>> GetAllSub();
        Task<List<SpecializedDto>> GetAllSpec();
        Task<List<ClassUPViewModel>> GetListClassDetailForLec(string emaillec);
        Task<List<LecturersCPViewModel>> GetAllLec();
        Task<List<ClassUPViewModel>> GetAllClass();
        Task<List<ClassUPViewModel>> GetAllClass(Guid idstudent);

        Task<List<ClassUp>> getOnlyClass();


    }
}
