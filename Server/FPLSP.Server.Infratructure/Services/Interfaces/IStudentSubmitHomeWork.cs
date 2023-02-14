using FPLSP.Server.Infrastructure.ViewModels.SubmitHomeWorkVM;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IStudentSubmitHomeWork
    {

        Task<bool> AddHomeWorkForClass(ListHomeWorkForStudent listHomeWorkForStudent);

    }
}
