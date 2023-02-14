using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.SubmitHomeWorkVM;

namespace FPLSP.Repositories.Interfaces
{
    public interface ISubmitHomeworkForStudentRepo
    {
        Task<bool> Student_Update(Guid Id, SubmitHomeWorkForStudentUpdateVm summitUpdate);
        Task<List<SubmitHomeWork>> Student_GetAllAsync();
        Task<bool> AddMultipleDeadLine(ListHomeWorkForStudent listHomeWorkForStudent);
        Task<SubmitHomeWork> Student_GetSubmitByIdAsync(Guid id);
    }
}
