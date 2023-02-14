using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.Services.Interfaces.Cabin
{
    public interface ISemesterServices
    {
        Task<IQueryable<SemesterDto>> GetAll();
        Task<SemesterVM> GetById(Guid Id);
        Task<bool> CreateSemester(SemesterVM semester);
        Task<bool> DeleteSemester(Guid Id);
        Task<bool> UpdateSemester(SemesterVM semester);
    }
}
