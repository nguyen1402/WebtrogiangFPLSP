using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.SubmitHomeWorkVM;

namespace FPLSP.Repositories.Interfaces
{
    public interface ISubmitHomeWorkApiClient
    {
        Task<PageList<SubmitHomeWorkDtos>> ThongkeNopbai(ListSubmitHomeWorkSeach parameters, Guid idclass, Guid idlesson);
        Task<List<SubmitHomeWorkDtos>> GetALl();
        Task<int> Add(SubmitHomeWorkCreateVM summit);

        Task<int> DeleteSubmit(Guid idClass, Guid idSubject, Guid idStudent);
    }
}
