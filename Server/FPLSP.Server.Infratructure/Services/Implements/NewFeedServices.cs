using AutoMapper;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.NewFeed;
using FPLSP.Server.Infrastructure.ViewModels.SubmitHomeWorkVM;
using Microsoft.AspNetCore.Identity;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class NewFeedServices : INewFeedServices
    {

        private readonly IRepository<News> _iNewFeeder;
        private readonly IRepository<TypeOfNewFeed> _itypeOfNewfeed;
        private readonly IRepository<SubjectUP> _isub;
        private readonly IRepository<ClassUp> _iclass;
        private readonly IRepository<StudentClassUP> _IStuClass;
        private readonly IRepository<SubjectClassUP> _ISubClass;
        private readonly IMapper _mapper;
        private List<ListKeyNotifi> listKeyNotifis = new List<ListKeyNotifi>();
        private List<News> _lstNews = new List<News>();
        private readonly UserManager<UserSignIn> _userManager;
        private List<NewFeedOverView> _lstNewFeed = new List<NewFeedOverView>();

        public NewFeedServices(IRepository<News> iNewFeeder, IRepository<SubjectClassUP> ISubClass, IRepository<StudentClassUP> IStuClass, IRepository<SubjectUP> idsub, IRepository<ClassUp> iclass, IMapper mapper, UserManager<UserSignIn> userManager, IRepository<TypeOfNewFeed> itypeOfNewfeed)
        {
            _iNewFeeder = iNewFeeder;
            _mapper = mapper;
            _isub = idsub;
            _ISubClass = ISubClass;
            _IStuClass = IStuClass;
            _iclass = iclass;
            _itypeOfNewfeed = itypeOfNewfeed;
            _userManager = userManager;
        }
        public async Task<List<NewFeedOverView>> GetListNewForUser(Guid IdUser)
        {


            foreach (var x in _IStuClass.AsQueryable().Where(c => c.StudentId == Guid.Parse(IdUser.ToString())).ToList())
            {
                foreach (var subclass in _ISubClass.AsQueryable().ToList().Where(c => c.JoinCode == x.JoinCodeAsign))
                {
                    listKeyNotifis.Add(new ListKeyNotifi()
                    {
                        IdClass = subclass.ClassId,
                        IdSubject = subclass.SubjectId
                    });

                }

            }


            foreach (var x in listKeyNotifis)
            {
                foreach (var z in _iNewFeeder.AsQueryable().ToList().Where(c => c.IdClass == x.IdClass && c.IdSubject == x.IdSubject))
                {

                    var newModel = new NewFeedOverView()
                    {
                        Id = z.Id,
                        Title = z.Title,
                        Content = z.Content,
                        Image = z.Image,
                        IdClass = z.IdClass,
                        IdSubject = z.IdSubject,
                        Status = z.Status,
                        EndDate = z.EndDate,
                        IdLesson = Guid.Parse(Convert.ToString(z.IdLesson)),
                        IdTypeOfNewFeed = z.IdTypeOfNewFeed,
                        ClassName = _iclass.AsQueryable().ToList().Where(c => c.Id == z.IdClass).Select(c => c.ClassroomName).FirstOrDefault(),
                        SubjectName = _isub.AsQueryable().ToList().Where(c => c.Id == z.IdSubject).Select(c => c.SubjectName).FirstOrDefault(),
                        CratedTime = z.CratedTime,
                        Sender = _userManager.Users.Where(c => c.Id == z.IdUser).Select(c => c.UserName).FirstOrDefault(),
                        TypeOfNewFeed = _itypeOfNewfeed.AsQueryable().ToList().Where(c => c.Id == z.Id).Select(c => c.Title).FirstOrDefault(),
                        Priority = _iNewFeeder.AsQueryable().ToList().Max(c => c.Priority) + 1,
                        IsReaded = z.IsReaded,
                        IdUser = z.IdUser,
                    };
                    _lstNewFeed.Add(newModel);

                }
            }
            return _lstNewFeed;
        }
        public async Task<List<NewFeedOverView>> GetListNewForClass(Guid IdClass, Guid IdSubject)
        {


            foreach (var z in _iNewFeeder.AsQueryable().ToList().Where(c => c.IdClass == IdClass && c.IdSubject == IdSubject))
            {

                var newModel = new NewFeedOverView()
                {
                    Id = z.Id,
                    Title = z.Title,
                    Content = z.Content,
                    Image = z.Image,
                    Status = z.Status,
                    EndDate = z.EndDate,
                    IdLesson = Guid.Parse(Convert.ToString(z.IdLesson)),
                    IdTypeOfNewFeed = z.IdTypeOfNewFeed,
                    ClassName = _iclass.AsQueryable().ToList().Where(c => c.Id == z.IdClass).Select(c => c.ClassroomName).FirstOrDefault(),
                    SubjectName = _isub.AsQueryable().ToList().Where(c => c.Id == z.IdSubject).Select(c => c.SubjectName).FirstOrDefault(),
                    CratedTime = z.CratedTime,
                    Sender = _userManager.Users.Where(c => c.Id == z.IdUser).Select(c => c.UserName).FirstOrDefault(),
                    TypeOfNewFeed = _itypeOfNewfeed.AsQueryable().ToList().Where(c => c.Id == z.Id).Select(c => c.Title).FirstOrDefault(),
                    Priority = z.Priority,
                    IsReaded = z.IsReaded,
                    IdClass = z.IdClass,
                    IdSubject = z.IdSubject,
                    IdUser = z.IdUser
                };
                _lstNewFeed.Add(newModel);


            }
            return _lstNewFeed;
        }
        public async Task<PageList<NewFeedOverView>> GetListAllNewFeed(SearchNewFeed searchNewFeed)
        {
            var finallist = (from a in _iNewFeeder.AsQueryable().ToList().ToList().Where(c => c.Status != 1)

                             select new NewFeedOverView()
                             {
                                 Id = a.Id,
                                 Title = a.Title,
                                 Content = a.Content,
                                 Image = a.Image,
                                 Status = a.Status,
                                 EndDate = a.EndDate,
                                 UserName = _userManager.Users.Where(c => c.Id == a.IdUser).Select(c => c.UserName).FirstOrDefault(),
                                 ClassName = _iclass.AsQueryable().ToList().Where(c => c.Id == a.IdClass).Select(c => c.ClassroomName).FirstOrDefault(),
                                 SubjectName = _isub.AsQueryable().ToList().Where(c => c.Id == a.IdSubject).Select(c => c.SubjectName).FirstOrDefault(),
                                 CratedTime = a.CratedTime,
                                 Sender = _userManager.Users.Where(c => c.Id == a.IdUser).Select(c => c.UserName).FirstOrDefault(),
                                 TypeOfNewFeed = _itypeOfNewfeed.AsQueryable().ToList().Where(c => c.Id == a.Id).Select(c => c.Title).FirstOrDefault(),
                                 Priority = a.Priority,
                                 IsReaded = a.IsReaded,
                                 IdClass = a.IdClass,
                                 IdSubject = a.IdSubject,
                                 IdLesson = Guid.Parse(a.IdLesson.ToString()),
                                 IdUser = a.IdUser,
                                 IdTypeOfNewFeed = a.IdTypeOfNewFeed,
                             }).ToList();
            //var query = ;
            //return query;
            return new PageList<NewFeedOverView>(finallist, finallist.Count, searchNewFeed.PageNumber, searchNewFeed.PageSize);
        }
        public async Task<bool> AddToNewFeed(NewFeedVM newFeedVM)
        {
            if (newFeedVM == null)
            {
                return false;
            }
            var newss = new News()
            {
                Id = Guid.NewGuid(),
                Title = newFeedVM.Title,
                Content = newFeedVM.Content,
                Image = newFeedVM.Image,
                Status = 0,
                CratedTime = DateTime.Now,
                EndDate = default,
                Priority = 1,
                IdLesson = newFeedVM.IdLesson,
                IsReaded = false,
                IdClass = newFeedVM.IdClass,
                IdSubject = newFeedVM.IdSubject,
                IdTypeOfNewFeed = Guid.Parse("9A0CCC99-F28A-4608-8BD4-48EE2BD2E0FB"),
                IdUser = newFeedVM.IdUser
            };


            await _iNewFeeder.AddAsync(newss);
            await _iNewFeeder.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateNewFeed(Guid IdNewFeed, NewFeedVM newFeedVM)
        {
            if (IdNewFeed == null || newFeedVM == null)
            {
                return false;
            }
            var newfeed = _mapper.Map<News>(newFeedVM);

            await _iNewFeeder.UpdateAsync(newfeed);
            await _iNewFeeder.SaveChangesAsync();
            return true;
        }
        public async Task<bool> RemoveNewFeed(Guid IdNewFeed)
        {
            if (IdNewFeed == null)
            {
                return false;
            }
            foreach (var x in _iNewFeeder.AsQueryable().ToList().Where(c => c.Id == IdNewFeed))
            {
                x.Status = 1;
                await _iNewFeeder.UpdateAsync(x);
                await _iNewFeeder.SaveChangesAsync();
            }

            return true;
        }


    }
}
