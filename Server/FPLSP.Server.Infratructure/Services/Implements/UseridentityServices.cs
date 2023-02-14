using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class UseridentityServices : IUseridentityServices
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<UserSignIn> _userManager;
        private readonly IRepository<UserSignIn> _userRepository;
        private readonly IRepository<LecturersCP> _lectureRepository;
        private readonly IRepository<LectuterSpecializedCP> _lectuterSpecializedCPRepository;
        private readonly IRepository<LectuterSpecializedUP> _lectuterSpecializedUPRepository;
        private readonly IRepository<SubjectClassUP> _subjectClassUPRepository;
        private readonly IRepository<StudentUP> _StudentUPRepository;
        private readonly IRepository<StudentClassUP> _StudentClassUPRepository;
        private readonly IRepository<StudentQuizUP> _StudentQuizUPRepository;
        private readonly IRepository<News> _NewsRepository;
        private readonly IRepository<SubjectTeacher> _SubjectTeacherRepository;
        private readonly IRepository<SupervisorExamRoom> _SupervisorExamRoomRepository;
        private readonly IRepository<SubmitHomeWork> _SubmitHomeWorkRepository;
        private readonly IRepository<BookMarkClass> _Irepbookmake;
        private readonly IHttpContextAccessor _httpContextAccessor;

        private ICollection<News> Newss = new List<News>();
        private ICollection<HomeWork> Homes = new List<HomeWork>();
        private ICollection<BookMarkClass> BM = new List<BookMarkClass>();
        public List<string> AllRoles { set; get; } = new List<string>();

        private List<UserInListRoles> _lstUsers = new List<UserInListRoles>();

        public UseridentityServices(RoleManager<IdentityRole> roleManager, UserManager<UserSignIn> userManager, IRepository<UserSignIn> userRepository, IRepository<LecturersCP> lectureRepository, IRepository<LectuterSpecializedCP> lectuterSpecializedCPRepository, IRepository<LectuterSpecializedUP> lectuterSpecializedUPRepository, IRepository<SubjectClassUP> subjectClassUPRepository, IRepository<StudentUP> studentUPRepository, IRepository<StudentClassUP> studentClassUPRepository, IRepository<StudentQuizUP> studentQuizUPRepository, IRepository<News> newsRepository, IRepository<SubjectTeacher> subjectTeacherRepository, IRepository<SupervisorExamRoom> supervisorExamRoomRepository, IRepository<SubmitHomeWork> submitHomeWorkRepository, IRepository<BookMarkClass> irepbookmake, IHttpContextAccessor httpContextAccessor)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _userRepository = userRepository;
            _lectureRepository = lectureRepository;
            _lectuterSpecializedCPRepository = lectuterSpecializedCPRepository;
            _lectuterSpecializedUPRepository = lectuterSpecializedUPRepository;
            _subjectClassUPRepository = subjectClassUPRepository;
            _StudentUPRepository = studentUPRepository;
            _StudentClassUPRepository = studentClassUPRepository;
            _StudentQuizUPRepository = studentQuizUPRepository;
            _NewsRepository = newsRepository;
            _SubjectTeacherRepository = subjectTeacherRepository;
            _SupervisorExamRoomRepository = supervisorExamRoomRepository;
            _SubmitHomeWorkRepository = submitHomeWorkRepository;
            _Irepbookmake = irepbookmake;
            _httpContextAccessor = httpContextAccessor;
        }






        //public UseridentityServices(RoleManager<IdentityRole> roleManager,
        //                  UserManager<UserSignIn> userManager,
        //                 IHttpContextAccessor httpContextAccessor)
        //{
        //    _roleManager = roleManager;
        //    _userManager = userManager;
        //    _lstUsers = new List<UserInListRoles>();
        //    _httpContextAccessor = httpContextAccessor;
        //}
        public async Task<PageList<UserInListRoles>> GetAllUserNotRole(UserRoleSearch userRoleSearch)
        {
            //ClaimsPrincipal principal = _httpContextAccessor.HttpContext.User;
            //var cuser = await _userManager.GetRolesAsync(principal);

            // await _userManager.AddToRolesAsync(cuser, new string[] { "Editor" });
            var lusers = new List<UserInListRoles>();
            foreach (var item in _userRepository.AsQueryable().ToList())
            {
                var add = new UserInListRoles()
                {
                    Id = item.Id,
                    ListRoles = _userManager.GetRolesAsync(item).Result.ToList(),
                    UserName = item.UserName,
                    IdTrainingFacility = item.IdTrainingFacility
                };
                if (add.ListRoles.Count() == 0)
                {
                    lusers.Add(add);
                }
            }

            //tìm kiếm theo tên
            if (!string.IsNullOrEmpty(userRoleSearch.Name))
            {
                lusers = lusers.Where(c => c.UserName.Contains(userRoleSearch.Name)).ToList();
            }
            if (!string.IsNullOrEmpty(userRoleSearch.Role))
            {
                lusers = lusers.Where(c => c.ListRoles.Contains(userRoleSearch.Role)).ToList();
            }

            int totalUsers = lusers.Count();
            var data = lusers.Skip((userRoleSearch.PageNumber - 1) * userRoleSearch.PageSize).Take(userRoleSearch.PageSize).ToList();
            return new PageList<UserInListRoles>(data, totalUsers, userRoleSearch.PageNumber, userRoleSearch.PageSize); ;
        }
        public async Task<PageList<UserInListRoles>> GetAllUser(UserRoleSearch userRoleSearch)
        {
            //ClaimsPrincipal principal = _httpContextAccessor.HttpContext.User;
            //var cuser = await _userManager.GetRolesAsync(principal);

            // await _userManager.AddToRolesAsync(cuser, new string[] { "Editor" });
            var lusers = (from u in _userManager.Users
                          orderby u.UserName
                          select new UserInListRoles()
                          {
                              Id = u.Id,
                              ListRoles = _userManager.GetRolesAsync(u).Result.ToList(),

                              UserName = u.UserName,
                              IdTrainingFacility = u.IdTrainingFacility
                          }).ToList();

            foreach (var user in lusers)
            {
                var roles = await _userManager.GetRolesAsync(user);
                user.ListRoles = roles.ToList();
            }
            //tìm kiếm theo tên
            if (!string.IsNullOrEmpty(userRoleSearch.Name))
            {
                lusers = lusers.Where(c => c.UserName.Contains(userRoleSearch.Name)).ToList();
            }
            if (!string.IsNullOrEmpty(userRoleSearch.Role))
            {
                lusers = lusers.Where(c => c.ListRoles.Contains(userRoleSearch.Role)).ToList();
            }
            if (userRoleSearch.StatusNotRole == 1)
            {
                lusers = lusers.Where(c => c.ListRoles.Count() == 0).ToList();
            }

            int totalUsers = lusers.Count();
            var data = lusers.Skip((userRoleSearch.PageNumber - 1) * userRoleSearch.PageSize).Take(userRoleSearch.PageSize).ToList();
            return new PageList<UserInListRoles>(data, totalUsers, userRoleSearch.PageNumber, userRoleSearch.PageSize); ;
        }
        public async Task<List<UserInListRoles>> GetAllListUser()
        {
            var lusers = (from u in _userManager.Users
                          orderby u.UserName
                          select new UserInListRoles()
                          {
                              Id = u.Id,
                              ListRoles = _userManager.GetRolesAsync(u).Result.ToList(),

                              UserName = u.UserName,
                              IdTrainingFacility = u.IdTrainingFacility
                          }).ToList();

            foreach (var user in lusers)
            {
                var roles = await _userManager.GetRolesAsync(user);
                user.ListRoles = roles.ToList();
            }
            return lusers;
        }
        public async Task<bool> AddRolesToUser(UserUpdateRoles userUpdateRoles)
        {
            if (userUpdateRoles.ID == null)
            {
                return false;
            }
            var user = await _userManager.FindByIdAsync(userUpdateRoles.ID);
            var roles = await _userManager.GetRolesAsync(user);
            //lấy claims



            if (userUpdateRoles.RoleNames == null)
            {
                userUpdateRoles.RoleNames = new string[] { };
            }

            foreach (var rolename in userUpdateRoles.RoleNames)
            {
                if (roles.Contains(rolename))
                    continue;
                await _userManager.AddToRoleAsync(user, rolename);
            }
            foreach (var rolename in roles)
            {
                if (userUpdateRoles.RoleNames.Contains(rolename)) continue;
                await _userManager.RemoveFromRoleAsync(user, rolename);
            }
            return true;
        }

        public async Task<UserInListRoles> GetUserRoleById(string Id)
        {
            var lusers = (from u in _userManager.Users
                          orderby u.UserName
                          select new UserInListRoles()
                          {
                              Id = u.Id,
                              PasswordHash = u.PasswordHash,
                              NormalizedEmail = u.NormalizedEmail,
                              HomeWorks = Homes,
                              BookMarkClasses = BM,
                              IdTrainingFacility = u.IdTrainingFacility,
                              NormalizedUserName = u.NormalizedUserName,
                              LockoutEnd = DateTimeOffset.Now,
                              LockoutEnabled = u.LockoutEnabled == null ? true : u.LockoutEnabled,
                              PhoneNumber = u.PhoneNumber == null ? "19000" : u.PhoneNumber,
                              UserName = u.UserName,
                              News = Newss,
                              Email = u.Email
                          }).ToList();
            foreach (var user in lusers)
            {
                var roles = await _userManager.GetRolesAsync(user);
                user.ListRoles = roles.ToList();
            }
            var finalModel = lusers.Find(x => x.Id == Id);
            return finalModel;
        }

        public async Task<UserInListRoles> GetRoleUser(string email)
        {

            var lusers = (from u in _userManager.Users
                          orderby u.UserName
                          select new UserInListRoles()
                          {
                              Id = u.Id,
                              PasswordHash = u.PasswordHash,
                              NormalizedEmail = u.NormalizedEmail,
                              HomeWorks = Homes,
                              BookMarkClasses = BM,
                              IdTrainingFacility = u.IdTrainingFacility,
                              NormalizedUserName = u.NormalizedUserName,
                              LockoutEnd = DateTimeOffset.Now,
                              LockoutEnabled = u.LockoutEnabled == null ? true : u.LockoutEnabled,
                              PhoneNumber = u.PhoneNumber == null ? "19000" : u.PhoneNumber,
                              UserName = u.UserName,
                              News = Newss,
                              Email = u.Email
                          }).ToList();
            foreach (var user in lusers)
            {
                var roles = await _userManager.GetRolesAsync(user);
                user.ListRoles = roles.ToList();
            }
            var finalModel = lusers.Find(x => email == x.Email);
            return finalModel;

        }
        public async Task<bool> CheckUserChageIdTrain(string idUser, Guid idTrain)
        {
            try
            {
                var userById = await _userManager.FindByIdAsync(idUser);
                var lstRoleUser = _userManager.GetRolesAsync(userById).Result.ToList();
                if (lstRoleUser.Any(c => c == "LecturerFPLSP"))
                {
                    var lecture = _lectureRepository.AsQueryable().ToList().FirstOrDefault(c => c.Id == Guid.Parse(idUser));
                    lecture.TrainingFacilitiesId = idTrain;
                    await _lectureRepository.UpdateAsync(lecture);
                    await _lectureRepository.SaveChangesAsync();

                    var lstLectureSpec = _lectuterSpecializedCPRepository.AsQueryable().ToList().Where(c => c.LectuterId == lecture.Id).ToList();
                    await _lectuterSpecializedCPRepository.RemoveRangeAsync(lstLectureSpec);
                    await _lectuterSpecializedCPRepository.SaveChangesAsync();

                    var lstLectureSpecUP = _lectuterSpecializedUPRepository.AsQueryable().ToList().Where(c => c.LectuterId == lecture.Id).ToList();
                    await _lectuterSpecializedUPRepository.RemoveRangeAsync(lstLectureSpecUP);
                    await _lectuterSpecializedUPRepository.SaveChangesAsync();

                    var lstSubjectClass = _subjectClassUPRepository.AsQueryable().ToList().Where(c => c.HomeroomLecturer == lecture.Id).ToList();
                    foreach (var studentInClass in lstSubjectClass)
                    {
                        
                        var lstStudentNews = _NewsRepository.AsQueryable().ToList().Where(c => Guid.Equals(studentInClass.ClassId, c.IdClass) && Guid.Equals(studentInClass.SubjectId, c.IdSubject)).ToList();
                        await _NewsRepository.RemoveRangeAsync(lstStudentNews);
                        await _NewsRepository.SaveChangesAsync();

                        var lstStudentSubmit = _SubmitHomeWorkRepository.AsQueryable().ToList().Where(c => Guid.Equals(studentInClass.ClassId, c.IdClass) && Guid.Equals(studentInClass.SubjectId, c.IdSubject)).ToList();
                        await _SubmitHomeWorkRepository.RemoveRangeAsync(lstStudentSubmit);
                        await _SubmitHomeWorkRepository.SaveChangesAsync();

                        var lstBookMake = _Irepbookmake.AsQueryable().Where(c => Guid.Equals(studentInClass.ClassId, c.IdClass) && Guid.Equals(studentInClass.SubjectId, c.IdSubject)).ToList();
                        await _Irepbookmake.RemoveRangeAsync(lstBookMake);
                        await _Irepbookmake.SaveChangesAsync();
                    }

                    var lstJoinCode = lstSubjectClass.Select(c => c.JoinCode).ToList();
                    var studentClass = _StudentClassUPRepository.AsQueryable().ToList().Where(c => lstJoinCode.Contains(c.JoinCodeAsign)).ToList();

                    await _StudentClassUPRepository.RemoveRangeAsync(studentClass);
                    await _StudentClassUPRepository.SaveChangesAsync();

                    await _subjectClassUPRepository.RemoveRangeAsync(lstSubjectClass);
                    await _subjectClassUPRepository.SaveChangesAsync();

                }
                //if (lstRoleUser.Any(c => c == "GV FPLExam"))
                //{
                //    var lecture = _lectureRepository.AsQueryable().ToList().FirstOrDefault(c => c.Id == Guid.Parse(idUser));
                //    lecture.TrainingFacilitiesId = idTrain;
                //    await _lectureRepository.UpdateAsync(lecture);
                //    await _lectureRepository.SaveChangesAsync();


                //    var lstSubjectTeacher = _SubjectTeacherRepository.AsQueryable().ToList().Where(c => c.IdTeacher == lecture.Id).ToList();

                //    await _SubjectTeacherRepository.RemoveRangeAsync(lstSubjectTeacher);
                //    await _SubjectTeacherRepository.SaveChangesAsync();


                //    var lstSupervisorExamRoom = _SupervisorExamRoomRepository.AsQueryable().ToList().Where(c => c.IdLecturter == lecture.Id).ToList();

                //    await _SupervisorExamRoomRepository.RemoveRangeAsync(lstSupervisorExamRoom);
                //    await _SupervisorExamRoomRepository.SaveChangesAsync();


                //}
                if (lstRoleUser.Any(c => c == "Student"))
                {
                    var student = _StudentUPRepository.AsQueryable().ToList().FirstOrDefault(c => c.Id == Guid.Parse(idUser));

                    var studentClass = _StudentClassUPRepository.AsQueryable().ToList().Where(c => c.StudentId == student.Id).ToList();
                    await _StudentClassUPRepository.RemoveRangeAsync(studentClass);
                    await _StudentClassUPRepository.SaveChangesAsync();

                    var lstStudentQuiz = _StudentQuizUPRepository.AsQueryable().ToList().Where(c => c.StudentId == student.Id).ToList();
                    await _StudentQuizUPRepository.RemoveRangeAsync(lstStudentQuiz);
                    await _StudentQuizUPRepository.SaveChangesAsync();

                    var lstStudentNews = _NewsRepository.AsQueryable().ToList().Where(c => c.IdUser == student.Id.ToString()).ToList();
                    await _NewsRepository.RemoveRangeAsync(lstStudentNews);
                    await _NewsRepository.SaveChangesAsync();

                    var lstStudentSubmit = _SubmitHomeWorkRepository.AsQueryable().ToList().Where(c => c.IdStudent == student.Id).ToList();
                    await _SubmitHomeWorkRepository.RemoveRangeAsync(lstStudentSubmit);
                    await _SubmitHomeWorkRepository.SaveChangesAsync();
                }
                return true;
            }
            catch
            {

                return false;
            }

        }
        public async Task<bool> DeleteUserNorRole(string idUser)
        {
            try
            {
                var userById = await _userManager.FindByIdAsync(idUser);
                var lstRoleUser = _userManager.GetRolesAsync(userById).Result.ToList();
                if (lstRoleUser.Any(c => c == "LecturerFPLSP"))
                {
                    var lecture = _lectureRepository.AsQueryable().ToList().FirstOrDefault(c => c.Id == Guid.Parse(idUser));
                    if (lecture == null) return false;
                    await _lectureRepository.RemoveAsync(lecture);
                    await _lectureRepository.SaveChangesAsync();

                    var lstLectureSpec = _lectuterSpecializedCPRepository.AsQueryable().ToList().Where(c => c.LectuterId == lecture.Id).ToList();
                    await _lectuterSpecializedCPRepository.RemoveRangeAsync(lstLectureSpec);
                    await _lectuterSpecializedCPRepository.SaveChangesAsync();

                    var lstSubjectClass = _subjectClassUPRepository.AsQueryable().ToList().Where(c => c.HomeroomLecturer == lecture.Id).ToList();

                    foreach (var studentInClass in lstSubjectClass)
                    {

                        var lstStudentNews = _NewsRepository.AsQueryable().ToList().Where(c => Guid.Equals(studentInClass.ClassId, c.IdClass) && Guid.Equals(studentInClass.SubjectId, c.IdSubject)).ToList();
                        await _NewsRepository.RemoveRangeAsync(lstStudentNews);
                        await _NewsRepository.SaveChangesAsync();

                        var lstStudentSubmit = _SubmitHomeWorkRepository.AsQueryable().ToList().Where(c => Guid.Equals(studentInClass.ClassId, c.IdClass) && Guid.Equals(studentInClass.SubjectId, c.IdSubject)).ToList();
                        await _SubmitHomeWorkRepository.RemoveRangeAsync(lstStudentSubmit);
                        await _SubmitHomeWorkRepository.SaveChangesAsync();

                        var lstBookMake = _Irepbookmake.AsQueryable().Where(c => Guid.Equals(studentInClass.ClassId, c.IdClass) && Guid.Equals(studentInClass.SubjectId, c.IdSubject)).ToList();
                        await _Irepbookmake.RemoveRangeAsync(lstBookMake);
                        await _Irepbookmake.SaveChangesAsync();
                    }

                    var lstJoinCode = lstSubjectClass.Select(c => c.JoinCode).ToList();
                    var studentClass = _StudentClassUPRepository.AsQueryable().ToList().Where(c => lstJoinCode.Contains(c.JoinCodeAsign)).ToList();
                    await _StudentClassUPRepository.RemoveRangeAsync(studentClass);
                    await _StudentClassUPRepository.SaveChangesAsync();

                    await _subjectClassUPRepository.RemoveRangeAsync(lstSubjectClass);
                    await _subjectClassUPRepository.SaveChangesAsync();

                }
                if (lstRoleUser.Any(c => c == "Student"))
                {
                    var student = _StudentUPRepository.AsQueryable().ToList().FirstOrDefault(c => c.Id == Guid.Parse(idUser));
                    if (student == null) return false;
                    await _StudentUPRepository.RemoveAsync(student);
                    await _StudentUPRepository.SaveChangesAsync();


                    var studentClass = _StudentClassUPRepository.AsQueryable().ToList().Where(c => c.StudentId == student.Id).ToList();
                    await _StudentClassUPRepository.RemoveRangeAsync(studentClass);
                    await _StudentClassUPRepository.SaveChangesAsync();

                    var lstStudentQuiz = _StudentQuizUPRepository.AsQueryable().ToList().Where(c => c.StudentId == student.Id).ToList();
                    await _StudentQuizUPRepository.RemoveRangeAsync(lstStudentQuiz);
                    await _StudentQuizUPRepository.SaveChangesAsync();

                    var lstStudentNews = _NewsRepository.AsQueryable().ToList().Where(c => c.IdUser == student.Id.ToString()).ToList();
                    await _NewsRepository.RemoveRangeAsync(lstStudentNews);
                    await _NewsRepository.SaveChangesAsync();

                    var lstStudentSubmit = _SubmitHomeWorkRepository.AsQueryable().ToList().Where(c => c.IdStudent == student.Id).ToList();
                    await _SubmitHomeWorkRepository.RemoveRangeAsync(lstStudentSubmit);
                    await _SubmitHomeWorkRepository.SaveChangesAsync();
                }
                return true;
            }
            catch
            {

                return false;
            }

        }
    }
}
