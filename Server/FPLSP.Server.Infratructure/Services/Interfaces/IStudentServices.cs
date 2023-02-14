using FPLSP.Server.Domain.Dtos;

namespace FPLSP.Server.Infrastructure.Services.Interfaces;

public interface IStudentServices
{
    Task<IQueryable<StudentDto>> GetStudentsAsync();   //
}