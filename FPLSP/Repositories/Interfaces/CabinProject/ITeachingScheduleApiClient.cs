using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.TeachingSchedule;
using Microsoft.AspNetCore.Components.Forms;
using TeachingSchedule = FPLSP.Server.Domain.Entities.CabinProject.TeachingSchedule;
namespace FPLSP.Repositories.Interfaces.CabinProject
{
    public interface ITeachingScheduleApiClient
    {
        Task<List<TeachingScheduleVM>> GetAll();
        Task<TeachingScheduleVM> GetById(Guid Id);
        Task<bool> Add(TeachingScheduleCreateVM teachingSchedule);
        Task<bool> Delete(Guid Id);
        Task<bool> Update(Guid Id, TeachingscheduleUpdateVM teachingSchedule);
        Task<PageList<TeachingScheduleVM>> GetForSearch(TeachingScheduleSearch search);
        Task<PageForTeachingSchedule<TeachingSchedule>> LoadingTeachingSchedule(IBrowserFile file, Guid Iduser, Guid Idtrain, Guid IdBlock, Guid IdSem, TeachinhScheduleSearch pagingParameterForSchedule);
        Task<List<TeachingSchedule>> GetListTeachingSchedule(string getfileName, Guid IdUser, Guid Idtrain, Guid IdBlock, Guid IdSem);
        Task<PageForTeachingSchedule<TeachingSchedule>> GetPagingData(TeachinhScheduleSearch pagingParameterForSchedule);
        Task<bool> AddRangeTeachingSchedules(List<TeachingSchedule> teachingSchedules);
        Task<List<TeachingSchedule>> GetFullListTeachingSchedules();
        Task<List<TeachingSchedule>> GetDefault();
        Task<PageForTeachingSchedule<TeachingSchedule>> AddNewTeachingSchedules(TeachingSchedule teachingSchedule);
        //
        Task<bool> AddTeachingSchedules(TeachingSchedule teachingSchedule);
        Task<bool> UpdateTeachingSchedules(TeachingSchedule teachingSchedule);
        Task<TeachingSchedule> GetTeachingScheduleById(Guid Id);
        Task<bool> DeteleTeachingSchedules(Guid Id);
        Task<List<TeachingSchedule>> GetListTeachingFormDatabase(Guid idblock, Guid idsem, Guid idtrain);
        Task<PageForTeachingSchedule<TeachingSchedule>> GetAllTeachingSchedules(Guid idblock, Guid idsem, Guid idtrain, TeachinhScheduleSearch pagingParameterForSchedule);
    }
}
