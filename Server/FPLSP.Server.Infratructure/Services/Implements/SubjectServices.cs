using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Dtos.QuizCPDtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.Subject;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class SubjectServices : ISubjectServices
    {
        private readonly IRepository<SubjectCP> _res;
        private readonly IRepository<LessonCP> _reslesson;
        private readonly IRepository<QuizCP> _resquiz;
        private readonly IRepository<SpecializedSubjectCP> _resmonhocchuyennganh;
        private readonly IRepository<SpecializedCP> _reschuyennganh;
        private ILessonCPServices _lessonCPServices;
        private IQuizCPServices _quizCPServices;
        private readonly IRepository<SubjectUP> _subjectUP;
        private readonly IRepository<SpecializedSubjectUP> _subjectspecializedUP;

        public SubjectServices(IRepository<SubjectCP> res, IRepository<LessonCP> reslesson, IRepository<QuizCP> resquiz, IRepository<SpecializedSubjectCP> resmonhocchuyennganh, IRepository<SpecializedCP> reschuyennganh, ILessonCPServices lessonCPServices, IQuizCPServices quizCPServices, IRepository<SubjectUP> subjectUP, IRepository<SpecializedSubjectUP> subjectspecializedUP)
        {
            _res = res;
            _reslesson = reslesson;
            _resquiz = resquiz;
            _resmonhocchuyennganh = resmonhocchuyennganh;
            _reschuyennganh = reschuyennganh;
            _lessonCPServices = lessonCPServices;
            _quizCPServices = quizCPServices;
            _subjectUP = subjectUP;
            _subjectspecializedUP = subjectspecializedUP;
        }

        /// <summary>
        /// Thêm mới một đối tượng có thông tin bằng với đối tượng được truyền vào
        /// </summary>
        /// <param name="subject"> thông tin đối tượng được thêm mới</param>
        /// <returns>trả về 0 nếu xảy ra lỗi, trả về 1 nếu thêm thành công</returns>
        public async Task<int> CreateSubject(SubjectCreateVM subject)
        {
            try
            {
                var result = DateTime.Compare(subject.StartDay, subject.EndDay);

                if (result >= 0)
                    return 0;
                if (subject.idspec == Guid.Empty)
                    return 0;

                var idsubject = subject.Id;
                var newsubject = new SubjectCP()
                {
                    Id = idsubject,
                    SubjectCode = subject.SubjectCode,
                    SubjectName = subject.SubjectName,
                    CreatedDay = DateTime.Now,
                    StartDay = subject.StartDay,
                    EndDay = subject.EndDay,
                    TotalOfSub = subject.TotalOfSub,
                    Status = subject.Status,
                    Image = subject.Image,
                    IsDemo = subject.IsDemo

                };
                await _res.AddAsync(newsubject);
                await _res.SaveChangesAsync();

                var newchuyennganhmonhoc = new SpecializedSubjectCP()
                {
                    SpecializedId = subject.idspec,
                    SubjectId = idsubject,
                    Status = subject.Status
                };

                var tontai = _resmonhocchuyennganh.AsQueryable().ToList().Any(c => String.Equals(subject.idspec, c.SpecializedId) && Equals(idsubject, c.SubjectId));
                if (tontai) return 0;
                await _resmonhocchuyennganh.AddAsync(newchuyennganhmonhoc);
                await _resmonhocchuyennganh.SaveChangesAsync();

                var newsubjectUP = new SubjectUP()
                {
                    Id = idsubject,
                    SubjectCode = subject.SubjectCode,
                    SubjectName = subject.SubjectName,
                    CreatedDay = DateTime.Now,
                    StartDay = subject.StartDay,
                    EndDay = subject.EndDay,
                    TotalOfSub = subject.TotalOfSub,
                    Status = subject.Status,
                    Image = subject.Image,
                    IsDemo = subject.IsDemo
                };
                await _subjectUP.AddAsync(newsubjectUP);
                await _subjectUP.SaveChangesAsync();


                var tontai1 = _subjectspecializedUP.AsQueryable().ToList().Any(c => String.Equals(subject.idspec, c.SpecializedId) && Equals(idsubject, c.SubjectId));
                if (tontai) return 0;


                var newchuyennganhmonhocUP = new SpecializedSubjectUP()
                {
                    SpecializedId = subject.idspec,
                    SubjectId = idsubject,
                    Status = subject.Status
                };
                await _subjectspecializedUP.AddAsync(newchuyennganhmonhocUP);
                await _subjectspecializedUP.SaveChangesAsync();

                return 1;
            }
            catch
            {
                return 0;
            }

        }
        /// <summary>
        /// xóa đối tượng có id bằng với id được truyền vào
        /// </summary>
        /// <param name="id">id môn học được truyền vào</param>
        /// <returns>trả về 0 nếu xảy ra lỗi, trả về 1 nếu xóa thành công</returns>
        public async Task<int> DeleteSubject(Guid id)
        {
            try
            {
                var subject = _res.AsQueryable().ToList().FirstOrDefault(c => Equals(id, c.Id));
                if (subject.Status == 1)
                {

                    subject.Status = 0;
                    await _res.UpdateAsync(subject);
                    await _res.SaveChangesAsync();

                }
                else
                {
                    subject.Status = 1;
                    await _res.UpdateAsync(subject);
                    await _res.SaveChangesAsync();
                }
                return 1;
            }
            catch
            {
                return 0;
            }

        }
        /// <summary>
        /// lấy hết tất cả môn học
        /// </summary>
        /// <returns>danh sách tất cả các môn học</returns>
        //public async Task<List<SubjectDto>> GetAllSubjectByIdSpecialzed(Guid idspecialzed)
        //{
        //    try
        //    {
        //        var querry = from c in _res.AsQueryable().ToList()
        //                     join ct1 in _resmonhocchuyennganh.AsQueryable().ToList() on c.Id equals ct1.SubjectId
        //                     where ct1.SpecializedId == idspecialzed
        //                     select new { c, ct1 };
        //        var resuals = querry.Select(x => new SubjectDto()
        //        {
        //            Id = x.c.Id,
        //            Idspec = x.ct1.SpecializedId,
        //            SubjectCode = x.c.SubjectCode,
        //            SubjectName = x.c.SubjectName,
        //            StartDay = x.c.StartDay,
        //            EndDay = x.c.EndDay,
        //            IsDeleted = x.c.IsDeleted,
        //            TotalOfSub = x.c.TotalOfSub,
        //            Status = x.c.Status,
        //            Image = x.c.Image,
        //        }).ToList();
        //        return resuals;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }

        //}
        public async Task<List<SubjectDto>> GetAllSubjectByIdSpecialzed(Guid idspecialzed)
        {
            try
            {
                var lstSpec = _subjectspecializedUP.AsQueryable().ToList().Where(c => c.SpecializedId == idspecialzed).Select(c=>c.SubjectId).ToList();
                var lstSubject = _res.AsQueryable().ToList().Where(c => lstSpec.Contains(c.Id)).ToList();

                var resuals = lstSubject.Select(x => new SubjectDto()
                {
                    Id = x.Id,
                    SubjectCode = x.SubjectCode,
                    SubjectName = x.SubjectName,
                    StartDay = x.StartDay,
                    EndDay = x.EndDay,
                    IsDeleted = x.IsDeleted,
                    TotalOfSub = x.TotalOfSub,
                    Status = x.Status,
                    Image = x.Image,
                }).ToList();
                return resuals;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public async Task<IQueryable<SubjectCP>> GetAllSubjectAsync()
        {
            try
            {
                var resual = _res.AsQueryable();
                return resual;
            }
            catch (Exception ex)
            {
                return null;

            }

        }
        /// <summary>
        /// lấy ra thông tin môn học có id bằng với id được truyền vào
        /// </summary>
        /// <param name="id">id môn học được truyền vào</param>
        /// <returns></returns>

        //public async Task<SubjectDto> GetSubjectbyId(Guid id)
        //{
        //    try
        //    {
        //        var a = await _res.AsQueryable().ToListAsync();
        //        var querry = from c in _res.AsQueryable().ToList()
        //                     join ct in _reslesson.AsQueryable().ToList() on c.Id equals ct.SubjectId
        //                     join ct2 in _resquiz.AsQueryable().ToList() on c.Id equals ct2.SubjectId
        //                     join ct1 in _resmonhocchuyennganh.AsQueryable().ToList() on c.Id equals ct1.SubjectId
        //                     where c.Id == id
        //                     select new { c, ct, ct2, ct1 };

        //        var querry2 = from c in _res.AsQueryable().ToList()
        //                      join ct1 in _resmonhocchuyennganh.AsQueryable().ToList() on c.Id equals ct1.SubjectId
        //                      join ct2 in _reschuyennganh.AsQueryable().ToList() on ct1.SpecializedId equals ct2.Id
        //                      where c.Id == id
        //                      select new { c, ct1, ct2 };

        //        var querry3 = from c in _res.AsQueryable().ToList()
        //                      join ct in _reslesson.AsQueryable().ToList() on c.Id equals ct.SubjectId
        //                      where c.Id == id
        //                      select new { c, ct };


        //        var listlesson = querry3.Select(x => new LessonDto()
        //        {
        //            Id = x.ct.Id,
        //            SubjectId = x.c.Id,
        //            LessonName = x.ct.LessonName,
        //            LessonCode = x.ct.LessonCode,
        //            Status = x.ct.Status,

        //        }).ToList();

        //        var querry4 = from c in _res.AsQueryable().ToList()
        //                      join ct2 in _resquiz.AsQueryable().ToList() on c.Id equals ct2.SubjectId
        //                      where c.Id == id
        //                      select new { c, ct2 };
        //        var listquizs = querry4.Select(x => new SubjectQuizCPDtos()
        //        {
        //            Id = x.ct2.Id,
        //            QuizName = x.ct2.QuizName,
        //        }).ToList();

        //        List<string> strings = querry2.Where(c => Equals(id, c.ct1.SubjectId)).Select(c => c.ct2.SpecializationName).ToList();

        //        var resuals = querry.Select(x => new SubjectDto()
        //        {
        //            Id = x.c.Id,
        //            Idspec = x.ct1.SpecializedId,
        //            SubjectCode = x.c.SubjectCode,
        //            SubjectName = x.c.SubjectName,
        //            StartDay = x.c.StartDay,
        //            EndDay = x.c.EndDay,
        //            TotalOfSub = x.c.TotalOfSub,
        //            Status = x.c.Status,
        //            Image = x.c.Image,
        //            chuyennganh = strings,
        //            listlesson = listlesson,
        //            listquizs = listquizs,
        //            IsDemo = x.c.IsDemo,
        //            countLesson = _reslesson.AsQueryable().ToList().Where(c => Equals(id, c.SubjectId)).Select(c => c.LessonCode).Count(),
        //            countQuiz = _resquiz.AsQueryable().ToList().Where(c => Equals(id, c.SubjectId)).Select(c => c.QuizName).Count(),
        //        }).ToList();
        //        var resual = resuals.FirstOrDefault(c => Equals(id, c.Id));
        //        if (resual == null)
        //        {
        //            var resuals2 = _res.AsQueryable().ToList().Select(x => new SubjectDto()
        //            {
        //                Id = x.Id,
        //                SubjectCode = x.SubjectCode,
        //                SubjectName = x.SubjectName,
        //                StartDay = x.StartDay,
        //                EndDay = x.EndDay,
        //                TotalOfSub = x.TotalOfSub,
        //                Status = x.Status,
        //                Image = x.Image,
        //                IsDemo = x.IsDemo,
        //            }).ToList();
        //            var resual2 = resuals2.FirstOrDefault(c => Equals(id, c.Id));
        //            return resual2;
        //        }
        //        else
        //        {
        //            return resual;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }

        // }       
        public async Task<SubjectDto> GetSubjectbyId(Guid id)
        {
            try
            {
                var querry = await _res.AsQueryable().ToListAsync();
                var lstreslesson = await _reslesson.AsQueryable().ToListAsync();
                var lstresquiz = await _resquiz.AsQueryable().ToListAsync();
                var resuals = querry.Select(x => new SubjectDto()
                {
                    Id = x.Id,
                    //Idspec = x.SpecializedId,
                    SubjectCode = x.SubjectCode,
                    SubjectName = x.SubjectName,
                    StartDay = x.StartDay,
                    EndDay = x.EndDay,
                    TotalOfSub = x.TotalOfSub,
                    Status = x.Status,
                    Image = x.Image,
                  
                    IsDemo = x.IsDemo,
                    countLesson = lstreslesson.Where(c => Equals(id, c.SubjectId)).Select(c => c.LessonCode).Count(),
                    countQuiz = lstresquiz.Where(c => Equals(id, c.SubjectId)).Select(c => c.QuizName).Count(),
                }).ToList();
                var resual = resuals.FirstOrDefault(c => c.Id == id);
                return resual;

            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public async Task<SubjectUpdateVM> GetUpdateSubjectbyId(Guid id)
        {
            try
            {
                var getLst = await _res.AsQueryable().ToListAsync();
                var subjectdb = getLst.FirstOrDefault(c => c.Id == id);
                var subjectUpdate = new SubjectUpdateVM()
                {
                    SubjectCode = subjectdb.SubjectCode,
                    SubjectName = subjectdb.SubjectName,
                    TotalOfSub = subjectdb.TotalOfSub,
                    Image = subjectdb.Image,
                    Status = subjectdb.Status,
                    IsDemo = subjectdb.IsDemo,
                    StartDay = subjectdb.StartDay,
                    EndDay = subjectdb.EndDay,
                };
                return subjectUpdate;

            }
            catch (Exception ex)
            {
                return null;
            }

        }

        /// <summary>
        /// lấy danh sách môn học thuộc chuyên ngành có id bằng với id được truyền vào theo keyword search
        /// </summary>
        /// <param name="specid"> id chuyên ngành được chuyền vào</param>
        /// <param name="subjectParameters"> keyword để search</param>
        /// <returns>trả về sách môn học thuộc chuyên ngành có id bằng với id được truyền vào theo keyword search</returns>
        //public async Task<PageList<SubjectDto>> GetSubjects(Guid specid, SubjectCPSearch subjectParameters)
        //{
        //    try
        //    {
        //        var querry = from c in _res.AsQueryable().ToList()
        //                     join ct1 in _resmonhocchuyennganh.AsQueryable().ToList() on c.Id equals ct1.SubjectId
        //                     select new { c, ct1 };
        //        var resuals = querry.Select(x => new SubjectDto()
        //        {
        //            Id = x.c.Id,
        //            Idspec = x.ct1.SpecializedId,
        //            SubjectCode = x.c.SubjectCode,
        //            SubjectName = x.c.SubjectName,
        //            StartDay = x.c.StartDay,
        //            EndDay = x.c.EndDay,
        //            IsDeleted = x.c.IsDeleted,
        //            TotalOfSub = x.c.TotalOfSub,
        //            Status = x.c.Status,
        //            Image = x.c.Image,
        //            IsDemo = x.c.IsDemo
        //        }).ToList();
        //        //foreach (var item in resuals)
        //        //{
        //        //    var lessoncount = await _lessonCPServices.GetAllAsync(item.Id);
        //        //    if (lessoncount != null)
        //        //    {
        //        //        item.countLesson = lessoncount.Count;
        //        //    }

        //        //    var quizcount = await _quizCPServices.GetAllQuizCPbyIdSubject(item.Id);
        //        //    if (quizcount != null)
        //        //    {
        //        //        item.countQuiz = quizcount.Count;
        //        //    }

        //        //}
        //        var lssubject = resuals.Where(c => Equals(specid, c.Idspec));

        //        if (!string.IsNullOrEmpty(subjectParameters.Name))
        //            lssubject = lssubject.Where(x => x.SubjectName.ToLower().Contains(subjectParameters.Name.ToLower()));
        //        if (subjectParameters.Status != 3)
        //            lssubject = lssubject.Where(x => x.Status == subjectParameters.Status);



        //        lssubject = lssubject.OrderBy(p => p.SubjectName);

        //        var count = lssubject.Count();

        //        var data = lssubject
        //            .Skip((subjectParameters.PageNumber - 1) * subjectParameters.PageSize)
        //            .Take(subjectParameters.PageSize)
        //            .ToList();

        //        return new PageList<SubjectDto>(data, count
        //            , subjectParameters.PageNumber
        //            , subjectParameters.PageSize);
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //} 
        public async Task<PageList<SubjectDto>> GetSubjects(Guid specid, SubjectCPSearch subjectParameters)
        {
            try
            {
                var lstSpecAll = await _subjectspecializedUP.AsQueryable().ToListAsync();
                var lstSpec = lstSpecAll.Where(c => c.SpecializedId == specid).Select(c => c.SubjectId).ToList();
                var lstSubjectAll = await _res.AsQueryable().ToListAsync();
                var lstSubject = lstSubjectAll.Where(c => lstSpec.Contains(c.Id)).ToList();

                var resuals = lstSubject.Select(x => new SubjectDto()
                {
                    Id = x.Id,
                    SubjectCode = x.SubjectCode,
                    SubjectName = x.SubjectName,
                    StartDay = x.StartDay,
                    EndDay = x.EndDay,
                    IsDeleted = x.IsDeleted,
                    TotalOfSub = x.TotalOfSub,
                    Status = x.Status,
                    Image = x.Image,
                }).ToList();
                //foreach (var item in resuals)
                //{
                //    var lessoncount = await _lessonCPServices.GetAllAsync(item.Id);
                //    if (lessoncount != null)
                //    {
                //        item.countLesson = lessoncount.Count;
                //    }

                //    var quizcount = await _quizCPServices.GetAllQuizCPbyIdSubject(item.Id);
                //    if (quizcount != null)
                //    {
                //        item.countQuiz = quizcount.Count;
                //    }

                //}
                var lssubject = resuals;

                if (!string.IsNullOrEmpty(subjectParameters.Name))
                    lssubject = lssubject.Where(x => x.SubjectName.ToLower().Contains(subjectParameters.Name.ToLower())).ToList();
                if (subjectParameters.Status != 3)
                    lssubject = lssubject.Where(x => x.Status == subjectParameters.Status).ToList();



                lssubject = lssubject.OrderBy(p => p.SubjectName).ToList();

                var count = lssubject.Count();

                var data = lssubject
                    .Skip((subjectParameters.PageNumber - 1) * subjectParameters.PageSize)
                    .Take(subjectParameters.PageSize)
                    .ToList();

                return new PageList<SubjectDto>(data, count
                    , subjectParameters.PageNumber
                    , subjectParameters.PageSize);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// cập nhật đối tượng có id bằng với được truyền vào bằng các thông tin đối tượng được truyền vào cùng là subject
        /// </summary>
        /// <param name="id">id môn học</param>
        /// <param name="subject">thông tin đối tượng được truyền vào</param>
        /// <returns>trả về đối tượng có id được truyền vào bằng các thông tin đối tượng được truyền vào cùng là subject</returns>
        public async Task<int> UpdateSubject(Guid id, SubjectUpdateVM subject)
        {
            try
            {
                var subject_db = await _res.AsQueryable().FirstOrDefaultAsync(c => Equals(id, c.Id));
                subject_db.SubjectCode = subject.SubjectCode;
                subject_db.SubjectName = subject.SubjectName;
                subject_db.TotalOfSub = subject.TotalOfSub;
                subject_db.StartDay = subject_db.StartDay;
                subject_db.EndDay = subject_db.EndDay;
                subject_db.Status = subject.Status;
                subject_db.Image = subject.Image;
                subject_db.IsDemo = subject.IsDemo;
                await _res.UpdateAsync(subject_db);
                await _res.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }


        }
        public async Task<bool> RemoveListSubjectCP(List<Guid> listIdReport)
        {
            try
            {
                List<SubjectCP> subjectCP = new List<SubjectCP>();
                foreach (var item in listIdReport)
                {
                    var statuss = await _res.AsQueryable().FirstOrDefaultAsync(c => c.Id == item);
                    if (statuss.Status == 0)
                    {
                        statuss.Status = 1;
                        await _res.UpdateAsync(statuss);
                        await _res.SaveChangesAsync();
                    }
                    else
                    {
                        statuss.Status = 0;
                        await _res.UpdateAsync(statuss);
                        await _res.SaveChangesAsync();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }

}

