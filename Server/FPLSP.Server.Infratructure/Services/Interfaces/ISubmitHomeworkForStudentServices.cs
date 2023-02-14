using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface ISubmitHomeworkForStudentServices
    {
        Task<bool> Student_Update(Guid Id, SubmitHomeWorkForStudentUpdateVm summitUpdate);
        Task<IQueryable<SubmitHomeWork>> Student_GetAllAsync();
        Task<SubmitHomeWork> Student_GetSubmitByIdAsync(Guid id);
    }
}
