using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class ClassSubjectServices : IClassSubjectServices
    {
        private readonly IRepository<ClassUp> _Irepository;
        private readonly IRepository<SubjectClassUP> _Irepsubclass;
        private readonly IRepository<SubjectUP> _Irepsub;
        private readonly IRepository<QuizUP> _Irepquiz;
        private readonly IRepository<StudentClassUP> _Irepstudentclass;
        private readonly IRepository<HomeWork> _IrephomeWork;
        private readonly IRepository<SubmitHomeWork> _IrepsubmitHomeWork;
        private readonly IRepository<BookMarkClass> _Irepbookmake;
        private readonly IRepository<News> _Irepnew;
        private Random random = new Random();
        public ClassSubjectServices(IRepository<ClassUp> Irepository
            , IRepository<SubjectClassUP> Irepsubclass
            , IRepository<SubjectUP> Irepsub
            , IRepository<QuizUP> irepquiz
            , IRepository<StudentClassUP> Irepstudentclass,
            IRepository<HomeWork> irephomeWork,
              IRepository<SubmitHomeWork> irepsubmitHomeWork,
              IRepository<News> irepnew,
              IRepository<BookMarkClass> irepbookmake)
        {
            _Irepository = Irepository ?? throw new ArgumentNullException(nameof(Irepsubclass));
            _Irepsubclass = Irepsubclass ?? throw new ArgumentNullException(nameof(Irepsubclass));
            _Irepsub = Irepsub ?? throw new ArgumentNullException(nameof(Irepsub));
            _Irepquiz = irepquiz ?? throw new ArgumentNullException(nameof(irepquiz));
            _Irepstudentclass = Irepstudentclass ?? throw new ArgumentNullException(nameof(Irepstudentclass));
            _IrephomeWork = irephomeWork ?? throw new ArgumentNullException(nameof(irephomeWork));
            _IrepsubmitHomeWork = irepsubmitHomeWork ?? throw new ArgumentNullException(nameof(irepsubmitHomeWork));
            _Irepnew = irepnew ?? throw new ArgumentNullException(nameof(irepsubmitHomeWork));
            _Irepbookmake = irepbookmake ?? throw new ArgumentNullException(nameof(irepsubmitHomeWork));
        }

        public async Task<List<SubjectClassUP>> GetAllSubjectClass()
        {
            var result = _Irepsubclass.AsQueryable().ToList();
            return result;
        }
        public async Task<int> Create(SubjectClassVM classUp)
        {
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < 5; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }

            var lstidClass = _Irepsubclass.AsQueryable().Where(c => c.SubjectId == classUp.SubjectId).Select(c => c.ClassId).ToList();
            var lstClass = _Irepository.AsQueryable().Where(c => lstidClass.Contains(c.Id)).ToList();
            if (lstClass.Any(c => c.ClassroomName == classUp.ClassroomName))
            {
                return 0;
            }
            //string codeString = "FPT0";
            //if (_Irepository.AsQueryable().Count() > 0)
            //{
            //    codeString = "FPT" + Convert.ToString(_Irepository.AsQueryable().Max(c => Convert.ToInt32(c.ClassroomCode.Substring(3, c.ClassroomCode.Length - 3)) + 1));
            //}
            var listclass = _Irepository.AsQueryable().ToList();

            if (!listclass.Any(c => c.Id == classUp.ClassId))
            {
                if (listclass.Any(c => c.ClassroomName == classUp.ClassroomName))
                {
                    return 0;
                }
                else
                {

                    var clsup = new ClassUp()
                    {
                        Id = classUp.ClassId,
                        ClassroomName = classUp.ClassroomName,
                        Building = classUp.Building,
                        Status = classUp.StatusClass,
                        //StudentAmount = classUp.StudentAmount,
                        //DateCreated = DateTime.Now,
                        //DateStarted = classUp.DateStarted,
                        //EndDate = classUp.EndDate,
                    };
                    try
                    {
                        await _Irepository.AddAsync(clsup);
                        await _Irepository.SaveChangesAsync();
                    }
                    catch
                    {
                        return 0;
                    }
                }
            }

            var clsupclass = new SubjectClassUP()
            {
                SubjectId = classUp.SubjectId,
                ClassId = classUp.ClassId,
                Status = classUp.StatusSubjectClass,
                JoinCode = str_build.ToString(),
                StudentAmount = classUp.StudentAmount,
                DateCreated = DateTime.Now,
                DateStarted = classUp.DateStarted,
                EndDate = classUp.EndDate,
                HomeroomLecturer = classUp.HomeroomLecturer,
                SpecializedOfClass = classUp.SpecializedOfClass,
            };
            try
            {
                await _Irepsubclass.AddAsync(clsupclass);
                await _Irepsubclass.SaveChangesAsync();
            }
            catch
            {
                return 0;
            }
            return 1;
        }

        public async Task<int> Delete(Guid idclass)
        {
            var c_lass = _Irepository.AsQueryable().FirstOrDefault(c => Guid.Equals(idclass, c.Id));
            var c_lasshomework = _IrephomeWork.AsQueryable().Where(c => Guid.Equals(idclass, c.IdClass)).ToList();
            var c_lasssubmithomework = _IrepsubmitHomeWork.AsQueryable().Where(c => Guid.Equals(idclass, c.IdClass)).ToList();
            var c_lasssubject = _Irepsubclass.AsQueryable().Where(c => Guid.Equals(idclass, c.ClassId)).ToList();
            var c_lassstudent = _Irepstudentclass.AsQueryable().Where(c => Guid.Equals(idclass, c.ClassId)).ToList();
            var c_lassnews = _Irepnew.AsQueryable().Where(c => Guid.Equals(idclass, c.IdClass)).ToList();
            var c_bookmake = _Irepbookmake.AsQueryable().Where(c => Guid.Equals(idclass, c.IdClass)).ToList();
            if (c_lasshomework.Count() > 0)
            {
                try
                {
                    await _IrephomeWork.RemoveRangeAsync(c_lasshomework);
                    await _IrephomeWork.SaveChangesAsync();
                }
                catch
                {
                    return 0;
                }
            }
            if (c_lasssubmithomework.Count() > 0)
            {
                try
                {
                    await _IrepsubmitHomeWork.RemoveRangeAsync(c_lasssubmithomework);
                    await _IrepsubmitHomeWork.SaveChangesAsync();
                }
                catch
                {
                    return 0;
                }
            }
            if (c_lassnews.Count() > 0)
            {
                try
                {
                    await _Irepnew.RemoveRangeAsync(c_lassnews);
                    await _Irepnew.SaveChangesAsync();
                }
                catch
                {
                    return 0;
                }
            }
            if (c_bookmake.Count() > 0)
            {
                try
                {
                    await _Irepbookmake.RemoveRangeAsync(c_bookmake);

                    await _Irepbookmake.SaveChangesAsync();
                }
                catch
                {
                    return 0;
                }
            }
            if (c_lasssubject.Count() > 0)
            {
                try
                {
                    await _Irepsubclass.RemoveRangeAsync(c_lasssubject);

                    await _Irepsubclass.SaveChangesAsync();
                }
                catch
                {
                    return 0;
                }
            }
            if (c_lassstudent.Count() > 0)
            {
                try
                {
                    await _Irepstudentclass.RemoveRangeAsync(c_lassstudent);
                    await _Irepstudentclass.SaveChangesAsync();
                }
                catch
                {
                    return 0;
                }
            }

            try
            {
                await _Irepository.RemoveAsync(c_lass);
                await _Irepository.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public Task<ClassSubjectUPDto> GetbyId(Guid specializedId, Guid lecturerid)
        {
            throw new NotImplementedException();
        }
        public Task<ClassUp> GetClassUPbyId(Guid idClass)
        {
            var classUP = _Irepository.AsQueryable().FirstOrDefaultAsync(c => c.Id == idClass);
            return classUP;
        }
        public async Task<ListIdQuiz> GetListIdQuiz(Guid subjectId)
        {
            var listIdQuiz = new ListIdQuiz();
            var _lstQuizIDInSubject = _Irepquiz.AsQueryable().Where(c => c.SubjectId == subjectId).Select(c => c.Id).ToList();

            try
            {
                foreach (var iteam in _lstQuizIDInSubject)
                {

                    listIdQuiz.idquiz.Add(iteam);
                }
                return listIdQuiz;
            }
            catch
            {
                throw new Exception();
            }
        }

        public async Task<List<ClassUp>> GetClassUPBySubjectID(Guid subjectId)
        {

            try
            {
                var lstClassUP = _Irepsubclass.AsQueryable().Where(c => c.SubjectId == subjectId).Select(c => c.ClassUp).ToList();
                return lstClassUP;
            }
            catch
            {
                throw new Exception();
            }
        }

        public async Task<PageList<ClassSubjectUPDto>> GetPagingParamets(Guid subjectId, Guid lecuId, Guid specializedId, SubjectServicesCPListSearch parameters)
        {
            if (subjectId == Guid.Empty && specializedId == Guid.Empty)
            {
                var querry = from c in _Irepository.AsQueryable()
                             join ct in _Irepsubclass.AsQueryable() on c.Id equals ct.ClassId
                             join ct2 in _Irepsub.AsQueryable() on ct.SubjectId equals ct2.Id
                             where ct.HomeroomLecturer == lecuId
                             select new { c, ct, ct2 };

                var resuals = querry.Select(x => new ClassSubjectUPDto()
                {
                    LectuterId = x.ct.HomeroomLecturer,
                    SpecializedId = x.ct.SpecializedOfClass,
                    SubjectId = x.ct.SubjectId,
                    ClassId = x.ct.ClassId,
                    JoinCode = x.ct.JoinCode,
                    ClassroomName = x.c.ClassroomName,
                    StudentAmount= x.ct.StudentAmount,
                    Building = x.c.Building,
                    StatusClass = x.c.Status,
                    StatusSubjectClass = x.ct2.Status,
                    SubjectName = x.ct2.SubjectName,
                    Sinhvienthucte = _Irepstudentclass.AsQueryable().Where(c => c.ClassId == x.ct.ClassId).Count(),
                }).ToList();

                if (!string.IsNullOrEmpty(parameters.Name))
                    resuals = resuals.Where(x => x.ClassroomName.ToLower().Contains(parameters.Name.ToLower())).ToList();

                var count = resuals.Count();

                var data = resuals
                   .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                   .Take(parameters.PageSize)
                   .ToList();

                return new PageList<ClassSubjectUPDto>(data, count
                    , parameters.PageNumber
                    , parameters.PageSize);
            }
            else if (subjectId == Guid.Empty)
            {
                var querry = from c in _Irepository.AsQueryable()
                             join ct in _Irepsubclass.AsQueryable() on c.Id equals ct.ClassId
                             join ct2 in _Irepsub.AsQueryable() on ct.SubjectId equals ct2.Id
                             where ct.HomeroomLecturer == lecuId && ct.SpecializedOfClass == specializedId
                             select new { c, ct, ct2 };

                var resuals = querry.Select(x => new ClassSubjectUPDto()
                {
                    LectuterId = x.ct.HomeroomLecturer,
                    SpecializedId = x.ct.SpecializedOfClass,
                    SubjectId = x.ct.SubjectId,
                    ClassId = x.ct.ClassId,
                    JoinCode = x.ct.JoinCode,
                    ClassroomName = x.c.ClassroomName,
                    StudentAmount= x.ct.StudentAmount,
                    Building = x.c.Building,

                    StatusClass = x.c.Status,
                    StatusSubjectClass = x.ct2.Status,
                    SubjectName = x.ct2.SubjectName,
                    Sinhvienthucte = _Irepstudentclass.AsQueryable().Where(c => c.ClassId == x.ct.ClassId).Count(),
                }).ToList();

                if (!string.IsNullOrEmpty(parameters.Name))
                    resuals = resuals.Where(x => x.ClassroomName.ToLower().Contains(parameters.Name.ToLower())).ToList();

                var count = resuals.Count();

                var data = resuals
                   .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                   .Take(parameters.PageSize)
                   .ToList();

                return new PageList<ClassSubjectUPDto>(data, count
                    , parameters.PageNumber
                    , parameters.PageSize);
            }
            else
            {
                var querry = from c in _Irepository.AsQueryable()
                             join ct in _Irepsubclass.AsQueryable() on c.Id equals ct.ClassId
                             join ct2 in _Irepsub.AsQueryable() on ct.SubjectId equals ct2.Id
                             where ct.SubjectId == subjectId && ct.HomeroomLecturer == lecuId && ct.SpecializedOfClass == specializedId
                             select new { c, ct, ct2 };

                var resuals = querry.Select(x => new ClassSubjectUPDto()
                {
                    LectuterId = x.ct.HomeroomLecturer,
                    SpecializedId = x.ct.SpecializedOfClass,
                    SubjectId = x.ct.SubjectId,
                    ClassId = x.ct.ClassId,
                    JoinCode = x.ct.JoinCode,
                    ClassroomName = x.c.ClassroomName,
                    StudentAmount= x.ct.StudentAmount,
                    Building = x.c.Building,

                    StatusClass = x.c.Status,
                    StatusSubjectClass = x.ct2.Status,
                    SubjectName = x.ct2.SubjectName,
                    Sinhvienthucte = _Irepstudentclass.AsQueryable().Where(c => c.ClassId == x.ct.ClassId).Count(),
                }).ToList();

                if (!string.IsNullOrEmpty(parameters.Name))
                    resuals = resuals.Where(x => x.ClassroomName.ToLower().Contains(parameters.Name.ToLower())).ToList();

                var count = resuals.Count();

                var data = resuals
                   .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                   .Take(parameters.PageSize)
                   .ToList();

                return new PageList<ClassSubjectUPDto>(data, count
                    , parameters.PageNumber
                    , parameters.PageSize);
            }
        }
    }
}
