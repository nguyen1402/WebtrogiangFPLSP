using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.Lesson;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class LessonCPServices : ILessonCPServices
    {
        private readonly IRepository<LessonCP> _res;
        private readonly IRepository<SubjectCP> _ressj;
        public LessonCPServices(IRepository<LessonCP> res, IRepository<SubjectCP> ressj)
        {
            _res = res;
            _ressj = ressj;
        }

        public async Task<int> CreateLesson(Guid subjectId, LessonCreateVM lesson)
        {
            try
            {
                var newlesson = new LessonCP()
                {
                    SubjectId = subjectId,
                    LessonName = "Bài " + lesson.Index + " - " + lesson.LessonName,
                    LessonCode = lesson.Index.ToString(),
                    Descriptions = lesson.Descriptions,
                    CreatedTime = DateTime.Now,
                    Status = lesson.Status,
                    IndexOfLesson = lesson.Index,
                    Id = lesson.Id
                };
                await _res.AddAsync(newlesson);
                await _res.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<int> DeleteLesson(Guid id)
        {

            try
            {
                var lesson =  _res.AsQueryable().ToList().FirstOrDefault(c => Equals(id, c.Id));
                if (lesson.Status == 0)
                {
                    lesson.Status = 1;
                    await _res.UpdateAsync(lesson);
                    await _res.SaveChangesAsync();

                }
                else
                {
                    lesson.Status = 0;
                    await _res.UpdateAsync(lesson);
                    await _res.SaveChangesAsync();
                }
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<List<LessonDto>> GetAllAsync(Guid subjectId)
        {
            try
            {
                var querry = from c in _res.AsQueryable().ToList().Where(p => p.IsDeleted == false)
                             join ct in _ressj.AsQueryable().ToList() on c.SubjectId equals ct.Id
                             where c.SubjectId == subjectId
                             select new { c, ct };

                var resuals = querry.Select(x => new LessonDto()
                {
                    Id = x.c.Id,
                    SubjectId = x.c.SubjectId,
                    LessonName = x.c.LessonName,
                    LessonCode = x.c.LessonCode,
                    Descriptions = x.c.Descriptions,
                    SubjectCode = x.ct.SubjectCode,
                    SubjectName = x.ct.SubjectName,
                    TotalOfSub = x.ct.TotalOfSub,
                    Status = x.c.Status,
                    Index = x.c.IndexOfLesson
                }).ToList();

                return resuals;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public async Task<List<LessonDto>> GetAllLesson()
        {
            try
            {
                var querry = _res.AsQueryable().ToList();


                var resuals = querry.Select(x => new LessonDto()
                {
                    Id = x.Id,
                    SubjectId = x.SubjectId,
                    LessonName = x.LessonName,
                    LessonCode = x.LessonCode,
                    Descriptions = x.Descriptions,
                    Status = x.Status,
                    Index = x.IndexOfLesson
                }).ToList();

                return resuals;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<LessonDto> GetbyId(Guid id)
        {
            try
            {
                var querry = from c in _res.AsQueryable().ToList()
                             join ct in _ressj.AsQueryable().ToList() on c.SubjectId equals ct.Id
                             select new { c, ct };

                var resuals = querry.Select(x => new LessonDto()
                {
                    Id = x.c.Id,
                    SubjectId = x.c.SubjectId,
                    LessonName = x.c.LessonName,
                    LessonCode = x.c.LessonCode,
                    Descriptions = x.c.Descriptions,
                    SubjectCode = x.ct.SubjectCode,
                    SubjectName = x.ct.SubjectName,
                    TotalOfSub = x.ct.TotalOfSub,
                    Status = x.c.Status,
                    Index = x.c.IndexOfLesson
                }).ToList();

                var resual = resuals.FirstOrDefault(c => Equals(id, c.Id));
                return resual;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<PageList<LessonDto>> GetLessons(Guid subjectId, LessonListSearch parameters)
        {
            try
            {
                var querry = from c in _res.AsQueryable().ToList().Where(p => p.IsDeleted == false)
                             join ct in _ressj.AsQueryable().ToList() on c.SubjectId equals ct.Id
                             where c.SubjectId == subjectId
                             select new { c, ct };

                var resuals =  querry.Select(x => new LessonDto()
                {
                    Id = x.c.Id,
                    SubjectId = x.c.SubjectId,
                    LessonName = x.c.LessonName,
                    LessonCode = x.c.LessonCode,
                    Descriptions = x.c.Descriptions,
                    SubjectCode = x.ct.SubjectCode,
                    SubjectName = x.ct.SubjectName,
                    TotalOfSub = x.ct.TotalOfSub,
                    Status = x.c.Status,
                    Index = x.c.IndexOfLesson
                }).ToList();
                if (!string.IsNullOrEmpty(parameters.Name))
                    resuals = resuals.Where(x => x.LessonName.ToLower().Contains(parameters.Name.ToLower())).ToList();
                if (parameters.Status != 3)
                    resuals = resuals.Where(x => x.Status == parameters.Status).ToList();
                resuals = resuals.OrderBy(p => p.Index).ToList();
                var count = resuals.Count();
                var data = resuals
                   .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                   .Take(parameters.PageSize)
                   .ToList();

                return new PageList<LessonDto>(data, count
                    , parameters.PageNumber
                    , parameters.PageSize);
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<int> UpdateLesson(Guid id, LessonUpdateVM lesson_update)
        {


            try
            {
                var lesson =  _res.AsQueryable().ToList().FirstOrDefault(c => Equals(id, c.Id));
                lesson.LessonName = "Bài " + lesson_update.Index + " - " + lesson_update.LessonName;
                lesson.Descriptions = lesson_update.Descriptions;
                lesson.Status = lesson_update.Status;
                lesson.IndexOfLesson = lesson_update.Index;
                await _res.UpdateAsync(lesson);
                await _res.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<bool> RemoveListLessonCP(List<Guid> listIdLesson)
        {
            try
            {
                List<LessonCP> lessonCP = new List<LessonCP>();
                foreach (var item in listIdLesson)
                {
                    var statuss =  _res.AsQueryable().ToList().FirstOrDefault(c => c.Id == item);
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
