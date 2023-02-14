using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.StudentQuizUPVm;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class StudentQuizUPServices : IStudentQuizUPServices
    {
        private readonly IRepository<StudentUP> _resstudent;
        private readonly IRepository<QuizUP> _resquiz;
        private readonly IRepository<StudentQuizUP> _resstudentquiz;

        public StudentQuizUPServices(IRepository<StudentUP> resstudent, IRepository<QuizUP> resquiz, IRepository<StudentQuizUP> resstudentquiz)
        {
            _resstudent = resstudent;
            _resquiz = resquiz;
            _resstudentquiz = resstudentquiz;
        }

        //public StudentQuizUPServices(IRepository<StudentUP> resstudent
        //    , IRepository<QuizUP> resquiz
        //    , IRepository<StudentQuizUP> resstudentquiz)
        //{
        //    _resstudent = resstudent ?? throw new ArgumentNullException(nameof(_resstudent));
        //    _resquiz = resquiz ?? throw new ArgumentNullException(nameof(_resquiz));
        //    _resstudentquiz = resstudentquiz ?? throw new ArgumentNullException(nameof(_resstudentquiz));
        //}
        public async Task<int> Create(StudentQuizCreateUPVM create)
        {
            var tontai = _resstudentquiz.AsQueryable().Any(c => c.QuizId == create.QuizId && c.StudentId == create.StudentId);
            if (tontai) return 0;
            var lecspnew = new StudentQuizUP()
            {
                StudentId = create.StudentId,
                QuizId = create.QuizId,

                ScoreQuizOfStudent = create.ScoreQuizOfStudent,
                Status = create.Status,
                CounterTurn = create.CounterTurn,
            };
            try
            {
                await _resstudentquiz.AddAsync(lecspnew);
                await _resstudentquiz.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> Delete(Guid studenId, Guid quizId)
        {
            var result = _resstudentquiz.AsQueryable().FirstOrDefault(c => Equals(quizId, c.QuizId) && Equals(studenId, c.StudentId));
            if (result == null) return 0;
            try
            {
                await _resstudentquiz.RemoveAsync(result);
                await _resstudentquiz.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<List<StudentQuizUPDtos>> GetAllAsync()
        {
            try
            {
                var querry = from c in _resstudentquiz.AsQueryable().ToList()
                             join ct in _resquiz.AsQueryable().ToList() on c.QuizId equals ct.Id
                             join ct2 in _resstudent.AsQueryable().ToList() on c.StudentId equals ct2.Id
                             select new { c, ct, ct2 };

                var resuals = querry.Select(x => new StudentQuizUPDtos()
                {
                    StudentName = x.ct2.StudentName,
                    Gender = Convert.ToBoolean(x.ct2.Gender),
                    DateOfBirth = Convert.ToDateTime(x.ct2.DateOfBirth),
                    Email = x.ct2.Email,
                    StudentId = x.ct2.Id,
                    QuizId = x.ct.Id,
                    QuizName = x.ct.QuizName,
                    ScoreQuizOfStudent = x.c.ScoreQuizOfStudent,
                    Status = x.ct.Status,
                    CounterTurn = x.c.CounterTurn,
                }).ToList();
                return resuals;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<StudentQuizUPDtos> GetbyId(Guid studenId, Guid quizId)
        {
            try
            {
                var querry = from c in _resstudentquiz.AsQueryable()
                             join ct in _resquiz.AsQueryable() on c.QuizId equals ct.Id
                             join ct2 in _resstudent.AsQueryable() on c.StudentId equals ct2.Id
                             select new { c, ct, ct2 };

                var resuals = await querry.Select(x => new StudentQuizUPDtos()
                {
                    StudentName = x.ct2.StudentName,
                    Gender = Convert.ToBoolean(x.ct2.Gender),
                    DateOfBirth = Convert.ToDateTime(x.ct2.DateOfBirth),
                    Email = x.ct2.Email,
                    StudentId = x.ct2.Id,
                    QuizId = x.ct.Id,
                    QuizName = x.ct.QuizName,
                    ScoreQuizOfStudent = x.c.ScoreQuizOfStudent,
                    Status = x.ct.Status,
                    CounterTurn = x.c.CounterTurn,
                }).ToListAsync();
                var resual = resuals.FirstOrDefault(c => Equals(quizId, c.QuizId)
                && Equals(studenId, c.StudentId));

                return resual;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<int> Update(Guid studenId, Guid quizId, StudentQuizUpdateUPVM update)
        {
            var lecspnud = _resstudentquiz.AsQueryable().FirstOrDefault(c => Equals(studenId, c.StudentId)
            && Equals(quizId, c.QuizId));


            lecspnud.StudentId = update.StudentId;
            lecspnud.QuizId = update.QuizId;
            lecspnud.ScoreQuizOfStudent = update.ScoreQuizOfStudent;
            lecspnud.Status = update.Status;
            lecspnud.CounterTurn = update.CounterTurn;


            try
            {
                await _resstudentquiz.UpdateAsync(lecspnud);
                await _resstudentquiz.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
