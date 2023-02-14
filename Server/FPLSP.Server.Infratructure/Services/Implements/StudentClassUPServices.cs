using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.StudentClassUPVm;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class StudentClassUPServices : IStudentClassUPServices
    {
        private readonly IRepository<StudentClassUP> _repository;
        private readonly IRepository<StudentUP> _Studentrepository;
         
        public StudentClassUPServices(IRepository<StudentClassUP> repository, IRepository<StudentUP> studentrepository)
        {
            _repository = repository;
            _Studentrepository = studentrepository;
        }

        public async Task<StudentUP> CreateStudentbyEmail(StudentUP StudentUP)
        {
            try
            {
                await _Studentrepository.AddAsync(StudentUP);
                await _Studentrepository.SaveChangesAsync();
                return StudentUP;
            }
            catch (Exception)
            {
                return StudentUP;
            }
        }

        public async Task<StudentClassUP> CreateStudentClassUP(StudentClassUP imageCP)
        {
            try
            {
                if (_repository.AsQueryable().Any(c => c.StudentId == imageCP.StudentId && c.ClassId == imageCP.ClassId && c.JoinCodeAsign == imageCP.JoinCodeAsign))
                {
                    return imageCP;
                }
                await _repository.AddAsync(imageCP);
                await _repository.SaveChangesAsync();
                return imageCP;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<StudentClassUP> DeleteStudentClassUP(string jocode, Guid idStudent)
        {
            try
            {
                var delete = _repository.AsQueryable().FirstOrDefault(c => Guid.Equals(idStudent, c.StudentId) && Guid.Equals(jocode, c.JoinCodeAsign));
                if (delete == null) return null;
                await _repository.RemoveAsync(delete);
                await _repository.SaveChangesAsync();
                return delete;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public async Task<List<StudentClassUP>> GetAllStudentUPAsync()
        {
            try
            {

                var result = _repository.AsQueryable().ToList();
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<StudentClassUP> GetStudentClassUPById(Guid id)
        {
            try
            {
                var query = await _repository.AsQueryable().FirstOrDefaultAsync(c => c.ClassId == id);

                return query;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<PageList<StudentClassUP>> GetStudentClassUPList(StudentClassUPSearch SearchVm)
        {
            try
            {
                var query = _repository.AsQueryable();


                var count = await query.CountAsync();
                var data = await query.Skip((SearchVm.PageNumber - 1) * SearchVm.PageSize).Take(SearchVm.PageSize).ToListAsync();
                return new PageList<StudentClassUP>(data, count, SearchVm.PageNumber, SearchVm.PageSize);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<PageList<StudentClassUP>> GetStudentClassUPListByClassId(Guid IdClass, StudentClassUPSearch SearchVm)
        {
            try
            {
                var query = _repository.AsQueryable().Where(c => c.ClassId == IdClass);

                var count = await query.CountAsync();
                var data = await query.Skip((SearchVm.PageNumber - 1) * SearchVm.PageSize).Take(SearchVm.PageSize).ToListAsync();
                return new PageList<StudentClassUP>(data, count, SearchVm.PageNumber, SearchVm.PageSize);
            }
            catch (Exception)
            {

                return null;
            }

        }

        public async Task<StudentClassUP> UpdateStudentClassUP(Guid idClass, Guid idStudent, StudentClassUPUpdateVm StudentClassUPUpdateVm)
        {

            try
            {
                var updateCP = _repository.AsQueryable().FirstOrDefault(c => Guid.Equals(idStudent, c.StudentId) && Guid.Equals(idClass, c.ClassId));
                updateCP = new StudentClassUP()
                {
                    ClassId = StudentClassUPUpdateVm.ClassId,
                    JoinCodeAsign = StudentClassUPUpdateVm.JoinCodeAsign,
                    Status = StudentClassUPUpdateVm.Status,
                    StudentId = StudentClassUPUpdateVm.StudentId,
                    StatusOfStudent = StudentClassUPUpdateVm.StatusOfStudent
                };
                await _repository.UpdateAsync(updateCP);
                await _repository.SaveChangesAsync();
                return updateCP;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
