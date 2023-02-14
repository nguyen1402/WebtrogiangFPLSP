using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.TeachingSchedule;

namespace FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject
{
    public interface ITeachingScheduleServices
    {
        Task<List<TeachingScheduleVM>> GetAll();
        Task<TeachingScheduleVM> GetById(Guid Id);
        Task<bool> Add(TeachingScheduleCreateVM teachingSchedule);
        Task<bool> Delete(Guid Id);
        Task<bool> Update(Guid Id, TeachingscheduleUpdateVM teachingSchedule);
        Task<PageList<TeachingScheduleVM>> GetForSearch(TeachingScheduleSearch search);
        Task<bool> AddTeachingSchedules(TeachingSchedule teachingSchedule);
        Task<bool> UpdateTeachingSchedules(TeachingSchedule teachingSchedule);
        Task<TeachingSchedule> GetTeachingScheduleById(Guid Id);
        Task<bool> DeteleTeachingSchedules(Guid Id);
    }
}
