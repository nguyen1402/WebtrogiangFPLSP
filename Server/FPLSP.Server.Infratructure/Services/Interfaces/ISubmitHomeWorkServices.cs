using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.SubmitHomeWorkVM;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface ISubmitHomeWorkServices

    {
        Task<PageList<SubmitHomeWorkDtos>> ThongkeNopbai(ListSubmitHomeWorkSeach parameters, Guid idclass, Guid idlesson);
        Task<int> Add(SubmitHomeWorkCreateVM summit);

        Task<int> AddList(SubmitListHomeWorkCreateVM summit);

        Task<List<SubmitHomeWorkDtos>> GetAll();
        Task<int> DeleteSubmit(Guid idClass, Guid idSubject, Guid idStudent);
    }
}
