using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop;
using FPLSP.Server.Infrastructure.ViewModels.Subject;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class SubjectUPServices : ISubjectUPServices
    {
        private readonly IRepository<LecturersCP> _Irepository;
        private readonly IRepository<LectuterSpecializedUP> _Ireplecspec;
        private readonly IRepository<SpecializedUP> _Irepspec;
        private readonly IRepository<SpecializedSubjectUP> _Irepspecsub;
        private readonly IRepository<SubjectUP> _Irepsub;
        private readonly IRepository<SubjectClassUP> _IrepsubClass;
        private readonly IRepository<ExamStorage> _examStorageRepo;
        public SubjectUPServices(IRepository<LecturersCP> irepository, IRepository<ExamStorage> examStorageRepo, IRepository<LectuterSpecializedUP> ireplecspec, IRepository<SpecializedUP> irepspec, IRepository<SpecializedSubjectUP> irepspecsub, IRepository<SubjectUP> irepsub, IRepository<SubjectClassUP> irepsubClass)
        {
            _Irepository = irepository;
            _Ireplecspec = ireplecspec;
            _Irepspec = irepspec;
            _Irepspecsub = irepspecsub;
            _Irepsub = irepsub;
            _IrepsubClass = irepsubClass;
            _examStorageRepo = examStorageRepo;
        }

        //public SubjectUPServices(IRepository<LecturersCP> Irepository
        //    , IRepository<LectuterSpecializedUP> Ireplecspec
        //    , IRepository<SpecializedUP> Irepspec
        //    , IRepository<SpecializedSubjectUP> Irepspecsub
        //    , IRepository<SubjectUP> Irepsub)
        //{
        //    _Irepository = Irepository ?? throw new ArgumentNullException(nameof(_Ireplecspec));
        //    _Ireplecspec = Ireplecspec ?? throw new ArgumentNullException(nameof(_Ireplecspec));
        //    _Irepspec = Irepspec ?? throw new ArgumentNullException(nameof(_Irepspec));
        //    _Irepspecsub = Irepspecsub ?? throw new ArgumentNullException(nameof(_Irepspecsub));
        //    _Irepsub = Irepsub ?? throw new ArgumentNullException(nameof(_Irepsub));
        //}
        public async Task<bool> CreateSubject(Guid idspecializedUP, SubjectCreateVM subject)
        {
            var time = DateTime.Compare(subject.StartDay, subject.EndDay);

            if (time >= 0)
                return false;

            var newsubject = new SubjectUP()
            {
                SubjectCode = subject.SubjectCode,
                SubjectName = subject.SubjectName,
                CreatedDay = DateTime.Now,
                StartDay = subject.StartDay,
                EndDay = subject.EndDay,
                TotalOfSub = subject.TotalOfSub,
                Status = subject.Status,
                Image = subject.Image
            };
            var check =  _Irepsub.AsQueryable().ToList().Any(c => String.Equals(newsubject.SubjectCode, c.SubjectCode));//check trùng
            if (check) return false;
            await _Irepsub.AddAsync(newsubject);
            var specsubj = new SpecializedSubjectUP()
            {
                SpecializedId = idspecializedUP,
                SubjectId = newsubject.Id,
                Status = 0
            };
            await _Irepspecsub.AddAsync(specsubj);
            await _Irepsub.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteListSubjectUP(List<Guid> idsubjectUP)
        {
            List<SubjectUP> subjectUps = new List<SubjectUP>();
            foreach (var item in idsubjectUP)
            {
                var subject = _Irepsub.AsQueryable().ToList().FirstOrDefault(c => c.Id == item);
                subject.Status = 3;
                _Irepsub.UpdateAsync(subject);
            }
            await _Irepsub.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteSubject(Guid idspecializedUP, Guid id)
        {
            var subject = _Irepsub.AsQueryable().ToList().FirstOrDefault(c => Equals(id, c.Id));
            if (subject == null)
            {
                return false;
            }
            await _Irepsub.RemoveAsync(subject);
            var specsubj = new SpecializedSubjectUP()
            {
                SpecializedId = idspecializedUP,
                SubjectId = subject.Id
            };
            await _Irepspecsub.RemoveAsync(specsubj);
            await _Irepsub.SaveChangesAsync();
            return true;
        }

        public async Task<PageList<LectuterSpecializedSubjectVM>> GetAllLectuterSpecializedSubject(SubjectListSearch subjectParameters, Guid lectuterId, Guid? idspec)
        {
            var querry = from c in _Irepository.AsQueryable().ToList()
                         join ct in _Ireplecspec.AsQueryable().ToList() on c.Id equals ct.LectuterId
                         join ct2 in _Irepspec.AsQueryable().ToList() on ct.SpecializedId equals ct2.Id
                         join ct3 in _Irepspecsub.AsQueryable().ToList() on ct2.Id equals ct3.SpecializedId
                         join ct4 in _Irepsub.AsQueryable().ToList() on ct3.SubjectId equals ct4.Id
                         where lectuterId == c.Id && idspec == ct2.Id
                         select new { c, ct, ct2, ct3, ct4 };

            var resuals = querry.Select(x => new LectuterSpecializedSubjectVM()
            {
                LectuterId = x.c.Id,
                SpecializedId = x.ct.SpecializedId,
                SubjectId = x.ct3.SubjectId,
                SpecializationName = x.ct2.SpecializationName,
                SubjectName = x.ct4.SubjectName,
                StartDay = x.ct4.StartDay,
                EndDay = x.ct4.EndDay,
                TotalOfSub = x.ct4.TotalOfSub,

                LecturersName = x.c.LecturersName,
                Gender = x.c.Gender,
                Dob = x.c.Dob,
                Email = x.c.Email,
                PhoneNumber = x.c.PhoneNumber,
                Address = x.c.Address,
                ImageUrl = x.ct4.Image,
            }).ToList();

            if (!string.IsNullOrEmpty(subjectParameters.Name))
                resuals = resuals.Where(x => x.SubjectName.ToLower().Contains(subjectParameters.Name.ToLower())).ToList();
            var count = resuals.Count();
            var data = resuals
                .Skip((subjectParameters.PageNumber - 1) * subjectParameters.PageSize)
                .Take(subjectParameters.PageSize)
                .ToList();

            return new PageList<LectuterSpecializedSubjectVM>(data, count
                , subjectParameters.PageNumber
                , subjectParameters.PageSize);
        }

        public async Task<List<SubjectDto>> GetAllSubjectAsync()
        {
            var subject = _Irepsub.AsQueryable().ToList();
            var resutl = (from sj in subject
                          select new SubjectDto()
                          {
                              Id = sj.Id,
                              SubjectCode = sj.SubjectCode,
                              SubjectName = sj.SubjectName,
                              CreatedDay = sj.CreatedDay,
                              StartDay = sj.StartDay,
                              Image = sj.Image,
                              EndDay = sj.EndDay,
                              TotalOfSub = sj.TotalOfSub,
                              Status = sj.Status,
                              Soluongdethi = _examStorageRepo.AsQueryable().Where(c => c.SubjectId == sj.Id).ToList().Count()
                          }).ToList();
            
            return resutl;
        }
        public async Task<PageList<SubjectDto>> GetAllSubjectAsync2(SubjectListSearchMonDeThi mon)
        {
            var subject = _Irepsub.AsQueryable().ToList();
            var resutl = (from sj in subject
                          select new SubjectDto()
                          {
                              Id = sj.Id,
                              SubjectCode = sj.SubjectCode,
                              SubjectName = sj.SubjectName,
                              CreatedDay = sj.CreatedDay,
                              StartDay = sj.StartDay,
                              Image = sj.Image,
                              EndDay = sj.EndDay,
                              TotalOfSub = sj.TotalOfSub,
                              Status = sj.Status,
                              Soluongdethi = _examStorageRepo.AsQueryable().Where(c => c.SubjectId == sj.Id).ToList().Count()
                          }).ToList();
            if (!string.IsNullOrEmpty(mon.namemon))
                resutl = resutl.Where(x => x.SubjectName.ToLower().Contains(mon.namemon.ToLower())).ToList();
            var count = resutl.Count();
            var data = resutl
                .Skip((mon.PageNumber - 1) * mon.PageSize)
                .Take(mon.PageSize)
                .ToList();

            return new PageList<SubjectDto>(data, count
                , mon.PageNumber
                , mon.PageSize);
            
        }

        public async Task<List<SubjectDto>> GetAllSubjectIsdemo()
        {
            var subject = _Irepsub.AsQueryable().ToList().Where(c => c.IsDemo == true);
            var resutl = (from sj in subject
                          select new SubjectDto()
                          {
                              Id = sj.Id,
                              SubjectCode = sj.SubjectCode,
                              SubjectName = sj.SubjectName,
                              CreatedDay = sj.CreatedDay,
                              StartDay = sj.StartDay,
                              Image = sj.Image,
                              EndDay = sj.EndDay,
                              TotalOfSub = sj.TotalOfSub,
                              Status = sj.Status
                          }).ToList();
            return resutl;
        }
        public async Task<List<SubjectUP>> GetAllSubjectbyIdLecture(Guid idLecture)
        {
            var lstIdSubjectByidLectu = _IrepsubClass.AsQueryable().ToList().Where(c=>c.HomeroomLecturer == idLecture).Select(c=>c.SubjectId).ToList();
            var lstSubjectUP = _Irepsub.AsQueryable().ToList().Where(c => lstIdSubjectByidLectu.Contains(c.Id)).ToList();
            return lstSubjectUP;
        }

        public async Task<SubjectUP> GetSubjectbyId(Guid id)
        {
            var result = _Irepsub.AsQueryable().ToList().FirstOrDefault(c => Equals(id, c.Id));
            return result;
        }

        public async Task<PageList<SubjectDto>> GetSubjects(Guid idspecializedUP, SubjectListSearch subjectParameters)
        {

            var lstspecisubj = _Irepspecsub.AsQueryable().ToList().Where(c => c.SpecializedId == idspecializedUP).Select(c => c.SubjectId).ToList();
            var lstsubject = _Irepsub.AsQueryable().ToList().Where(c => c.IsDeleted == false && lstspecisubj.Contains(c.Id)).Select(c => new SubjectDto()
            {
                Id = c.Id,
                SubjectCode = c.SubjectCode,
                SubjectName = c.SubjectName,
                CreatedDay = c.CreatedDay,
                StartDay = c.StartDay,
                Image = c.Image,
                EndDay = c.EndDay,
                TotalOfSub = c.TotalOfSub,
                Status = c.Status
            }).ToList();

            if (!string.IsNullOrEmpty(subjectParameters.Name))
                lstsubject = lstsubject.Where(x => x.SubjectName.Contains(subjectParameters.Name)).ToList();
            if (!string.IsNullOrEmpty(subjectParameters.SubjectCode))
                lstsubject = lstsubject.Where(x => Equals(x.SubjectCode, subjectParameters.SubjectCode)).ToList();
            if (!string.IsNullOrEmpty(subjectParameters.Status.ToString()))
                lstsubject = lstsubject.Where(x => Equals(x.Status, subjectParameters.Status)).ToList();
            var count = lstsubject.Count();
            var data = lstsubject
                .Skip((subjectParameters.PageNumber - 1) * subjectParameters.PageSize)
                .Take(subjectParameters.PageSize)
                .ToList();

            return new PageList<SubjectDto>(data, count
                , subjectParameters.PageNumber
                , subjectParameters.PageSize);
        }

        public async Task<bool> UpdateSubject(Guid Id, SubjectUpdateVM subject)
        {
            var time = DateTime.Compare(subject.StartDay, subject.EndDay);

            if (time >= 0)
                return false;
            var subject_db =  _Irepsub.AsQueryable().ToList().FirstOrDefault(c => Equals(Id, c.Id));
            subject_db.SubjectCode = subject.SubjectCode;
            subject_db.SubjectName = subject.SubjectName;
            subject_db.StartDay = subject.StartDay;
            subject_db.EndDay = subject.EndDay;
            subject_db.TotalOfSub = subject.TotalOfSub;
            subject_db.Status = subject.Status;
            subject_db.Image = subject.Image;

            await _Irepsub.UpdateAsync(subject_db);
            await _Irepsub.SaveChangesAsync();

            return true;
        }
    }
}

