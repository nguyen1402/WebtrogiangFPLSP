using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Dtos.StudentStatisticVM;
using FPLSP.Server.Domain.Dtos.StudentUPDtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.StudentStatistics;
using FPLSP.Server.Infrastructure.ViewModels.StudentsUPVm;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Text.RegularExpressions;

namespace FPLSP.Server.Infrastructure.Services.Implements;
public class StudentUpServices : IStudentUpServices
{
    private readonly IRepository<StudentUP> _studentRepository;
    private readonly IRepository<StudentQuizUP> _studentuizRepository;
    private readonly IRepository<QuizUP> _quizRepository;
    private readonly IRepository<SubjectUP> _subRepository;
    private readonly IRepository<SubjectClassUP> _subclassRepository;
    private readonly IRepository<ClassUp> _classRepository;
    private readonly IRepository<StudentClassUP> _studentclassRes;
    private readonly IRepository<SubmitHomeWork> _submitHomeWork;
    //private readonly IRepository<HomeWork> _homeWork;
    private readonly IRepository<LessonUP> _lesson;
    private readonly IMapper _mapper;

    public StudentUpServices(IRepository<StudentUP> studentRepository, IMapper mapper
        , IRepository<StudentQuizUP> studentuizRepository
        , IRepository<QuizUP> quizRepository
        , IRepository<SubjectUP> subRepository
        , IRepository<StudentClassUP> studentclassRes
        , IRepository<SubmitHomeWork> submitHomeWork
        , IRepository<ClassUp> classRepository
        , IRepository<SubjectClassUP> subclassRepository, IRepository<LessonUP> lesson)
    {
        _studentRepository = studentRepository ?? throw new ArgumentNullException(nameof(_studentRepository));
        _studentuizRepository = studentuizRepository ?? throw new ArgumentNullException(nameof(_studentuizRepository));
        _quizRepository = quizRepository ?? throw new ArgumentNullException(nameof(_quizRepository));
        _subRepository = subRepository ?? throw new ArgumentNullException(nameof(_subRepository));
        _studentclassRes = studentclassRes ?? throw new ArgumentNullException(nameof(_studentclassRes));
        _submitHomeWork = submitHomeWork ?? throw new ArgumentNullException(nameof(_submitHomeWork));
        _mapper = mapper;
        _classRepository = classRepository ?? throw new ArgumentNullException(nameof(classRepository));
        _subclassRepository = subclassRepository ?? throw new ArgumentNullException(nameof(subclassRepository));
        //_homeWork = homeWork ?? throw new ArgumentNullException(nameof(homeWork));
        _lesson = lesson ?? throw new ArgumentNullException(nameof(lesson));
    }
    public async Task<StudentUP> Delete(Guid id)
    {
        var exam = _studentRepository.AsQueryable().FirstOrDefault(c => Guid.Equals(id, c.Id));
        await _studentRepository.RemoveAsync(exam);
        await _studentRepository.SaveChangesAsync();
        return exam;
    }

    public async Task<List<StudentUP>> DeleteRange(List<Guid> _lstId)
    {
        var _lisremoveStudents = _studentRepository.AsQueryable().Where(c => _lstId.Contains(c.Id));
        await _studentRepository.RemoveRangeAsync(_lisremoveStudents);
        await _studentRepository.SaveChangesAsync();
        return _lisremoveStudents.ToList();
    }

    public async Task<int> CreateStudentUP(StudentUPCreateVm student)
    {
        string id = GetMaxId();
        var temp = "00000";
        var value = Convert.ToString(Convert.ToInt32(id) + 1);
        if ((temp.Length - value.Length) <= 0) { temp = value; }
        else { temp = temp.Substring(0, temp.Length - value.Length) + value; }

        string ids = "PH" + temp;
        var newstudent = new StudentUP()
        {
            Id = Guid.NewGuid(),
            StudentCode = ids,
            StudentName = student.StudentName,
            Gender = student.Gender,
            DateOfBirth = student.DateOfBirth,
            Address = student.Address,
            Email = student.Email,
            Password = student.Password,
            PhoneNumber = student.PhoneNumber,
            IdentityCardNumber = student.IdentityCardNumber,
            IssuedOn = student.IssuedOn,
            Ethnic = student.Ethnic,
            ImageUrl = student.ImageUrl,
            Description = student.Description,
            FathersName = student.FathersName,
            MotherName = student.MotherName,
            HomeTown = student.HomeTown,
            Status = student.Status,
            IsDeleted = false,
        };
        var studentcode = _studentRepository.AsQueryable().Any(c => String.Equals(newstudent.StudentCode, c.StudentCode));
        if (studentcode) { return 0; }

        await _studentRepository.AddAsync(newstudent);
        await _studentRepository.SaveChangesAsync();

        return 1;
    }

    public async Task<List<StudentUP>> GetAllStudentUPAsync()
    {
        var result = _studentRepository.AsQueryable().Where(c => Boolean.Equals(false, c.IsDeleted)).ToList();
        return result;
    }

    public string GetMaxId()
    {
        if (_studentRepository.AsQueryable().Count() == 0)
        {
            return "000000";
        }
        else
        {
            var result = _studentRepository.AsQueryable().Max(p => (p.StudentCode.Substring(2, (p.StudentCode.Length - 2))));
            return result.ToString();
        }

    }

    public async Task<StudentUP> GetStudentUPbyId(Guid id)
    {
        var result = _studentRepository.AsQueryable().ToList().FirstOrDefault(c => Guid.Equals(id, c.Id));
        return result;
    }

    public async Task<StudentUP> GetStudentUPMaxId()
    {
        var result = new StudentUP();
        string id = GetMaxId();
        if (Equals("000000", id))
        {
            result.StudentCode = id;
        }
        else
        {
            result = _studentRepository.AsQueryable().FirstOrDefault(p => string.Equals(p.StudentCode.Substring(2, (p.StudentCode.Length - 2)), id));
        }
        return result;
    }

    public async Task<PageList<StudentUP>> GetStudentList(StudentUPListSearchVm student)
    {
        var result = _studentRepository.AsQueryable().Where(c => Boolean.Equals(false, c.IsDeleted));
        if (student.Status != null)
        {
            result = result.Where(x => x.Status == Convert.ToInt32(student.Status));
        }
        if (student.NameStudent != null)
        {
            result = result.Where(x => x.StudentName.ToLower().Contains(student.NameStudent.ToLower()) || x.StudentCode.ToLower().Contains(student.NameStudent.ToLower()));
        }
        var count = await result.CountAsync();
        var data = await result.Skip((student.PageNumber - 1) * student.PageSize).Take(student.PageSize).ToListAsync();
        return new PageList<StudentUP>(data, count, student.PageNumber, student.PageSize);
    }

    public async Task<IQueryable<StudentUpDto>> GetStudentsAsync()
    {

        var studentCollection = _studentRepository.AsQueryable().ProjectTo<StudentUpDto>(_mapper.ConfigurationProvider);
        return await Task.FromResult(studentCollection);
    }

    public async Task<int> UpdateStudentUP(Guid id, StudentUpdateVM student)
    {
        var studentdb = _studentRepository.AsQueryable().FirstOrDefault(c => Equals(id, c.Id));
        studentdb.StudentName = student.StudentName;
        studentdb.Gender = student.Gender;
        studentdb.DateOfBirth = student.DateOfBirth;
        studentdb.Email = student.Email;
        studentdb.Password = student.Password;
        studentdb.PhoneNumber = student.PhoneNumber;
        studentdb.Address = student.Address;
        studentdb.IdentityCardNumber = student.IdentityCardNumber;
        studentdb.IssuedOn = student.IssuedOn;
        studentdb.Ethnic = student.Ethnic;
        studentdb.ImageUrl = student.ImageUrl;
        studentdb.Description = student.Description;
        studentdb.FathersName = student.FathersName;
        studentdb.MotherName = student.MotherName;
        studentdb.HomeTown = student.HomeTown;
        studentdb.Status = student.Status;
        studentdb.IsDeleted = student.IsDelete;
        await _studentRepository.UpdateAsync(studentdb);
        await _studentRepository.SaveChangesAsync();
        return 1;
    }

    public async Task<Thongtinlop> Thongtinlop(Guid id, Guid idsubject)
    {
        var joincode = _subclassRepository.AsQueryable().Where(c => c.ClassId == id && c.SubjectId == idsubject).Select(c => c.JoinCode).FirstOrDefault();
        var _lstStudentIDInClass = await _studentclassRes.AsQueryable().Where(c => c.ClassId == id && c.JoinCodeAsign == joincode).Select(c => c.StudentId).ToListAsync();

        // list Sinh viên
        var _lstStudentInClass = await _studentRepository.AsQueryable().Where(c => _lstStudentIDInClass.Contains(c.Id)).ToListAsync();


        ///_lstLessonIDInClass=> List Id Baihoc.
        var _lstLessonIDInClass = await _lesson.AsQueryable().OrderBy(c => c.IndexOfLesson).Where(c => c.SubjectId == idsubject).Select(c => c.Id).ToListAsync();
        var listgui = new List<Guid?>();
        foreach (var iteam in _lstLessonIDInClass)
        {
            listgui.Add(iteam);
        }
        ///_lstQuizIDInClass=> List Id Quiz.
        var _lstQuizIDInClass = await _quizRepository.AsQueryable().OrderBy(c => c.QuizName).Where(c => c.SubjectId == idsubject).Select(c => c.Id).ToListAsync();


        var listquiz = new List<Guid?>();
        foreach (var iteam in _lstQuizIDInClass)
        {
            listquiz.Add(iteam);
        }


        var _lislinkStudent = _submitHomeWork.AsQueryable().ToList().Where(c => _lstStudentIDInClass.Contains(c.IdStudent) && c.IdClass == id && c.IdSubject == idsubject)
            .Join(_subRepository.AsQueryable().ToList(), studentsumit => studentsumit.IdSubject, sub => sub.Id, (studentsumit, sub) => new
            {
                SubjectName = sub.SubjectName,
                StudentId = studentsumit.IdStudent,
                SubmitLink = studentsumit.SubmitLink,
                StatusSubmitHomework = studentsumit.Status,
            });

        //var donea = _lislinkStudent.Any(c=>c.StatusSubmitHomework == 0)
        var done = (
            from a in _lislinkStudent
            group a by a.StudentId into g
            select new
            {
                Grade = g.Key,
                Done = g.Count(),
                stutus = _lislinkStudent.Where(c => c.StudentId == g.Key).Any(c => c.StatusSubmitHomework == 0)
            }).ToList();
        int CountStatus = 0;
        int CountStatusDone = 0;
        foreach (var item in done)
        {
            if (item.stutus)
            {
                CountStatus++;
            }
            else { CountStatusDone++; }
        }


        int countbt = 0;
        var lssummit = _submitHomeWork.AsQueryable().ToList().Where(c => c.IdClass == id && c.IdSubject == idsubject).ToList().Count();
        if (lssummit > 0)
        {
            countbt = lssummit / _lstStudentInClass.Count();
        }
        else
        {
            countbt = 0;
        }

        var querry = from c in _subRepository.AsQueryable().ToList().Where(p => p.IsDeleted == false)
                     join ct1 in _subclassRepository.AsQueryable().ToList() on c.Id equals ct1.SubjectId
                     join ct2 in _classRepository.AsQueryable().ToList() on ct1.ClassId equals ct2.Id
                     where ct1.ClassId == id && ct1.SubjectId == idsubject
                     select new { c, ct1, ct2 };
        var _thongtinlop = querry.Select(x => new Thongtinlop()
        {
            idClass = x.ct2.Id,
            NameClass = x.ct2.ClassroomName,
            NameMon = x.c.SubjectName,
            NgayTaoLop = x.ct1.DateCreated,
            CountHomework = countbt,
            CountDonSubmit = CountStatus,
            CountSubmit = CountStatusDone,
            CountLessson = listgui.Count(),
            CountQuiz = listquiz.Count(),
            Listidlesson = listgui,
            Listidquiz = listquiz,
        }).FirstOrDefault();

        return _thongtinlop;
    }

    public async Task<PageList<StudentStatisticsDtos>> StudentStatisticsDtos(Guid idsubject, Guid idclass, StudentStatisticListSearch studentParameters)
    {

        var result = new List<StudentStatisticsDtos>();
        var test = new List<StudentStatisticsDtos>();

        #region lấy lits liên quan đến Sinh viên.
        ///_lstStudentIDInClas=> List Id Sinh viên.
        var joicode = _subclassRepository.AsQueryable().ToList().Where(c => c.ClassId == idclass && c.SubjectId == idsubject).Select(c => c.JoinCode).FirstOrDefault();
        var _lstStudentIDInClass = _studentclassRes.AsQueryable().Where(c => c.ClassId == idclass && c.JoinCodeAsign == joicode).Select(c => c.StudentId).ToList();

        // list Sinh viên
        var _lstStudentInClass = _studentRepository.AsQueryable().Where(c => _lstStudentIDInClass.Contains(c.Id)).ToList();

        ///_lstLessonIDInClass=> List Id Baihoc.
        var _lstLessonIDInClass = _lesson.AsQueryable().OrderBy(c => c.IndexOfLesson).Where(c => c.SubjectId == idsubject).Select(c => c.Id).ToList();

        var listgui = new List<Guid?>();
        foreach (var iteam in _lstLessonIDInClass)
        {
            listgui.Add(iteam);
        }

        ///_lstQuizIDInClass=> List Id Quiz.
        var _lstQuizIDInClass = _quizRepository.AsQueryable().OrderBy(c => c.QuizName).Where(c => c.SubjectId == idsubject).Select(c => c.Id).ToList();

        var listidquiz = new List<Guid?>();
        foreach (var iteam in _lstQuizIDInClass)
        {
            listidquiz.Add(iteam);
        }

        //var lsstudentquiz = await _studentuizRepository.AsQueryable().ToListAsync();
        //var _lisQuizStudentIdClass = new List<QuizSummit>();
        //foreach (var student in lsstudentquiz)
        //{
        //    var item = new QuizSummit();
        //    item.StudentId = student.StudentId;
        //    item.QuizName = _quizRepository.AsQueryable().Where(c => c.Id == student.QuizId).Select(c => c.QuizName).FirstOrDefault();
        //    item.QuizId = student.QuizId;
        //    item.ScoreQuizOfStudent = student.ScoreQuizOfStudent;
        //    _lisQuizStudentIdClass.Add(item);
        //}
        var lssubmithomwork = await _submitHomeWork.AsQueryable().ToListAsync();
        var listsubmithomwork = lssubmithomwork.Where(c => _lstStudentIDInClass.Contains(c.IdStudent) && c.IdClass == idclass && c.IdSubject == idsubject).ToList();
        var _lislinkStudent = new List<Thongtinbaitap>();
        foreach (var student in listsubmithomwork)
        {
            var item = new Thongtinbaitap();
            item.Idstudent = student.IdStudent;
            item.IdLesson = student.IdLesson;
            //item.SubjectName = student.SubjectName;
            item.Idsubject = student.IdSubject;
            //item.StudentId = student.StudentId;
            item.SubmitLink = student.SubmitLink;
            item.StatusSubmitHomework = student.Status;
            item.IndexOfLesson = _lesson.AsQueryable().Where(c => c.Id == student.IdLesson).Select(c => c.IndexOfLesson).FirstOrDefault();
            _lislinkStudent.Add(item);
        }

        foreach (var student in _lstStudentInClass)
        {
            var temp = new StudentStatisticsDtos();
            temp.Quiz = new List<QuizSummit>();
            temp.IdStudent = student.Id;
            temp.StudentCode = student.StudentCode;
            temp.StudentName = student.StudentName;
            //temp.Gender = Convert.ToBoolean(student.Gender);
            //temp.DateOfBirth = Convert.ToDateTime(student.DateOfBirth);
            temp.Email = student.Email;
            temp.PhoneNumber = student.PhoneNumber;
            temp.Address = student.Address;
            temp.ImageUrl = student.ImageUrl;
            temp.CountSV = _lstStudentInClass.Count();
            //temp.CountBaitap = _homeWork.AsQueryable().Where(c => c.IdClass == idclass && c.IdSubject == idsubject).Count();

            //var lsquiz = new List<QuizSummit>();
            //QuizSummit quiz = new QuizSummit();
            //foreach (var submit in _lisQuizStudentIdClass.Where(c => c.StudentId == student.Id).ToList())
            //{

            //    quiz = new QuizSummit()
            //    {
            //        QuizId = submit.QuizId,
            //        ScoreQuizOfStudent = submit.ScoreQuizOfStudent,
            //        QuizName = submit.QuizName,
            //    };
            //    lsquiz.Add(quiz);
            //}
            //for (int i = 1; i <= _lstQuizIDInClass.Count(); i++)
            //{
            //    if (lsquiz.Any(c => c.QuizId == Guid.Empty))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        quiz = new QuizSummit()
            //        {
            //            QuizId = Guid.Empty,
            //            ScoreQuizOfStudent = 0,
            //            QuizName = i.ToString(),
            //        };
            //        lsquiz.Add(quiz);
            //    }

            //}
            var lslink = new List<LinkSubmitSubject>();
            LinkSubmitSubject link = new LinkSubmitSubject();
            foreach (var submit in _lislinkStudent.Where(c => c.Idstudent == student.Id && c.Idsubject == idsubject).ToList())
            {

                link = new LinkSubmitSubject()
                {
                    Idbaihoc = submit.IdLesson,
                    Idstudent = submit.Idstudent,
                    IndexOfLesson = submit.IndexOfLesson,
                    SubjectName = submit.SubjectName,
                    SubmitLink = submit.SubmitLink,
                    StatusSubmitHomework = submit.StatusSubmitHomework,
                    Soluongnopbai = await _submitHomeWork.AsQueryable().Where(c => c.IdClass == idclass && c.IdStudent == submit.Idstudent && c.IdSubject == idsubject && c.Status == 1).CountAsync()
                };
                lslink.Add(link);
            }
            for (int i = 1; i <= _lstLessonIDInClass.Count(); i++)
            {
                if (lslink.Any(c => c.Idbaihoc == Guid.Empty && c.IndexOfLesson == i))
                {
                    continue;
                }

                if (lslink.Any(c => c.IndexOfLesson == i))
                {
                    continue;
                }
                else
                {
                    link = new LinkSubmitSubject()
                    {
                        Idbaihoc = Guid.Empty,
                        Idstudent = Guid.Empty,
                        IndexOfLesson = i,
                        SubjectName = "",
                        SubmitLink = null,
                        StatusSubmitHomework = 0,
                    };
                    lslink.Add(link);
                }

            }
            var listlinkorderby = lslink.OrderBy(c => c.IndexOfLesson).ToList();

            var index = listlinkorderby.Count - 1;
            while (index > 0)
            {
                if (listlinkorderby[index].Idbaihoc == listlinkorderby[index - 1].Idbaihoc && listlinkorderby[index].Idbaihoc != Guid.Empty)
                {
                    if (index < listlinkorderby.Count - 1 && listlinkorderby[index].Idbaihoc != Guid.Empty)
                        (listlinkorderby[index].Idbaihoc, listlinkorderby[listlinkorderby.Count - 1].Idbaihoc) = (listlinkorderby[listlinkorderby.Count - 1].Idbaihoc, listlinkorderby[index].Idbaihoc);
                    listlinkorderby.RemoveAt(index);
                    index--;
                }
                else
                    index--;
            }
            temp.Link.AddRange(listlinkorderby);
            //temp.Quiz.AddRange(lsquiz);
            temp.Listidlesson = listgui;
            temp.ListidQuiz = listidquiz;
            result.Add(temp);

        }
        #endregion


        if (!string.IsNullOrEmpty(studentParameters.Masv))
            result = result.Where(x => x.StudentCode.Contains(studentParameters.Masv)).ToList();


        /// trạng thái là id của bài học khi dùng tính năng lọc màn StudentStatisticsChitiet
        if (!string.IsNullOrEmpty(studentParameters.trangthai))
        {

            var checkGuidStatust = Guid.TryParse(studentParameters.trangthai, out var lessonIdConverted);

            if (checkGuidStatust)
            {

                var tempForResult = result.Where(c => c.Link.Any(c => Guid.Equals(lessonIdConverted, c.Idbaihoc))).ToList();
                //test = tempForResult.OrderBy(c => c.Link.Where(p => Guid.Equals(lessonIdConverted, p.Idbaihoc)).Select(p => p.StatusSubmitHomework).FirstOrDefault() == 1).ToList();
                test = tempForResult.OrderByDescending(c => c.Link.Where(p => Guid.Equals(lessonIdConverted, p.Idbaihoc)).Select(p => p.Soluongnopbai).FirstOrDefault()).ToList();

                foreach (var item in test)
                {
                    foreach (var item2 in item.Listidlesson)
                    {
                        if (item2 == lessonIdConverted)
                        {
                            if (await _submitHomeWork.AsQueryable().Where(c => c.IdClass == idclass && c.IdSubject == idsubject && c.IdLesson == item2 && c.IdStudent == item.IdStudent && c.Status == 1).CountAsync()
                                == await _submitHomeWork.AsQueryable().Where(c => c.IdClass == idclass && c.IdSubject == idsubject && c.IdLesson == item2 && c.IdStudent == item.IdStudent).CountAsync())
                            {
                                test[0].CountSubmit += 1;
                            }
                            else
                            {
                                test[0].CountDonSubmit += 1;
                            }
                        }
                    }

                }

                result = test;
            }
            //result = result.Where(c=>c.Link.Any(c=>c.Idbaihoc == Guid.Parse(studentParameters.trangthai))).ToList()
            //    .OrderBy(c => c.Link.Select(c => c.StatusSubmitHomework).FirstOrDefault() == 1).ToList();

        }
        /// quizid là id của quiz khi dùng tính năng lọc màn StudentStatisticsChitiet
        //if (!string.IsNullOrEmpty(studentParameters.quizid))
        //{

        //    var checkGuidStatust = Guid.TryParse(studentParameters.quizid, out var quizIdConverted);

        //    if (checkGuidStatust)
        //    {

        //        var tempForResult = result.Where(c => c.Quiz.Any(c => Guid.Equals(quizIdConverted, c.QuizId))).ToList();
        //        test = tempForResult.OrderBy(c => c.Quiz.Where(p => Guid.Equals(quizIdConverted, p.QuizId)).Select(p => p.ScoreQuizOfStudent).FirstOrDefault() >= 0).ToList();
        //        result = test;
        //    }
        //    //result = result.Where(c=>c.Link.Any(c=>c.Idbaihoc == Guid.Parse(studentParameters.trangthai))).ToList()
        //    //    .OrderBy(c => c.Link.Select(c => c.StatusSubmitHomework).FirstOrDefault() == 1).ToList();

        //}

        var count = result.Count();
        var data = result
            .Skip((studentParameters.PageNumber - 1) * studentParameters.PageSize)
            .Take(studentParameters.PageSize)
            .ToList();

        return new PageList<StudentStatisticsDtos>(data, count
            , studentParameters.PageNumber
            , studentParameters.PageSize);
    }

    public async Task<PageList<StudentStatisticsDtos>> QuizStatisticsDtos(Guid idsubject, Guid idclass, StudentStatisticListSearch studentParameters)
    {

        var result = new List<StudentStatisticsDtos>();
        var test = new List<StudentStatisticsDtos>();

        #region lấy lits liên quan đến Sinh viên.
        ///_lstStudentIDInClas=> List Id Sinh viên.
        var joicode = _subclassRepository.AsQueryable().ToList().Where(c => c.ClassId == idclass && c.SubjectId == idsubject).Select(c => c.JoinCode).FirstOrDefault();
        var _lstStudentIDInClass = _studentclassRes.AsQueryable().Where(c => c.ClassId == idclass && c.JoinCodeAsign == joicode).Select(c => c.StudentId).ToList();

        // list Sinh viên
        var _lstStudentInClass = _studentRepository.AsQueryable().Where(c => _lstStudentIDInClass.Contains(c.Id)).ToList();

        ///_lstLessonIDInClass=> List Id Baihoc.
        var _lstLessonIDInClass = _lesson.AsQueryable().OrderBy(c => c.IndexOfLesson).Where(c => c.SubjectId == idsubject).Select(c => c.Id).ToList();

        var listgui = new List<Guid?>();
        foreach (var iteam in _lstLessonIDInClass)
        {
            listgui.Add(iteam);
        }

        ///_lstQuizIDInClass=> List Id Quiz.
        var _lstQuizIDInClass = _quizRepository.AsQueryable().OrderBy(c => c.QuizName.Substring(5)).Where(c => c.SubjectId == idsubject).Select(c => c.Id).ToList();

        var listidquiz = new List<Guid?>();
        foreach (var iteam in _lstQuizIDInClass)
        {
            listidquiz.Add(iteam);
        }

        var lsstudentquiz = await _studentuizRepository.AsQueryable().ToListAsync();
        var _lisQuizStudentIdClass = new List<QuizSummit>();
        foreach (var student in lsstudentquiz)
        {
            var item = new QuizSummit();
            item.StudentId = student.StudentId;
            item.QuizName = _quizRepository.AsQueryable().Where(c => c.Id == student.QuizId).Select(c => c.QuizName).FirstOrDefault();
            item.QuizId = student.QuizId;
            item.ScoreQuizOfStudent = student.ScoreQuizOfStudent;
            _lisQuizStudentIdClass.Add(item);
        }
        foreach (var student in _lstStudentInClass)
        {
            var temp = new StudentStatisticsDtos();
            temp.Quiz = new List<QuizSummit>();
            temp.IdStudent = student.Id;
            temp.StudentCode = student.StudentCode;
            temp.StudentName = student.StudentName;
            //temp.Gender = Convert.ToBoolean(student.Gender);
            //temp.DateOfBirth = Convert.ToDateTime(student.DateOfBirth);
            temp.Email = student.Email;
            temp.PhoneNumber = student.PhoneNumber;
            temp.Address = student.Address;
            temp.ImageUrl = student.ImageUrl;
            temp.CountSV = _lstStudentInClass.Count();
            //temp.CountBaitap = _homeWork.AsQueryable().Where(c => c.IdClass == idclass && c.IdSubject == idsubject).Count();

            var lsquiz = new List<QuizSummit>();
            QuizSummit quiz = new QuizSummit();
            foreach (var submit in _lisQuizStudentIdClass.Where(c => c.StudentId == student.Id && _lstQuizIDInClass.Any(x=>x == c.QuizId)).OrderBy(c => c.QuizName.Substring(5)).ToList())
            {

                quiz = new QuizSummit()
                {
                    StudentId = submit.StudentId,
                    QuizId = submit.QuizId,
                    ScoreQuizOfStudent = submit.ScoreQuizOfStudent,
                    QuizName = submit.QuizName.Substring(5),
                };
                lsquiz.Add(quiz);
            }
            var dtb = Convert.ToDouble(lsquiz.Sum(c => c.ScoreQuizOfStudent)) / _lstQuizIDInClass.Count();
            temp.Diemtrungbinh = Math.Round(dtb,2);
            for (int i = 1; i <= _lstQuizIDInClass.Count(); i++)
            {
                if (lsquiz.Any(c => c.QuizId == Guid.Empty && c.QuizName == i.ToString()))
                {
                    continue;
                }
                if (lsquiz.Any(c => c.QuizName == i.ToString()))
                {
                    continue;
                }
                else
                {

                    quiz = new QuizSummit()
                    {
                        StudentId = Guid.Empty,
                        QuizId = Guid.Empty,
                        ScoreQuizOfStudent = 0,
                        QuizName = i.ToString(),
                    };
                    lsquiz.Add(quiz);
                }
            }
            temp.Quiz.AddRange(lsquiz.OrderBy(c=>c.QuizName));
            temp.Listidlesson = listgui;
            temp.ListidQuiz = listidquiz;
            result.Add(temp);

        }
        #endregion


        if (!string.IsNullOrEmpty(studentParameters.Masv))
            result = result.Where(x => x.StudentCode.Contains(studentParameters.Masv)).ToList();

        /// quizid là id của quiz khi dùng tính năng lọc màn StudentStatisticsChitiet
        if (!string.IsNullOrEmpty(studentParameters.quizid))
        {

            var checkGuidStatust = Guid.TryParse(studentParameters.quizid, out var quizIdConverted);

            if (checkGuidStatust)
            {

                var tempForResult = result.Where(c => c.Quiz.Any(c => Guid.Equals(quizIdConverted, c.QuizId))).ToList();
                test = tempForResult.Where(c => c.Quiz.Where(p => Guid.Equals(quizIdConverted, p.QuizId)).Select(p => p.ScoreQuizOfStudent).FirstOrDefault() <= 50).ToList();
                result = test;
            }
            //result = result.Where(c=>c.Link.Any(c=>c.Idbaihoc == Guid.Parse(studentParameters.trangthai))).ToList()
            //    .OrderBy(c => c.Link.Select(c => c.StatusSubmitHomework).FirstOrDefault() == 1).ToList();

        }

        var count = result.Count();
        var data = result.OrderByDescending(c => c.Diemtrungbinh)
            .Skip((studentParameters.PageNumber - 1) * studentParameters.PageSize)
            .Take(studentParameters.PageSize).ToList();

        return new PageList<StudentStatisticsDtos>(data, count
            , studentParameters.PageNumber
            , studentParameters.PageSize);
    }
    public async Task<ListIdStudent> GetListIdStudents(Guid idclass)
    {
        var listIdStudent = new ListIdStudent();
        var _lstIdStd = _studentclassRes.AsQueryable().Where(c => c.ClassId == idclass).Select(c => c.StudentId).ToList();

        try
        {
            foreach (var iteam in _lstIdStd)
            {

                listIdStudent.idstudents.Add(iteam);
            }
            return listIdStudent;
        }
        catch
        {
            throw new Exception();
        }
    }
}
