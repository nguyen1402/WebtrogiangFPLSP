using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class SubmitHomeworkForStudentServices : ISubmitHomeworkForStudentServices
    {
        private readonly IRepository<SubmitHomeWork> _resSubmit;
        public SubmitHomeworkForStudentServices(IRepository<SubmitHomeWork> res)
        {
            _resSubmit = res;
        }

        public async Task<IQueryable<SubmitHomeWork>> Student_GetAllAsync()
        {
            return _resSubmit.AsQueryable();
        }

        public async Task<SubmitHomeWork> Student_GetSubmitByIdAsync(Guid id)
        {
            var submit = _resSubmit.AsQueryable().SingleOrDefault(c => c.Id == id);
            return submit;
        }

        public async Task<bool> Student_Update(Guid Id, SubmitHomeWorkForStudentUpdateVm summitUpdate)
        {
            var submit = _resSubmit.AsQueryable().FirstOrDefault(c => Equals(Id, c.Id));

            submit.SubmitTime = summitUpdate.SubmitTime;
            submit.SubmitLink = summitUpdate.SubmitLink;
            submit.Status = summitUpdate.Status;

            await _resSubmit.UpdateAsync(submit);
            await _resSubmit.SaveChangesAsync();
            return true;
        }
    }
}
