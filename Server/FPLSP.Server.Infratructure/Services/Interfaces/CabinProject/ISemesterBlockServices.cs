using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.QuizUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.Services.Interfaces.Cabin
{
    public interface ISemesterBlockServices
    {
        Task<IQueryable<SemesterBlockDto>> GetAll();
        Task<SemesterBlockVM> GetById(Guid IdBlock, Guid IdSemester);
        Task<bool> CreateSemesterBlock(SemesterBlockVM semester);
        Task<bool> DeleteSemesterBlock(Guid IdBlock,Guid IdSemester);
        Task<bool> UpdateSemesterBlock( SemesterBlockVM semester);
        Task<PageList<SemesterBlockDto>> GetPageList(SemesterBlockSearch semesterBlockSearch);
    }
}
