using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop;
using FPLSP.Server.Infrastructure.ViewModels.SpesializedUP;

namespace FPLSP.Repositories.Services
{
    public class ClassSubjectApiClient : IClassSubjectApiClient
    {
        private readonly IRepository<ClassUp> _Irepository;
        private readonly IRepository<SubjectClassUP> _Irepsubclass;
        private readonly IRepository<SubjectClassUP> _subclassRepository;
        private readonly IRepository<SubjectUP> _Irepsub;
        private readonly IRepository<QuizUP> _Irepquiz;
        private readonly IRepository<StudentClassUP> _Irepstudentclass;
        private readonly IRepository<HomeWork> _IrephomeWork;
        private readonly IRepository<SubmitHomeWork> _IrepsubmitHomeWork;
        private readonly IRepository<BookMarkClass> _Irepbookmake;
        private readonly IRepository<News> _Irepnew;
        private readonly IRepository<LectuterSpecializedUP> _Ireplecspec;
        private readonly IRepository<SpecializedUP> _Irepspec;
        private readonly HttpClient _httpClient;

        public ClassSubjectApiClient(IRepository<ClassUp> irepository, IRepository<SubjectClassUP> irepsubclass, IRepository<SubjectClassUP> subclassRepository, IRepository<SubjectUP> irepsub, IRepository<QuizUP> irepquiz, IRepository<StudentClassUP> irepstudentclass, IRepository<HomeWork> irephomeWork, IRepository<SubmitHomeWork> irepsubmitHomeWork, IRepository<BookMarkClass> irepbookmake, IRepository<News> irepnew, IRepository<LectuterSpecializedUP> ireplecspec, IRepository<SpecializedUP> irepspec, HttpClient httpClient)
        {
            _Irepository = irepository;
            _Irepsubclass = irepsubclass;
            _subclassRepository = subclassRepository;
            _Irepsub = irepsub;
            _Irepquiz = irepquiz;
            _Irepstudentclass = irepstudentclass;
            _IrephomeWork = irephomeWork;
            _IrepsubmitHomeWork = irepsubmitHomeWork;
            _Irepbookmake = irepbookmake;
            _Irepnew = irepnew;
            _Ireplecspec = ireplecspec;
            _Irepspec = irepspec;
            _httpClient = httpClient;
        }

        public async Task<int> Create(SubjectClassVM classUp)
        {
            var url = Path.Combine("/api/ClassServices");
            var resual = await _httpClient.PostAsJsonAsync(url, classUp);
            if (resual.IsSuccessStatusCode) return 1;
            return 0;
        }

        public async Task<PageList<ClassSubjectUPDto>> GetPagingParamets(Guid subjectId, Guid lecuId, Guid specializedId, SubjectServicesCPListSearch parameters)
        {
            //var queryStringParam = new Dictionary<string, string>
            //{
            //    ["pageNumber"] = parameters.PageNumber.ToString()
            //};
            //if (!string.IsNullOrEmpty(parameters.Name))
            //    queryStringParam.Add("name", parameters.Name);

            //string url = QueryHelpers.AddQueryString($"/api/ClassServices/getall/{subjectId}/{lecuId}/{specializedId}", queryStringParam);

            //var result = await _httpClient.GetFromJsonAsync<PageList<ClassSubjectUPDto>>(url);

            //return result;
            //var joicode = _subclassRepository.AsQueryable().ToList().Where(c => c.ClassId == idClass && c.SubjectId == subjectId).Select(c => c.JoinCode).FirstOrDefault();
            if (subjectId == Guid.Empty && specializedId == Guid.Empty)
            {
                var querry = from c in _Irepository.AsQueryable().ToList()
                             join ct in _Irepsubclass.AsQueryable().ToList().Where(c => c.Status != 1).ToList() on c.Id equals ct.ClassId
                             join ct2 in _Irepsub.AsQueryable().ToList() on ct.SubjectId equals ct2.Id
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
                    CreatedDayClass = x.ct.DateCreated,
                    Building = x.c.Building,
                    StudentAmount = x.ct.StudentAmount,
                    StatusClass = x.c.Status,
                    StatusSubjectClass = x.ct2.Status,
                    SubjectName = x.ct2.SubjectName,
                    Sinhvienthucte = _Irepstudentclass.AsQueryable().ToList().Where(c => c.ClassId == x.ct.ClassId && c.JoinCodeAsign == x.ct.JoinCode).Count(),
                }).ToList();

                if (!string.IsNullOrEmpty(parameters.Name))
                    resuals = resuals.Where(x => x.ClassroomName.ToLower().Contains(parameters.Name.ToLower())).ToList();

                var count = resuals.Count();

                var data = resuals
                   .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                   .Take(parameters.PageSize)
                   .ToList();

                //return new PageList<ClassSubjectUPDto>(data, count
                //    , parameters.PageNumber
                //    , parameters.PageSize);

                var pagel = new PageList<ClassSubjectUPDto>(data, count
                    , parameters.PageNumber
                    , parameters.PageSize);

                var data2 = pagel.Items.Select(x => new ClassSubjectUPDto()
                {
                    LectuterId = x.LectuterId,
                    SpecializedId = x.SpecializedId,
                    SubjectId = x.SubjectId,
                    ClassId = x.ClassId,
                    JoinCode = x.JoinCode,
                    ClassroomName = x.ClassroomName,
                    CreatedDayClass = x.CreatedDayClass,
                    ClassroomCode = x.ClassroomCode,
                    Building = x.Building,
                    StudentAmount = x.StudentAmount,
                    StatusClass = x.StatusClass,
                    StatusSubjectClass = x.StatusSubjectClass,
                    SubjectName = x.SubjectName,
                    Sinhvienthucte = x.Sinhvienthucte,
                });
                return new PageList<ClassSubjectUPDto>(data2.ToList(),
                    pagel.MetaData.TotalCount,
                    pagel.MetaData.CurrentPage,
                    pagel.MetaData.PageSize);
            }
            else if (subjectId == Guid.Empty)
            {
                var querry = from c in _Irepository.AsQueryable().ToList()
                             join ct in _Irepsubclass.AsQueryable().ToList().Where(c => c.Status != 1).ToList() on c.Id equals ct.ClassId
                             join ct2 in _Irepsub.AsQueryable().ToList() on ct.SubjectId equals ct2.Id
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
                    StudentAmount = x.ct.StudentAmount,
                    CreatedDayClass = x.ct.DateCreated,
                    Building = x.c.Building,
                    StatusClass = x.c.Status,
                    StatusSubjectClass = x.ct2.Status,
                    SubjectName = x.ct2.SubjectName,
                    Sinhvienthucte = _Irepstudentclass.AsQueryable().ToList().Where(c => c.ClassId == x.ct.ClassId && c.JoinCodeAsign == x.ct.JoinCode).Count(),
                }).ToList();

                if (!string.IsNullOrEmpty(parameters.Name))
                    resuals = resuals.Where(x => x.ClassroomName.ToLower().Contains(parameters.Name.ToLower())).ToList();

                var count = resuals.Count();

                var data = resuals
                   .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                   .Take(parameters.PageSize)
                   .ToList();

                var pagel = new PageList<ClassSubjectUPDto>(data, count
                    , parameters.PageNumber
                    , parameters.PageSize);

                var data2 = pagel.Items.Select(x => new ClassSubjectUPDto()
                {
                    LectuterId = x.LectuterId,
                    SpecializedId = x.SpecializedId,
                    SubjectId = x.SubjectId,
                    ClassId = x.ClassId,
                    JoinCode = x.JoinCode,
                    ClassroomName = x.ClassroomName,
                    CreatedDayClass = x.CreatedDayClass,
                    ClassroomCode = x.ClassroomCode,
                    Building = x.Building,
                    StudentAmount = x.StudentAmount,
                    StatusClass = x.StatusClass,
                    StatusSubjectClass = x.StatusSubjectClass,
                    SubjectName = x.SubjectName,
                    Sinhvienthucte = x.Sinhvienthucte,
                });
                return new PageList<ClassSubjectUPDto>(data2.ToList(),
                    pagel.MetaData.TotalCount,
                    pagel.MetaData.CurrentPage,
                    pagel.MetaData.PageSize);
            }
            else
            {
                var querry = from c in _Irepository.AsQueryable().ToList()
                             join ct in _Irepsubclass.AsQueryable().ToList().Where(c => c.Status != 1).ToList() on c.Id equals ct.ClassId
                             join ct2 in _Irepsub.AsQueryable().ToList() on ct.SubjectId equals ct2.Id
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
                    Building = x.c.Building,
                    StudentAmount = x.ct.StudentAmount,
                    StatusClass = x.c.Status,
                    StatusSubjectClass = x.ct2.Status,
                    SubjectName = x.ct2.SubjectName,
                    Sinhvienthucte = _Irepstudentclass.AsQueryable().ToList().Where(c => c.ClassId == x.ct.ClassId && c.JoinCodeAsign == x.ct.JoinCode).Count(),
                }).ToList();

                if (!string.IsNullOrEmpty(parameters.Name))
                    resuals = resuals.Where(x => x.ClassroomName.ToLower().Contains(parameters.Name.ToLower())).ToList();

                var count = resuals.Count();

                var data = resuals
                   .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                   .Take(parameters.PageSize)
                   .ToList();

                var pagel = new PageList<ClassSubjectUPDto>(data, count
                    , parameters.PageNumber
                    , parameters.PageSize);

                var data2 = pagel.Items.Select(x => new ClassSubjectUPDto()
                {
                    LectuterId = x.LectuterId,
                    SpecializedId = x.SpecializedId,
                    SubjectId = x.SubjectId,
                    ClassId = x.ClassId,
                    JoinCode = x.JoinCode,
                    ClassroomName = x.ClassroomName,
                    CreatedDayClass = x.CreatedDayClass,
                    ClassroomCode = x.ClassroomCode,
                    Building = x.Building,
                    StudentAmount = x.StudentAmount,
                    StatusClass = x.StatusClass,
                    StatusSubjectClass = x.StatusSubjectClass,
                    SubjectName = x.SubjectName,
                    Sinhvienthucte = x.Sinhvienthucte,
                });
                return new PageList<ClassSubjectUPDto>(data2.ToList(),
                    pagel.MetaData.TotalCount,
                    pagel.MetaData.CurrentPage,
                    pagel.MetaData.PageSize);
            }
        }

        public async Task<ListIdQuiz> GetListIDQuiz(Guid subjectId)
        {

            var result = await _httpClient.GetFromJsonAsync<ListIdQuiz>($"/api/ClassServices/getlistidquiz/{subjectId}");

            return result;
        }

        public async Task<ClassUp> GetClassUPByIdClass(Guid idClass)
        {

            var result = await _httpClient.GetFromJsonAsync<ClassUp>($"/api/ClassServices/getClassUPByIdClass/{idClass}");

            return result;
        }

        public async Task<List<ClassUp>> GetlstClassUP(Guid subjectId)
        {

            var result = await _httpClient.GetFromJsonAsync<List<ClassUp>>($"/api/ClassServices/getlistClassUP/{subjectId}");

            return result;
        }

        public async Task<List<SubjectClassUP>> GetAllSubjectClass()
        {
            var result = await _httpClient.GetFromJsonAsync<List<SubjectClassUP>>($"/api/ClassServices/getAllSubjectClass");
            return result;
        }
        public async Task<List<ClassUp>> GetAllClass()
        {
            var result = _Irepository.AsQueryable().ToList();
            return result;
        }

        public async Task<int> Delete(Guid idclass, Guid idsubject)
        {
            //var result = await _httpClient.DeleteAsync($"/api/ClassServices/{idclass}");
            //if (result.IsSuccessStatusCode) return 1;
            //return 0;
            //var c_lass = _Irepository.AsQueryable().FirstOrDefault(c => Guid.Equals(idclass, c.Id));
            if (idclass != Guid.Empty && idsubject != Guid.Empty)
            {
                var joicode = _subclassRepository.AsQueryable().ToList().Where(c => c.ClassId == idclass && c.SubjectId == idsubject).Select(c => c.JoinCode).FirstOrDefault();
                var c_lasshomework = _IrephomeWork.AsQueryable().Where(c => Guid.Equals(idclass, c.IdClass) && Guid.Equals(idsubject, c.IdSubject)).ToList();
                var c_lasssubmithomework = _IrepsubmitHomeWork.AsQueryable().Where(c => Guid.Equals(idclass, c.IdClass) && Guid.Equals(idsubject, c.IdSubject)).ToList();
                var c_lasssubject = _Irepsubclass.AsQueryable().Where(c => Guid.Equals(idclass, c.ClassId) && Guid.Equals(idsubject, c.SubjectId)).ToList();
                var c_lassstudent = _Irepstudentclass.AsQueryable().Where(c => Guid.Equals(idclass, c.ClassId) && Guid.Equals(joicode, c.JoinCodeAsign)).ToList();
                var c_lassnews = _Irepnew.AsQueryable().Where(c => Guid.Equals(idclass, c.IdClass) && Guid.Equals(idsubject, c.IdSubject)).ToList();
                var c_bookmake = _Irepbookmake.AsQueryable().Where(c => Guid.Equals(idclass, c.IdClass) && Guid.Equals(idsubject, c.IdSubject)).ToList();
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
            }
            else
            {
                return 0;
            }
            return 1;
            //try
            //{
            //    await _Irepository.RemoveAsync(c_lass);
            //    await _Irepository.SaveChangesAsync();
            //    return 1;
            //}
            //catch
            //{
            //    return 0;
            //}
        }

        public async Task<List<SpecializedUPViewModel>> GetChuyenNganh(Guid idLec)
        {
            try
            {
                var querry = from c in _Irepspec.AsQueryable().ToList()
                             join ct in _Ireplecspec.AsQueryable().ToList().Where(c => c.LectuterId == idLec).ToList() on c.Id equals ct.SpecializedId
                             select new { c, ct };
                var resuals = querry.Select(x => new SpecializedUPViewModel()
                {
                    Id = x.c.Id,
                    SpecializationName = x.c.SpecializationName
                }).ToList();

                return resuals;
            }
            catch
            {

                return null;
            }

        }
        public async Task<int> Soluongsinhvientronglop(Guid idClass, Guid subjectId)
        {
            var joicode = _subclassRepository.AsQueryable().ToList().Where(c => c.ClassId == idClass && c.SubjectId == subjectId).Select(c => c.JoinCode).FirstOrDefault();
            var x = _Irepstudentclass.AsQueryable().ToList().Where(c => c.ClassId == idClass && c.JoinCodeAsign == joicode).Select(c => c.ClassId).ToList().Count();
            return x;
        }

    }
}
