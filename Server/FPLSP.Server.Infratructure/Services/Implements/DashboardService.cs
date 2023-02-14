using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Dtos.DashboardDtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.Specialized;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace FPLSP.Server.Infrastructure.Services.Implements;

public class DashboardService : IDashboardService
{
    private readonly IRepository<TrainingFacilitiesCP> _trainingRepository;
    private readonly IRepository<LecturersCP> _lecturersRepository;
    private readonly IRepository<LectuterSpecializedCP> _LectuterSpecializedCP;

    private readonly IRepository<SubjectClassUP> _subjectClassUp;

    private readonly IRepository<StudentUP> _studentUp;
    private readonly IRepository<UserSignIn> _userSignIn;
    private readonly IRepository<RoleCP> _roleCP;
    private readonly IRepository<SpecializedCP> _SpecializedCP;

    private List<TrainingFacilitiesCP> _lstTraining = new List<TrainingFacilitiesCP>();
    private List<LecturersCP> _lstLecturersCps = new List<LecturersCP>();
    private List<SubjectClassUP> _lsSubjectClassUps = new List<SubjectClassUP>();
    private List<ClassUp> _lsClassUps = new List<ClassUp>();
    private List<StudentClassUP> _lsStudentClassUps = new List<StudentClassUP>();
    private List<StudentUP> _lsStudentUps = new List<StudentUP>();
    private List<UserSignIn> _lsUserSignIn = new List<UserSignIn>();

    public DashboardService(IRepository<TrainingFacilitiesCP> trainingRepository, IRepository<LecturersCP> lecturersRepository, IRepository<LectuterSpecializedCP> lectuterSpecializedCP, IRepository<SubjectClassUP> subjectClassUp, IRepository<StudentUP> studentUp, IRepository<UserSignIn> userSignIn, IRepository<RoleCP> roleCP, IRepository<SpecializedCP> specializedCP)
    {
        _trainingRepository = trainingRepository;
        _lecturersRepository = lecturersRepository;
        _LectuterSpecializedCP = lectuterSpecializedCP;
        _subjectClassUp = subjectClassUp;
        _studentUp = studentUp;
        _userSignIn = userSignIn;
        _roleCP = roleCP;
        _SpecializedCP = specializedCP;
    }




    //private void GetData()
    //{
    //    _lstTraining = new List<TrainingFacilitiesCP>();
    //    _lstLecturersCps = new List<LecturersCP>();
    //    _lsSubjectClassUps = new List<SubjectClassUP>();
    //    _lsStudentClassUps = new List<StudentClassUP>();
    //    _lsStudentUps = new List<StudentUP>();
    //    _lsClassUps = new List<ClassUp>();
    //    _lstTraining = _trainingRepository.AsQueryable().ToList();
    //    _lstLecturersCps = _lecturersRepository.AsQueryable().ToList();
    //    _lsStudentUps = _studentUp.AsQueryable().ToList();
    //    _lsSubjectClassUps = _subjectClassUp.AsQueryable().ToList();
    //    _lsClassUps = _classUp.AsQueryable().ToList();
    //    _lsStudentClassUps = _studentClassUp.AsQueryable().ToList();
    //    _lsUserSignIn = _userSignIn.AsQueryable().ToList();


    //}
    //public List<LecturersCP> QuantityLecturesInTrainingFacilities(Guid TrainFaci_Id)
    //{
    //    var _lstLcturesInTrainFaci = _lecturersRepository.AsQueryable().Where(c => Guid.Equals(TrainFaci_Id, c.TrainingFacilitiesId) && Equals(false, c.IsDeleted)).ToList();
    //    return _lstLcturesInTrainFaci;
    //}

    //public Task<List<TrainingFacilitiesForDashBoardDto>> GetAllTrainingFacilities()
    //{
    //    var _listResult = new List<TrainingFacilitiesForDashBoardDto>();
    //    var _lstTrain = _trainingRepository.AsQueryable().ToList();
    //    foreach (var train in _lstTrain)
    //    {
    //        var resultAdd = new TrainingFacilitiesForDashBoardDto();
    //        var lstStudents = new List<StudentUP>();
    //        var listGuidStudentUp = new List<Guid>();
    //        var listClassGuid = new List<Guid>();
    //        var lstClassCollection = new List<ClassUp>();

    //        resultAdd.TrainFaci_Id = train.Id;
    //        resultAdd.TrainFaci_Name = train.TrainingInstitutionName;
    //        resultAdd.LectureUp_Quantity = QuantityLecturesInTrainingFacilities(train.Id).Count();
    //        //var listSubjectClassUP = new List<SubjectClassUP>();

    //        foreach (var specia in QuantityLecturesInTrainingFacilities(train.Id))
    //        {
    //            var listClasss = QuantityClassInSpecializedUp(specia.Id).ToList();
    //            listClassGuid.AddRange(listClasss);
    //            //foreach (var classUp in listClasss)
    //            //{
    //            //    var listStudent = QuantityStudentInClassUp(classUp.Id);
    //            //    listStudentClassUp.AddRange(listStudent);
    //            //}

    //        }

    //        var tempList = listClassGuid.Distinct().ToList();
    //        var listClassInTraFic = _lsClassUps.Where(c => tempList.Contains(c.Id) && c.Status != 3).ToList();
    //        foreach (var classUp in listClassInTraFic)
    //        {
    //            var listStudent = QuantityStudentInClassUp(classUp.Id);
    //            listGuidStudentUp.AddRange(listStudent);
    //        }
    //        //#region nhóm để tránh lặp khi 1 sinh viên học ở 2 lớp khác nhau
    //        //var temp = listStudentClassUp.GroupBy(c => c.StudentId)
    //        //    .Select(c => new { StudentId = c.Key, listClassUp = c.ToList().Select(c => c.ClassId) }).ToList();
    //        //lstStudents = _studentUp.AsQueryable().Where(c => temp.Select(p => p.StudentId).ToList().Contains(c.Id))
    //        //    .ToList();

    //        var listSV = listGuidStudentUp.Distinct().ToList();
    //        lstStudents = _lsStudentUps.Where(c => listSV.Contains(c.Id) && c.IsDeleted == false && c.Status != 0).ToList();

    //        // #endregion
    //        //listSubjectClassUP.GroupBy(c=>)
    //        resultAdd.ClassUp_Quantity = listClassInTraFic.Count;
    //        resultAdd.StudentUp_Quantity = lstStudents.Count;
    //        _listResult.Add(resultAdd);
    //    }
    //    return Task.FromResult(_listResult);
    //}

    //public List<Guid> QuantityClassInSpecializedUp(Guid lecture_Id)
    //{
    //    var _listResult = new List<ClassUp>();
    //    var _lisGuid_Class = _lsSubjectClassUps.Where(c => c.HomeroomLecturer == lecture_Id && c.Status != 1).Select(c => c.ClassId).ToList();
    //    //var tempList= _lisGuid_Class.GroupBy(c=>c.Value).Select(c=>c.Key).ToList();
    //    //_listResult = _lsClassUps.Where(c => tempList.Contains(c.Id)).ToList();
    //    return _lisGuid_Class.Select(c => c.Value).ToList();
    //}

    //public List<Guid> QuantityStudentInClassUp(Guid Class_Id)
    //{
    //    var _lstStudent = new List<StudentUP>();
    //    var _lstStudentId = _lsStudentClassUps.Where(c => c.ClassId == Class_Id).Select(c => c.StudentId).ToList();
    //    //var _lisStudent = _lstStudentId.GroupBy(c => c.StudentId)
    //    //    .Select(c => new { StudentId = c.Key, listClassUp = c.ToList().Select(c => c.ClassId) });
    //    //_lstStudent = _lsStudentUps.Where(c => _lstStudentId.Select(c => c.StudentId).Contains(c.Id)).ToList();
    //    // var listGuidStudent= _lstStudent.
    //    return _lstStudentId.Select(c => c.Value).ToList();
    //}

    //public List<Guid> QuantitySpecializedInTrainingFacility(List<Guid> lecture_Id)
    //{
    //    var _lstGuid = new List<Guid>();
    //    var _lst = _lecSpec.AsQueryable().Where(c => lecture_Id.Contains((Guid)c.LectuterId)).ToList();
    //    var temp = from p in _lst
    //               group p.LectuterId by p.SpecializedId into g
    //               select new { SpecializedId = g.Key, LectureId = g.ToList() };
    //    var tempList = temp.Select(c => c.SpecializedId).ToList();
    //    _lstGuid = tempList.Where(c => c.HasValue).Select(c => c.Value).ToList();
    //    return _lstGuid;

    //}
    //public Task<List<StudentUP>> GetAllStudentsAction()
    //{
    //    var listStudent = _studentUp.AsQueryable().Where(entity => Guid.Equals(false, entity.IsDeleted) && entity.Status != 0).ToList();
    //    return Task.FromResult(listStudent);
    //}

    //public Task<List<LecturersCP>> GetAllLecturesAction()
    //{
    //    var listLecturersCps = _lecturersRepository.AsQueryable().Where(entity => Guid.Equals(false, entity.IsDeleted)).ToList();
    //    return Task.FromResult(listLecturersCps);
    //}

    public async Task<int> GetAllStudentUPNotUser()
    {

        var lstStudentUP = _studentUp.AsQueryable().ToList();


        var lstStudentUPNotUser = _studentUp.AsQueryable().ToList();

        var countStudentNotUser = _userSignIn.AsQueryable().ToList().Select(c => c.Id).ToList();

        var countstudentByIdUser = lstStudentUP.Where(c => countStudentNotUser.Contains(c.Id.ToString())).ToList();

        foreach (var item in countstudentByIdUser)
        {
            lstStudentUPNotUser.Remove(lstStudentUPNotUser.FirstOrDefault(c => c.Id == item.Id));
        }
        var countStudent = lstStudentUPNotUser.Count();
        return countStudent;

    }
    public async Task<int> GetAllLectureNotUser(Guid idTran)

    {
        var lstLecture = _lecturersRepository.AsQueryable().ToList();
        var lstLectureNotUser = _lecturersRepository.AsQueryable().ToList();
        if ((idTran != Guid.Empty))
        {
            lstLectureNotUser = lstLectureNotUser.Where(c => c.TrainingFacilitiesId == idTran).ToList();
        }

        var countLectureNotUser = _userSignIn.AsQueryable().ToList().Select(c => c.Id).ToList();
        var countlecru = lstLecture.Where(c => countLectureNotUser.Contains(c.Id.ToString())).ToList();

        foreach (var item in countlecru)
        {
            lstLectureNotUser.Remove(lstLectureNotUser.FirstOrDefault(c => c.Id == item.Id));
        }

        return lstLectureNotUser.Count();
    }
    public async Task<int> GetAllSpec()

    {
        var lstLecture = _lecturersRepository.AsQueryable().ToList();
        var lstLectureUser = _lecturersRepository.AsQueryable().ToList();

        var countLectureUser = _userSignIn.AsQueryable().ToList().Select(c => c.Id).ToList();
        var countlecru = lstLecture.Where(c => countLectureUser.Contains(c.Id.ToString())).Select(c => c.Id).ToList();
        var GetAllSpec = _LectuterSpecializedCP.AsQueryable().ToList().Where(c => countlecru.Contains(c.LectuterId.Value)).GroupBy(c => c.SpecializedId).ToList().Count();

        return GetAllSpec;
    }
    public async Task<PageList<SpecializedDto>> GetAllSpecByIdTran(Guid idTran, SpecializedListSearch specializedParameters)

    {
        var lstLecture = _lecturersRepository.AsQueryable().ToList();

        var lstSpecALl = _SpecializedCP.AsQueryable().ToList();
        var lstUserSingIn = _userSignIn.AsQueryable().ToList().Where(c => c.IdTrainingFacility == idTran).Select(c => c.Id).ToList();
        var lstLectureByUser = lstLecture.Where(c => lstUserSingIn.Contains(c.Id.ToString())).Select(c => c.Id).ToList();
        var lstSpecByLecture = _LectuterSpecializedCP.AsQueryable().ToList().Where(c => lstLectureByUser.Contains(c.LectuterId.Value)).GroupBy(c => c.SpecializedId).Select(c => c.Key).ToList();
        var lst = lstSpecALl.Where(c => lstSpecByLecture.Contains(c.Id)).ToList();

        var lsspecialized = lst.Select(x => new SpecializedDto()
        {
            SpecializedCode = x.SpecializedCode.Trim(),
            SpecializationName = x.SpecializationName,
            Status = x.Status,
            Id = x.Id,
            Level = x.Level,
            Image = x.Image,
            IdSpeciality = x.IdSpeciality,
        });
        if (!string.IsNullOrEmpty(specializedParameters.Name))
            lsspecialized = lsspecialized.Where(x => x.SpecializationName.ToLower().Contains(specializedParameters.Name.ToLower()) || x.SpecializedCode.ToLower().Contains(specializedParameters.Name.ToLower()));

        var data = lsspecialized
            .Skip((specializedParameters.PageNumber - 1) * specializedParameters.PageSize)
            .Take(specializedParameters.PageSize)
            .ToList();
        return new PageList<SpecializedDto>(data, lsspecialized.Count(),
            specializedParameters.PageNumber, specializedParameters.PageSize);

    }


    ///////////////

    public async Task<List<TrainingFacilitiesForDashBoardDto>> GetAllDashBoard()
    {

        var _listResult = new List<TrainingFacilitiesForDashBoardDto>();
        var _lstTrain = _trainingRepository.AsQueryable().ToList();
        var lstStudentUP = _studentUp.AsQueryable().ToList();
        var lstLecture = _lecturersRepository.AsQueryable().ToList();
        var lstsubjectClassUp = _subjectClassUp.AsQueryable().ToList();

        //foreach (var item in _userSignIn.AsQueryable().ToList())
        //{
        //    var updateIDTrainLecture = lstLecture.FirstOrDefault(c => c.Id == Guid.Parse(item.Id));
        //    if (updateIDTrainLecture == null) continue;
        //    if (updateIDTrainLecture.TrainingFacilitiesId != item.IdTrainingFacility)
        //    {
        //        updateIDTrainLecture.TrainingFacilitiesId = item.IdTrainingFacility;
        //        await _lecturersRepository.UpdateAsync(updateIDTrainLecture);
        //        await _lecturersRepository.SaveChangesAsync();
        //    }
        //}

        foreach (var train in _lstTrain)
        {
            var resultAdd = new TrainingFacilitiesForDashBoardDto();

            // Lst email User theo train
            var lstUserSingIn = _userSignIn.AsQueryable().ToList().Where(c => c.IdTrainingFacility == train.Id).Select(c => c.Id).ToList();
            // Xác định Train
            resultAdd.TrainFaci_Id = train.Id;
            resultAdd.TrainFaci_Name = train.TrainingInstitutionName;
            //// count student theo user
            // //  Dem so luong Student  == Lecture
            //   List<Guid> removeStudent = new List<Guid>();
            // foreach (var item in lstStudentUP.Where(c => lstUserSingIn.Contains(c.Id.ToString())).ToList())
            // {
            //     foreach (var item1 in lstLecture.Where(c => lstUserSingIn.Contains(c.Id.ToString())).Select(c => c.Id).ToList())
            //     {
            //         if (item.Id == item1)
            //         {
            //             removeStudent.Add(item1);
            //         }
            //     }
            // }
            ////  remove studen ID trung Lecture id
            //  if (removeStudent.Count() > 0)
            //  {
            //      foreach (var item in removeStudent)
            //      {
            //          var lstStudenQuizRemove = _studentQuizUP.AsQueryable().ToList().Where(c => c.StudentId == item).ToList();
            //          if (lstStudenQuizRemove.Count() != 0)
            //          {
            //              _studentQuizUP.RemoveRangeAsync(lstStudenQuizRemove);
            //              _studentQuizUP.SaveChangesAsync();
            //          }
            //          var lstSubmitHomeWork = _submitHomeWork.AsQueryable().ToList().Where(c => c.IdStudent == item).ToList();
            //          if (lstSubmitHomeWork.Count() != 0)
            //          {
            //              _submitHomeWork.RemoveRangeAsync(lstSubmitHomeWork);
            //              _submitHomeWork.SaveChangesAsync();
            //          }

            //          var lstStudentClassRemove = _studentClassUp.AsQueryable().ToList().Where(c => c.StudentId == item).ToList();
            //          if (lstStudentClassRemove.Count() != 0)
            //          {
            //              _studentClassUp.RemoveRangeAsync(lstStudentClassRemove);
            //              _studentClassUp.SaveChangesAsync();

            //          }
            //          var lstVideoHistory = _VideoHistory.AsQueryable().ToList().Where(c => c.IdStudent == item).ToList();
            //          if (lstVideoHistory.Count() != 0)
            //          {
            //              _VideoHistory.RemoveRangeAsync(lstVideoHistory);
            //              _VideoHistory.SaveChangesAsync();

            //          }

            //      }
            //  }

            //Count studentUP
            resultAdd.StudentUp_Quantity = lstStudentUP.Where(c => lstUserSingIn.Contains(c.Id.ToString())).ToList().Count();
            // count lecture theo user
            var lstLectureByUser = lstLecture.Where(c => lstUserSingIn.Contains(c.Id.ToString())).Select(c => c.Id).ToList();
            //foreach (var item in lstStudentUP)
            //{
            //    if (lstLectureByUser.Any(c=>c == item.Id))
            //    {
            //        lstLectureByUser.Remove(item.Id);
            //    }
            //}
            resultAdd.LectureUp_Quantity = lstLectureByUser.Count();

            // count classup theo lecture
            resultAdd.ClassUp_Quantity = lstsubjectClassUp.Where(c => lstLectureByUser.Contains(c.HomeroomLecturer)).GroupBy(c => c.JoinCode).ToList().Count();
            // count Spec theo Lecture
            resultAdd.Spec_Quantity = _LectuterSpecializedCP.AsQueryable().ToList().Where(c => lstLectureByUser.Contains(c.LectuterId.Value)).GroupBy(c => c.SpecializedId).ToList().Count();

            _listResult.Add(resultAdd);
        }

        return _listResult;
    }



}