using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.SubmitHomeWorkVM;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class StudentSubmitHomeWork : IStudentSubmitHomeWork
    {
        private readonly IRepository<SubmitHomeWork> _Isubmit;
        private readonly IRepository<StudentClassUP> _StuInClass;

        public StudentSubmitHomeWork(IRepository<SubmitHomeWork> Isubmit, IRepository<StudentClassUP> StuInClass, IRepository<SubjectClassUP> subjectClass)
        {
            _Isubmit = Isubmit;
            _StuInClass = StuInClass;

        }
        public async Task<bool> AddHomeWorkForClass(ListHomeWorkForStudent listHomeWorkForStudent)
        {
            foreach (var classSub in listHomeWorkForStudent.setMultipleClasses.ToList().Distinct())
            {

                foreach (var x in _StuInClass.AsQueryable().ToList().Where(c => c.ClassId == classSub.IdClass && c.JoinCodeAsign == classSub.JoinCode).Distinct())
                {
                    SubmitHomeWork submitHomeWork = new SubmitHomeWork()
                    {
                        Id = Guid.NewGuid(),
                        Status = 0,
                        Titile = listHomeWorkForStudent.Titile,
                        StartedDate = listHomeWorkForStudent.setMultipleClasses.Where(c => c.IdClass == classSub.IdClass && c.IdSubject == classSub.IdSubject).Select(c => c.StartedDate).FirstOrDefault(),
                        EndTime = listHomeWorkForStudent.setMultipleClasses.Where(c => c.IdClass == classSub.IdClass && c.IdSubject == classSub.IdSubject).Select(c => c.EndTime).FirstOrDefault(),
                        IdClass = classSub.IdClass,
                        IdSubject = classSub.IdSubject,
                        SubmitLink = "",
                        IdLesson = listHomeWorkForStudent.setMultipleClasses.Where(c => c.IdClass == classSub.IdClass && c.IdSubject == classSub.IdSubject).Select(c => c.IdLesson).FirstOrDefault(),
                        IdStudent = Guid.Parse(x.StudentId.ToString()),

                    };
                    await _Isubmit.AddAsync(submitHomeWork);
                    await _Isubmit.SaveChangesAsync();
                }
            }
            return true;
        }


    }
}
