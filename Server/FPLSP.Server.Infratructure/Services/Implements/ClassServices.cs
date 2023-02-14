using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class ClassServices : IClassServices
    {
        private readonly IRepository<ClassUp> _IClassrepository;
        private readonly IRepository<LectuterSpecializedUP> _ILectuterSpecializedUPrepository;
        private readonly IRepository<SpecializedUP> _ISpecializedUPrepository;

        private readonly IRepository<SpecializedSubjectUP> _ISpecializedSubjectUPrepository;
        private readonly IRepository<SubjectClassUP> _ISubjectClassUPrepository;
        private readonly IRepository<StudentClassUP> _IStudentClassUPrepository;
        private readonly IRepository<StudentUP> _IStudentUPrepository;
        private readonly IRepository<LecturersCP> _ILecturersCPrepository;
        private readonly IRepository<SubjectUP> _ISubjectUPrepository;


        private readonly IMapper _mapper;
        private Random random = new Random();

        //khai báo và khởi tạo list

        private List<LectuterSpecializedUP> _lstLecturterSpecialized = new List<LectuterSpecializedUP>(); // 

        private List<SpecializedUP> lstSpecialized = new List<SpecializedUP>();
        private List<SpecializedSubjectUP> lstSpecializedSubject = new List<SpecializedSubjectUP>();

        private List<SubjectClassUP> _lstSubjectClass = new List<SubjectClassUP>();


        private List<StudentClassUP> lstStudentClass = new List<StudentClassUP>();
        private List<ClassUp> _lstClassUP = new List<ClassUp>();
        private List<StudentUP> lstStudent = new List<StudentUP>();
        private List<LecturersCP> lstLecturersCP = new List<LecturersCP>();
        private List<SubjectUP> lstSubject = new List<SubjectUP>();


        public ClassServices(IRepository<ClassUp> iClassrepository, IRepository<LectuterSpecializedUP> iLectuterSpecializedUPrepository, IRepository<SpecializedUP> iSpecializedUPrepository, IRepository<SpecializedSubjectUP> iSpecializedSubjectUPrepository, IRepository<SubjectClassUP> iSubjectClassUPrepository, IRepository<StudentClassUP> iStudentClassUPrepository, IRepository<StudentUP> iStudentUPrepository, IRepository<LecturersCP> iLecturersCPrepository, IRepository<SubjectUP> iSubjectUPrepository, IMapper mapper)
        {
            _IClassrepository = iClassrepository;
            _ILectuterSpecializedUPrepository = iLectuterSpecializedUPrepository;
            _ISpecializedUPrepository = iSpecializedUPrepository;
            _ISpecializedSubjectUPrepository = iSpecializedSubjectUPrepository;
            _ISubjectClassUPrepository = iSubjectClassUPrepository;
            _IStudentClassUPrepository = iStudentClassUPrepository;
            _IStudentUPrepository = iStudentUPrepository;
            _ILecturersCPrepository = iLecturersCPrepository;
            _ISubjectUPrepository = iSubjectUPrepository;
            _mapper = mapper;
        }
        public async Task<List<SubjectClassUP>> getSubjectClass()
        {
            return await _ISubjectClassUPrepository.AsQueryable().ToListAsync();
        }
        public async Task<List<ClassUp>> getOnlyClass()
        {
            return await _IClassrepository.AsQueryable().ToListAsync();
        }
        public async Task<bool> CreateClass(CreateClassVM classUp)
        {

            lstSpecializedSubject = _ISpecializedSubjectUPrepository.AsQueryable().ToList();
            _lstLecturterSpecialized = _ILectuterSpecializedUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstSubjectClass = _ISubjectClassUPrepository.AsQueryable().AsNoTracking().ToList();
            lstStudentClass = _IStudentClassUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstClassUP = _IClassrepository.AsQueryable().ToList();
            lstStudent = _IStudentUPrepository.AsQueryable().ToList();
            lstSpecialized = _ISpecializedUPrepository.AsQueryable().ToList();
            //check vùng Giảng Viên- Kì Học
            // kiểm tra xem ở kì học mà người dùng chọn giảng viên đã có dạy ở trong đó chưa
            // nếu chưa có thì phải add giảng viên vào kì đó trước đã
            //còn nếu có rồi thì chỉ việc làm tiếp check các bảng khác

            //Check Vùng Giảng Viên-Chuyên Ngành
            if (_lstLecturterSpecialized.Any(c => c.SpecializedId == classUp.specializedUPId) == false || _lstLecturterSpecialized.Any(c => c.LectuterId == classUp.lecturersCPId) == false)
            {
                if (_lstLecturterSpecialized.Where(c => c.SpecializedId == classUp.specializedUPId).Any(c => c.LectuterId == classUp.lecturersCPId) == false || _lstLecturterSpecialized.Where(c => c.LectuterId == classUp.lecturersCPId).Any(c => c.SpecializedId == classUp.specializedUPId) == false)
                {
                    var lecspec = new LectuterSpecializedUP()
                    {
                        SpecializedId = classUp.specializedUPId,
                        LectuterId = classUp.lecturersCPId,
                        Status = 0
                    };
                    await _ILectuterSpecializedUPrepository.AddAsync(lecspec);
                    await _ILectuterSpecializedUPrepository.SaveChangesAsync();
                }
            }
            // Check Vùng Chuyên Ngành -Môn Học
            if (lstSpecializedSubject.Any(c => c.SpecializedId == classUp.specializedUPId) == false || lstSpecializedSubject.Any(c => c.SubjectId == classUp.SubjectId) == false)
            {
                if (lstSpecializedSubject.Where(c => c.SpecializedId == classUp.specializedUPId).Any(c => c.SubjectId == classUp.SubjectId) == false || lstSpecializedSubject.Where(c => c.SubjectId == classUp.SubjectId).Any(c => c.SpecializedId == classUp.specializedUPId) == false)
                {
                    var ssub = new SpecializedSubjectUP()
                    {
                        SpecializedId = classUp.specializedUPId,
                        SubjectId = classUp.SubjectId,
                        Status = 0
                    };
                    await _ISpecializedSubjectUPrepository.AddAsync(ssub);
                    await _ISpecializedSubjectUPrepository.SaveChangesAsync();
                }
            }

            ////phần add cơ bản lớp học vào bảng lớp học

            if (_lstClassUP.Any(c => c.Id == classUp.Id) == false)
            {
                var createclass = new ClassUp()
                {

                    Id = classUp.Id,
                    ClassroomName = classUp.ClassroomName,

                    Status = classUp.Status,
                    Building = string.Empty,

                };
                await _IClassrepository.AddAsync(createclass);
                await _IClassrepository.SaveChangesAsync();
            }

            //Check Vùng  Môn Học-Lớp Học( MAIN TABLE)

            var subclass = new SubjectClassUP()
            {
                ClassId = classUp.Id,
                SubjectId = classUp.SubjectId,
                Status = 0,
                SpecializedOfClass = Guid.Parse(classUp.specializedUPId.ToString()),
                JoinCode = classUp.JoinCode,
                HomeroomLecturer = Guid.Parse(classUp.lecturersCPId.ToString())
            };
            await _ISubjectClassUPrepository.AddAsync(subclass);
            await _ISubjectClassUPrepository.SaveChangesAsync();


            ////tiếp đến add vào bảng quan hệ nhiều nhiều giữa lớp học và sinh viên
            ////và check nếu chưa add sinh viên ngay tại thời điểm add lớp thì có thể để trạng thái của lớp học là 2 là chưa đủ sinh viên
            if (classUp.ListStudent.Count() > 0)
            {
                foreach (var x in classUp.ListStudent)
                {
                    var sc = new StudentClassUP()
                    {
                        ClassId = classUp.Id,
                        StudentId = x,
                        Status = 0,
                        JoinCodeAsign = classUp.JoinCode,
                        StatusOfStudent = 0
                    };
                    await _IStudentClassUPrepository.AddAsync(sc);
                    await _IStudentClassUPrepository.SaveChangesAsync();
                }
            }
            return true;
        }
        public async Task<bool> UpdateClass(string Id, CreateClassVM createClassVM)
        {

            lstSpecializedSubject = _ISpecializedSubjectUPrepository.AsQueryable().ToList();
            _lstLecturterSpecialized = _ILectuterSpecializedUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstSubjectClass = _ISubjectClassUPrepository.AsQueryable().AsNoTracking().ToList();
            lstStudentClass = _IStudentClassUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstClassUP = _IClassrepository.AsQueryable().ToList();
            lstStudent = _IStudentUPrepository.AsQueryable().ToList();
            lstSpecialized = _ISpecializedUPrepository.AsQueryable().ToList();
            //check vùng Giảng Viên- Kì Học
            // kiểm tra xem ở kì học mà người dùng chọn giảng viên đã có dạy ở trong đó chưa
            // nếu chưa có thì phải add giảng viên vào kì đó trước đã
            //còn nếu có rồi thì chỉ việc làm tiếp check các bảng khác

            var finalcheck = _lstSubjectClass.FirstOrDefault(c => c.JoinCode == createClassVM.JoinCode);
            var finalcheckforstudent = lstStudentClass.Where(c => c.JoinCodeAsign == createClassVM.JoinCode).Select(c => c.StudentId).ToList();

            ////Check Vùng Giảng Viên-Chuyên Ngành
            if (createClassVM.SubjectId != finalcheck.SubjectId && _lstSubjectClass.Any(c => c.SubjectId == createClassVM.SubjectId && c.JoinCode == createClassVM.JoinCode))
            {
                return false;
            }
            if (_lstLecturterSpecialized.Any(c => c.SpecializedId == createClassVM.specializedUPId && c.LectuterId == createClassVM.lecturersCPId) == false)
            {

                foreach (var x in _lstLecturterSpecialized.Where(c => c.SpecializedId == finalcheck.SpecializedOfClass && c.LectuterId == finalcheck.HomeroomLecturer))
                {
                    _ILectuterSpecializedUPrepository.RemoveAsync(x);
                    await _ILectuterSpecializedUPrepository.SaveChangesAsync();
                }
                var newlecspec = new LectuterSpecializedUP()
                {

                    LectuterId = createClassVM.lecturersCPId,
                    SpecializedId = createClassVM.specializedUPId,
                    Status = 0
                };
                await _ILectuterSpecializedUPrepository.AddAsync(newlecspec);
                await _ILectuterSpecializedUPrepository.SaveChangesAsync();
            }

            //// Check Vùng Chuyên Ngành -Môn Học
            if (lstSpecializedSubject.Any(c => c.SpecializedId == createClassVM.specializedUPId && c.SubjectId == createClassVM.SubjectId) == false)
            {
                foreach (var x in lstSpecializedSubject.Where(c => c.SubjectId == finalcheck.SubjectId && c.SpecializedId == finalcheck.SpecializedOfClass))
                {

                    _ISpecializedSubjectUPrepository.RemoveAsync(x);
                    await _ISpecializedSubjectUPrepository.SaveChangesAsync();
                }
                var newspecsub = new SpecializedSubjectUP()
                {
                    SubjectId = createClassVM.SubjectId,
                    SpecializedId = createClassVM.specializedUPId,
                    Status = 0
                };
                await _ISpecializedSubjectUPrepository.AddAsync(newspecsub);
                await _ISpecializedSubjectUPrepository.SaveChangesAsync();
            }

            var updateclass = _mapper.Map<ClassUp>(createClassVM);

            await _IClassrepository.UpdateAsync(updateclass);
            await _IClassrepository.SaveChangesAsync();
            foreach (var x in _lstSubjectClass.Where(c => c.JoinCode == createClassVM.JoinCode))
            {

                _ISubjectClassUPrepository.RemoveAsync(x);
                await _ISubjectClassUPrepository.SaveChangesAsync();
            }
            var newclass = new SubjectClassUP()
            {
                HomeroomLecturer = Guid.Parse(createClassVM.lecturersCPId.ToString()),
                SubjectId = createClassVM.SubjectId,
                SpecializedOfClass = Guid.Parse(createClassVM.specializedUPId.ToString()),
                ClassId = createClassVM.Id,
                JoinCode = createClassVM.JoinCode,
                Status = createClassVM.Status

            };
            //so sánh 2 list nếu không khác nhau thì không cho add sinh viên
            if (finalcheckforstudent.Union(createClassVM.ListStudent).Except(finalcheckforstudent.Intersect(createClassVM.ListStudent)).Count() != 0)
            {
                var listchecker = lstStudentClass.Where(c => c.JoinCodeAsign == createClassVM.JoinCode).ToList();
                foreach (var student in listchecker)
                {
                    _IStudentClassUPrepository.RemoveAsync(student);
                    await _IStudentClassUPrepository.SaveChangesAsync();
                }
                foreach (var st in createClassVM.ListStudent)
                {

                    var newst = new StudentClassUP()
                    {
                        StudentId = st,
                        ClassId = createClassVM.Id,
                        JoinCodeAsign = createClassVM.JoinCode,
                        Status = 0,
                        StatusOfStudent = 0,
                    };
                    await _IStudentClassUPrepository.AddAsync(newst);
                    await _IStudentClassUPrepository.SaveChangesAsync();

                }
            }

            await _ISubjectClassUPrepository.AddAsync(newclass);
            await _ISubjectClassUPrepository.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteClass(string Id)
        {
            _lstSubjectClass = _ISubjectClassUPrepository.AsQueryable().Where(c => c.JoinCode == Id).ToList();
            foreach (var x in _lstSubjectClass)
            {
                x.Status = 1;
                _ISubjectClassUPrepository.UpdateAsync(x);
                await _ISubjectClassUPrepository.SaveChangesAsync();
            }
            return true;
        }

        public List<ClassUPViewModel> GetAllClassesAsync()
        {
            lstLecturersCP = _ILecturersCPrepository.AsQueryable().ToList();
            lstSpecialized = _ISpecializedUPrepository.AsQueryable().ToList();
            _lstLecturterSpecialized = _ILectuterSpecializedUPrepository.AsQueryable().ToList();
            _lstClassUP = _IClassrepository.AsQueryable().ToList();
            lstSpecializedSubject = _ISpecializedSubjectUPrepository.AsQueryable().ToList();
            lstSubject = _ISubjectUPrepository.AsQueryable().ToList();
            _lstSubjectClass = _ISubjectClassUPrepository.AsQueryable().ToList();
            lstStudentClass = _IStudentClassUPrepository.AsQueryable().ToList();

            var FinalList = (from
                              subcl in _lstSubjectClass
                             where subcl.Status != 1
                             select new ClassUPViewModel()
                             {

                                 Id = Guid.Parse(subcl.ClassId.ToString()),
                                 SubjectName = lstSubject.Where(c => c.Id == subcl.SubjectId).Select(c => c.SubjectName).FirstOrDefault(),
                                 ClassroomName = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.ClassroomName).FirstOrDefault(),

                                 Building = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.Building).FirstOrDefault(),


                                 SubjectId = subcl.SubjectId,

                                 Status = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.Status).FirstOrDefault(),
                                 HomeroomLecturerId = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.Id).FirstOrDefault(),
                                 HomeroomLecturer = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.LecturersName).FirstOrDefault(),
                                 HomeroomLecturerEmail = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.Email).FirstOrDefault(),
                                 HomeroomLecturerPhoneNumber = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.PhoneNumber).FirstOrDefault(),
                                 SpecializedId = subcl.SpecializedOfClass,
                                 ActualNumberOfStudent = lstStudentClass.Count(c => c.JoinCodeAsign == subcl.JoinCode),
                                 JoinCode = _lstSubjectClass.Where(c => c.JoinCode == subcl.JoinCode).Select(c => c.JoinCode).FirstOrDefault(),
                                 subjectUP = _lstSubjectClass.Where(c => c.JoinCode == subcl.JoinCode).Select(c => c.SubjectId).ToList(),
                                 ListStudent = lstStudentClass.Where(c => c.JoinCodeAsign == subcl.JoinCode).Select(c => c.StudentId).ToList(),
                                 StudentAmount = _lstSubjectClass.Where(c => c.JoinCode == subcl.JoinCode).Select(c => c.StudentAmount).FirstOrDefault(),
                             }).ToList();
            return FinalList.Where(x => x.Status == 0).ToList();
        }

        public async Task<PageList<ClassUPViewModel>> GetClassList(PagingParameters pagingParameters)
        {
            var ClassCollection = _IClassrepository.AsQueryable().ProjectTo<ClassUPViewModel>(_mapper.ConfigurationProvider);

            var data = await ClassCollection.Skip((pagingParameters.PageNumber - 1) * pagingParameters.PageSize).Take(pagingParameters.PageSize).ToListAsync();
            return new PageList<ClassUPViewModel>(data.Where(c => c.Status != 1).ToList(), data.Where(c => c.Status != 1).ToList().Count, pagingParameters.PageNumber, pagingParameters.PageSize);
        }

        public async Task<CreateClassVM> GetClassListById(string JoinCode)
        {
            lstLecturersCP = _ILecturersCPrepository.AsQueryable().AsNoTracking().ToList();
            lstSpecialized = _ISpecializedUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstLecturterSpecialized = _ILectuterSpecializedUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstClassUP = _IClassrepository.AsQueryable().AsNoTracking().ToList();
            lstSpecializedSubject = _ISpecializedSubjectUPrepository.AsQueryable().AsNoTracking().ToList();
            lstSubject = _ISubjectUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstSubjectClass = _ISubjectClassUPrepository.AsQueryable().AsNoTracking().ToList();
            lstStudentClass = _IStudentClassUPrepository.AsQueryable().AsNoTracking().ToList();


            var FinalList = (from subcl in _lstSubjectClass
                             where subcl.JoinCode == JoinCode && subcl.Status != 1
                             select new CreateClassVM()
                             {
                                 Id = Guid.Parse(subcl.ClassId.ToString()),
                                 SubjectName = lstSubject.Where(c => c.Id == subcl.SubjectId).Select(c => c.SubjectName).FirstOrDefault(),
                                 ClassroomName = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.ClassroomName).FirstOrDefault(),

                                 Building = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.Building).FirstOrDefault(),


                                 SubjectId = Guid.Parse(subcl.SubjectId.ToString()),

                                 Status = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.Status).FirstOrDefault(),
                                 specializedUPId = subcl.SpecializedOfClass,
                                 HomeroomLecturer = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.LecturersName).FirstOrDefault(),
                                 lecturersCPId = subcl.HomeroomLecturer,
                                 HomeroomLecturerId = subcl.HomeroomLecturer,
                                 ActualNumberOfStudent = lstStudentClass.Count(c => c.JoinCodeAsign == subcl.JoinCode),
                                 JoinCode = _lstSubjectClass.Where(c => c.JoinCode == subcl.JoinCode.ToString()).Select(c => c.JoinCode).FirstOrDefault(),
                                 subjectUP = _lstSubjectClass.Where(c => c.ClassId == subcl.ClassId).Select(c => c.SubjectId).ToList(),

                                 ListStudent = lstStudentClass.Where(c => c.JoinCodeAsign == subcl.JoinCode).Select(c => c.StudentId).ToList(),
                                 SpecializedName = lstSpecialized.Where(c => c.Id == subcl.SpecializedOfClass).Select(c => c.SpecializationName).FirstOrDefault()
                             }).ToList().FirstOrDefault();

            if (FinalList == null)
            {
                FinalList = new CreateClassVM()
                {
                    Id = Guid.NewGuid(),
                    ClassroomName = string.Empty,
                    ClassroomCode = string.Empty,
                    Building = string.Empty,
                    StudentAmount = 0,
                    DateCreated = DateTime.Now,
                    HomeroomLecturer = string.Empty,
                    DateStarted = DateTime.Now,
                    EndDate = DateTime.Now,
                    Status = 0,
                    JoinCode = string.Empty,
                    SubjectId = Guid.Empty,
                    HomeroomLecturerId = Guid.Empty,
                    lecturersCPId = Guid.Empty,
                    ListStudent = new List<Guid?>(),
                    specializedUPId = Guid.Empty,
                    SpecializedName = String.Empty,
                    ActualNumberOfStudent = 0,
                    SubjectName = string.Empty,
                    subjectUP = new List<Guid?>()

                };
            }

            return FinalList;
        }

        public Task<PageList<ClassUp>> GetClassSeacrch(ClassSearchDTO classSearchDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<ClassUPViewModel>> GetClassMapper()
        {
            var ClassCollection = _IClassrepository.AsQueryable().ProjectTo<ClassUPViewModel>(_mapper.ConfigurationProvider);
            return ClassCollection;
        }

        public async Task<PageList<ClassUPViewModel>> GetListClassDetail(ClassSearchDTO classSearchDTO)
        {
            lstLecturersCP = _ILecturersCPrepository.AsQueryable().AsNoTracking().ToList();
            lstSpecialized = _ISpecializedUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstLecturterSpecialized = _ILectuterSpecializedUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstClassUP = _IClassrepository.AsQueryable().AsNoTracking().ToList();
            lstSpecializedSubject = _ISpecializedSubjectUPrepository.AsQueryable().AsNoTracking().ToList();
            lstSubject = _ISubjectUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstSubjectClass = _ISubjectClassUPrepository.AsQueryable().AsNoTracking().ToList();
            lstStudentClass = _IStudentClassUPrepository.AsQueryable().AsNoTracking().ToList();

            var FinalList = (from
                              subcl in _lstSubjectClass
                             where subcl.Status != 1
                             select new ClassUPViewModel()
                             {

                                 Id = Guid.Parse(subcl.ClassId.ToString()),
                                 SubjectName = lstSubject.Where(c => c.Id == subcl.SubjectId).Select(c => c.SubjectName).FirstOrDefault(),
                                 ClassroomName = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.ClassroomName).FirstOrDefault(),

                                 Building = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.Building).FirstOrDefault(),


                                 SubjectId = subcl.SubjectId,

                                 Status = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.Status).FirstOrDefault(),
                                 HomeroomLecturerId = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.Id).FirstOrDefault(),
                                 HomeroomLecturer = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.LecturersName).FirstOrDefault(),
                                 HomeroomLecturerEmail = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.Email).FirstOrDefault(),
                                 HomeroomLecturerPhoneNumber = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.PhoneNumber).FirstOrDefault(),
                                 SpecializedId = subcl.SpecializedOfClass,
                                 ActualNumberOfStudent = lstStudentClass.Count(c => c.JoinCodeAsign == subcl.JoinCode),
                                 JoinCode = _lstSubjectClass.Where(c => c.JoinCode == subcl.JoinCode).Select(c => c.JoinCode).FirstOrDefault(),
                                 subjectUP = _lstSubjectClass.Where(c => c.JoinCode == subcl.JoinCode).Select(c => c.SubjectId).ToList(),
                                 ListStudent = lstStudentClass.Where(c => c.JoinCodeAsign == subcl.JoinCode).Select(c => c.StudentId).ToList(),
                                 StudentAmount = _lstSubjectClass.Where(c => c.JoinCode == subcl.JoinCode).Select(c => c.StudentAmount).FirstOrDefault(),
                             }).ToList();

            if (!string.IsNullOrEmpty(classSearchDTO.ClassroomName))
            {
                FinalList = FinalList.Where(c => c.ClassroomName.ToLower().Contains(classSearchDTO.ClassroomName.ToLower())).ToList();
            }

            if (classSearchDTO.specializedUPId.HasValue)
            {
                FinalList = FinalList.Where(c => c.SpecializedId == Guid.Parse(classSearchDTO.specializedUPId.ToString())).ToList();
            }
            if (classSearchDTO.LecturterId.HasValue)
            {
                FinalList = FinalList.Where(c => c.HomeroomLecturerId == Guid.Parse(classSearchDTO.LecturterId.ToString())).ToList();
            }
            if (classSearchDTO.SubjectId.HasValue)
            {
                FinalList = FinalList.Where(c => c.subjectUP.Any(x => x == classSearchDTO.SubjectId)).ToList();
            }
            if (!string.IsNullOrEmpty(classSearchDTO.JoinCode))
            {
                FinalList = FinalList.Where(c => c.JoinCode == classSearchDTO.JoinCode).ToList();
            }
            var data = FinalList.Where(c => c.Status != 1).Skip((classSearchDTO.PageNumber - 1) * classSearchDTO.PageSize).Take(classSearchDTO.PageSize).ToList();
            return new PageList<ClassUPViewModel>(data, FinalList.Count, classSearchDTO.PageNumber, classSearchDTO.PageSize);
        }
        public async Task<List<ClassUPViewModel>> GetAllClass(Guid idstudent)
        {
            lstLecturersCP = _ILecturersCPrepository.AsQueryable().AsNoTracking().ToList();
            lstSpecialized = _ISpecializedUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstLecturterSpecialized = _ILectuterSpecializedUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstClassUP = _IClassrepository.AsQueryable().AsNoTracking().ToList();
            lstSpecializedSubject = _ISpecializedSubjectUPrepository.AsQueryable().AsNoTracking().ToList();
            lstSubject = _ISubjectUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstSubjectClass = _ISubjectClassUPrepository.AsQueryable().AsNoTracking().ToList();
            lstStudentClass = _IStudentClassUPrepository.AsQueryable().AsNoTracking().ToList();

            var FinalList = (from
                              subcl in _lstSubjectClass
                             where subcl.Status != 1
                             select new ClassUPViewModel()
                             {

                                 Id = Guid.Parse(subcl.ClassId.ToString()),
                                 SubjectName = lstSubject.Where(c => c.Id == subcl.SubjectId).Select(c => c.SubjectName).FirstOrDefault(),
                                 ClassroomName = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.ClassroomName).FirstOrDefault(),

                                 Building = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.Building).FirstOrDefault(),


                                 SubjectId = subcl.SubjectId,

                                 Status = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.Status).FirstOrDefault(),
                                 HomeroomLecturerId = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.Id).FirstOrDefault(),
                                 HomeroomLecturer = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.LecturersName).FirstOrDefault(),
                                 HomeroomLecturerEmail = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.Email).FirstOrDefault(),
                                 HomeroomLecturerPhoneNumber = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.PhoneNumber).FirstOrDefault(),
                                 SpecializedId = subcl.SpecializedOfClass,
                                 ActualNumberOfStudent = lstStudentClass.Count(c => c.JoinCodeAsign == subcl.JoinCode),
                                 JoinCode = _lstSubjectClass.Where(c => c.JoinCode == subcl.JoinCode).Select(c => c.JoinCode).FirstOrDefault(),
                                 subjectUP = _lstSubjectClass.Where(c => c.JoinCode == subcl.JoinCode).Select(c => c.SubjectId).ToList(),
                                 ListStudent = lstStudentClass.Where(c => c.JoinCodeAsign == subcl.JoinCode).Select(c => c.StudentId).ToList(),
                                 StudentAmount = _lstSubjectClass.Where(c => c.JoinCode == subcl.JoinCode).Select(c => c.StudentAmount).FirstOrDefault(),
                             }).Where(c => c.ListStudent.Any(c => c == idstudent)).ToList();


            return FinalList;
        }
        public async Task<List<ClassUPViewModel>> GetListClassDetailForLec(string emaillec)
        {

            lstLecturersCP = _ILecturersCPrepository.AsQueryable().AsNoTracking().ToList();
            lstSpecialized = _ISpecializedUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstLecturterSpecialized = _ILectuterSpecializedUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstClassUP = _IClassrepository.AsQueryable().AsNoTracking().ToList();
            lstSpecializedSubject = _ISpecializedSubjectUPrepository.AsQueryable().AsNoTracking().ToList();
            lstSubject = _ISubjectUPrepository.AsQueryable().AsNoTracking().ToList();
            _lstSubjectClass = _ISubjectClassUPrepository.AsQueryable().AsNoTracking().ToList();
            lstStudentClass = _IStudentClassUPrepository.AsQueryable().AsNoTracking().ToList();
            //leanthuyen0812002@gmail.com

            var idlec = lstLecturersCP.Where(c => c.Email == emaillec.Replace("+", "")).Select(c => c.Id).FirstOrDefault();
            var FinalList = (from
                                  subcl in _lstSubjectClass
                             where subcl.Status != 1
                             select new ClassUPViewModel()
                             {

                                 Id = Guid.Parse(subcl.ClassId.ToString()),
                                 SubjectName = lstSubject.Where(c => c.Id == subcl.SubjectId).Select(c => c.SubjectName).FirstOrDefault(),
                                 ClassroomName = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.ClassroomName).FirstOrDefault(),

                                 Building = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.Building).FirstOrDefault(),

                                 SubjectId = subcl.SubjectId,

                                 Status = _lstClassUP.Where(c => c.Id == Guid.Parse(subcl.ClassId.ToString())).Select(c => c.Status).FirstOrDefault(),
                                 HomeroomLecturerId = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.Id).FirstOrDefault(),
                                 HomeroomLecturer = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.LecturersName).FirstOrDefault(),
                                 HomeroomLecturerEmail = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.Email).FirstOrDefault(),
                                 HomeroomLecturerPhoneNumber = lstLecturersCP.Where(c => c.Id == subcl.HomeroomLecturer).Select(c => c.PhoneNumber).FirstOrDefault(),
                                 SpecializedId = subcl.SpecializedOfClass,
                                 ActualNumberOfStudent = lstStudentClass.Count(c => c.JoinCodeAsign == subcl.JoinCode),
                                 JoinCode = _lstSubjectClass.Where(c => c.JoinCode == subcl.JoinCode).Select(c => c.JoinCode).FirstOrDefault(),
                                 subjectUP = _lstSubjectClass.Where(c => c.JoinCode == subcl.JoinCode).Select(c => c.SubjectId).ToList(),
                                 ListStudent = lstStudentClass.Where(c => c.JoinCodeAsign == subcl.JoinCode).Select(c => c.StudentId).ToList(),
                                 StudentAmount = _lstSubjectClass.Where(c => c.JoinCode == subcl.JoinCode).Select(c => c.StudentAmount).FirstOrDefault(),

                             }).Where(c => c.HomeroomLecturerId == idlec).ToList();



            return FinalList.ToList();
        }

        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public async Task<CreateClassVM> ClassCreater()
        {
            var _lstClassUP = await _IClassrepository.AsQueryable().ToListAsync();
            string codeString = "FPT0";
            if (_lstClassUP.Count() != 0)
            {
                //codeString = "FPT" + Convert.ToString(_lstClassUP.Max(c => Convert.ToInt32(c.ClassroomCode.Substring(3, c.ClassroomCode.Length - 3)) + 1));
            }

            var FinalClass =
                               new CreateClassVM()
                               {
                                   Id = Guid.NewGuid(),
                                   ClassroomName = string.Empty,
                                   ClassroomCode = codeString,
                                   Building = string.Empty,
                                   StudentAmount = 0,
                                   DateCreated = DateTime.Now,
                                   HomeroomLecturer = string.Empty,
                                   DateStarted = DateTime.Now,
                                   EndDate = DateTime.Now,
                                   Status = 0,
                                   JoinCode = RandomString(10),
                                   SubjectId = Guid.Empty,
                                   HomeroomLecturerId = Guid.Empty,
                                   lecturersCPId = Guid.Empty,
                                   ListStudent = new List<Guid?>(),
                                   specializedUPId = Guid.Empty,
                                   SpecializedName = String.Empty,
                                   ActualNumberOfStudent = 0,
                                   SubjectName = string.Empty,

                               };
            return FinalClass;
        }
    }
}
