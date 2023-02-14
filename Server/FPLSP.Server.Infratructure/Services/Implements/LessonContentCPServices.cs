using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.LessonContentCP;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class LessonContentCPServices : ILessonContentCPServices
    {
        private readonly IRepository<LessonContentCP> _res;
        private readonly IRepository<LessonCP> _reslesson;
        private readonly IRepository<ResourceLink> _reslink;
        public LessonContentCPServices(IRepository<LessonContentCP> res, IRepository<LessonCP> reslesson
            , IRepository<ResourceLink> reslink)
        {
            _res = res;
            _reslesson = reslesson;
            _reslink = reslink;
        }

        public async Task<int> Create(Guid lessonId, LessonContentCreateVM lesson)
        {
            try
            {
                var ls = _res.AsQueryable().ToList()
                .Where(c => Equals(false, c.IsDeleted) && Equals(lessonId, c.IdLesson))
                .ToList();
                var ResourceLinkId = _reslink.AsQueryable().ToList().Where(c => Equals(lesson.Path, c.Path)).Select(c => c.Id).FirstOrDefault();
                if (ResourceLinkId == Guid.Empty)
                {
                    return 0;
                }



                if (ls.Count == 0)
                {
                    var lessonContenNew = new LessonContentCP()
                    {
                        IdLesson = lessonId,
                        ResourceLinkId = ResourceLinkId,
                        LessonContentCode = "BH01",
                        LessonContentName = lesson.LessonContentName,
                        Content = lesson.Content,
                        Descriptions = lesson.Descriptions,
                        CreatedTime = DateTime.Now,
                        Status = lesson.Status,
                        IndexOfLessonContent = lesson.Index

                    };
                    try
                    {
                        await _res.AddAsync(lessonContenNew);
                        await _res.SaveChangesAsync();
                        return 1;
                    }
                    catch
                    {
                        return 0;
                    }
                }
                else
                {
                    int lessonCodeInt;
                    string lessonCodeString;
                    int lessonNameInt;
                    string lessonNameString;
                    var lastcode = ls
                    .Where(c => Equals(lessonId, c.IdLesson))
                    .OrderByDescending(c => c.CreatedTime)
                    .Select(c => c.LessonContentCode).First();

                    var codeidentity = lastcode.Substring((lastcode.Length - 2), 2);
                    lessonCodeInt = Convert.ToInt32(codeidentity) + 1;

                    if (lessonCodeInt < 10)
                    {
                        lessonCodeString = "0" + lessonCodeInt.ToString();
                    }
                    else
                    {
                        lessonCodeString = lessonCodeInt.ToString();
                    }

                    var lessonContenNew = new LessonContentCP()
                    {
                        IdLesson = lessonId,
                        ResourceLinkId = ResourceLinkId,
                        LessonContentCode = "BH" + lessonCodeString,
                        LessonContentName = lesson.LessonContentName,
                        Content = lesson.Content,
                        Descriptions = lesson.Descriptions,
                        CreatedTime = DateTime.Now,
                        Status = lesson.Status,
                        IndexOfLessonContent = lesson.Index
                    };
                    try
                    {
                        await _res.AddAsync(lessonContenNew);
                        await _res.SaveChangesAsync();
                        return 1;
                    }
                    catch
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public async Task<int> Delete(Guid id)
        {

            try
            {
                var lessonConten = _res.AsQueryable().ToList().FirstOrDefault(c => Equals(id, c.Id));
                if (lessonConten.Status == 0)
                {
                    lessonConten.Status = 1;
                    await _res.UpdateAsync(lessonConten);
                    await _res.SaveChangesAsync();

                }
                else
                {
                    lessonConten.Status = 0;
                    await _res.UpdateAsync(lessonConten);
                    await _res.SaveChangesAsync();
                }
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<List<LessonContentDto>> GetAllAsync(Guid lessonId)
        {
            try
            {
                var querry = from c in _res.AsQueryable().ToList()
                             join ct in _reslesson.AsQueryable().ToList() on c.IdLesson equals ct.Id
                             join ct2 in _reslink.AsQueryable().ToList() on c.ResourceLinkId equals ct2.Id
                             where c.IsDeleted == false && c.IdLesson == lessonId
                             select new { c, ct, ct2 };

                var resuals = querry.Select(x => new LessonContentDto()
                {
                    Id = x.c.Id,
                    IdLesson = x.ct.Id,
                    ResourceLinkId = x.ct2.Id,
                    LessonContentCode = x.c.LessonContentCode,
                    LessonContentName = x.c.LessonContentName,
                    Content = x.c.Content,
                    Descriptions = x.c.Descriptions,
                    Path = querry.Select(c => c.ct2.Path).ToList(),
                    Pathclone = x.ct2.Path,
                    Index = x.c.IndexOfLessonContent
                }).ToList();

                return resuals;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public async Task<List<LessonContentDto>> GetAllLessonContent()
        {
            try
            {
                var querry = _res.AsQueryable().ToList();


                var resuals = querry.Select(x => new LessonContentDto()
                {
                    Id = x.Id,
                    IdLesson = x.IdLesson,
                    ResourceLinkId = x.Id,
                    LessonContentCode = x.LessonContentCode,
                    LessonContentName = x.LessonContentName,
                    Content = x.Content,
                    Descriptions = x.Descriptions,
                    Index = x.IndexOfLessonContent
                }).ToList();

                return resuals;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<LessonContentUpdateVM> GetbyId(Guid id)
        {
            try
            {
                var querry = from c in _res.AsQueryable().ToList()
                             join ct2 in _reslink.AsQueryable().ToList() on c.ResourceLinkId equals ct2.Id
                             where c.IsDeleted == false

                             select new { c, ct2 };



                var resuals = querry.Select(x => new LessonContentUpdateVM()
                {
                    Id = x.c.Id,
                    Content = x.c.Content,
                    LessonContentCode = x.c.LessonContentCode,
                    LessonContentName = x.c.LessonContentName,
                    Status = x.c.Status,
                    Descriptions = x.c.Descriptions,
                    Path = x.ct2.Path,
                    Index = x.c.IndexOfLessonContent,
                }).ToList();

                var resual = resuals.FirstOrDefault(c => id == c.Id);

                return resual;
            }
            catch (Exception ex)
            {
                return null;
            }

        }


        public async Task<PageList<LessonContentDto>> GetPagingParamets(Guid lessonId, LessonContentListSearch parameters)
        {
            try
            {
                var querry = from c in _res.AsQueryable().ToList()
                             join ct in _reslesson.AsQueryable().ToList() on c.IdLesson equals ct.Id
                             join ct2 in _reslink.AsQueryable().ToList() on c.ResourceLinkId equals ct2.Id
                             where c.IsDeleted == false && c.IdLesson == lessonId
                             select new { c, ct, ct2 };
                var resuals = querry.Select(x => new LessonContentDto()
                {
                    Id = x.c.Id,
                    IdLesson = x.ct.Id,
                    ResourceLinkId = x.ct2.Id,
                    LessonContentCode = x.c.LessonContentCode,
                    LessonContentName = x.c.LessonContentName,
                    Content = x.c.Content,
                    Descriptions = x.c.Descriptions,
                    Pathclone = x.ct2.Path,
                    TitleLink = x.ct2.ResourcesTitle,
                    Status = x.c.Status,
                    Index = x.c.IndexOfLessonContent,
                    Path = querry.Select(c => c.ct2.Path).ToList(),
                }).ToList();

                if (!string.IsNullOrEmpty(parameters.Name))
                    resuals = resuals.Where(x => x.LessonContentName.Contains(parameters.Name)).ToList();
                if (parameters.Status != 3)
                    resuals = resuals.Where(x => x.Status == parameters.Status).ToList();
                resuals = resuals.OrderBy(p => p.Index).ToList();
                var count = resuals.Count();

                var data = resuals
                   .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                   .Take(parameters.PageSize)
                   .ToList();

                return new PageList<LessonContentDto>(data, count
                    , parameters.PageNumber
                    , parameters.PageSize);
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<int> Update(Guid id, LessonContentUpdateVM lesson_update)
        {

            try
            {
                var LessonContentUd = _res.AsQueryable().ToList().FirstOrDefault(c => Equals(id, c.Id));
                var ResourceLinkId =  _reslink.AsQueryable().ToList().Where(c => Equals(lesson_update.Path, c.Path)).Select(c => c.Id).FirstOrDefault();
                LessonContentUd.ResourceLinkId = ResourceLinkId;
                LessonContentUd.LessonContentName = lesson_update.LessonContentName;
                LessonContentUd.Content = lesson_update.Content;
                LessonContentUd.Descriptions = lesson_update.Descriptions;
                LessonContentUd.Status = lesson_update.Status;
                LessonContentUd.IndexOfLessonContent = lesson_update.Index;
                await _res.UpdateAsync(LessonContentUd);
                await _res.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }


        public async Task<bool> RemoveListLessonContentCP(List<Guid> listIdLesson)
        {
            try
            {
                List<LessonContentCP> lessonCP = new List<LessonContentCP>();
                foreach (var item in listIdLesson)
                {
                    var statuss = _res.AsQueryable().ToList().FirstOrDefault(c => c.Id == item);
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
