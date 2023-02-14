using FPLSP.Server.Data.SeedWork;

using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IClassServices
    {

        //Các Phương Thức Ở Đây Sẽ Được Triển Khai Ở Services
        Task<PageList<ClassUPViewModel>> GetClassList(PagingParameters pagingParameters);
        Task<PageList<ClassUPViewModel>> GetListClassDetail(ClassSearchDTO classSearchDTO);
        Task<CreateClassVM> GetClassListById(string JoinCode);
        Task<PageList<ClassUp>> GetClassSeacrch(ClassSearchDTO classSearchDTO);
        Task<bool> CreateClass(CreateClassVM classUp);
        Task<bool> DeleteClass(string Id);
        Task<List<ClassUp>> getOnlyClass();
        Task<List<SubjectClassUP>> getSubjectClass();
        Task<bool> UpdateClass(string Id, CreateClassVM createClassVM);
        List<ClassUPViewModel> GetAllClassesAsync();
        Task<CreateClassVM> ClassCreater();
        Task<List<ClassUPViewModel>> GetListClassDetailForLec(string emaillec);
        Task<IQueryable<ClassUPViewModel>> GetClassMapper();
        Task<List<ClassUPViewModel>> GetAllClass(Guid idstudent);
    }
}
