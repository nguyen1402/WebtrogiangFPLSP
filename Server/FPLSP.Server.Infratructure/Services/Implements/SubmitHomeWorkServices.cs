using FPLSP.Server.Data.Repositories.Implements;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.SubmitHomeWorkVM;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class SubmitHomeWorkServices : ISubmitHomeWorkServices
    {
        private readonly IRepository<SubmitHomeWork> _res;




        private readonly IRepository<StudentUP> _studentRepository;
        public SubmitHomeWorkServices(IRepository<SubmitHomeWork> res, IRepository<StudentUP> studentRepository)
        {
            _res = res ?? throw new ArgumentNullException(nameof(_res));
            _studentRepository = studentRepository ?? throw new ArgumentNullException(nameof(_studentRepository));
        }
        public async Task<int> Add(SubmitHomeWorkCreateVM summit)
        {

            for (int i = 0; i < summit.LsIdStudent.Count; i++)
            {
                var sumithw = new SubmitHomeWork()
                {
                    IdLesson = summit.IdLesson,
                    IdClass = summit.IdClass,
                    IdSubject = summit.IdSubject,
                    IdStudent = (Guid)summit.LsIdStudent[i],
                    Titile = summit.Titile,
                    Status = 0,
                    SubmitLink = "",
                    SubmitTime = DateTime.Now,
                    StartedDate = summit.StartedDate,
                    EndTime = summit.EndTime,
                };
                try
                {
                    //var check = _res.AsQueryable().Any(c => c.IdStudent == summit.LsIdStudent[i] && c.IdClass == summit.IdClass && c.IdLesson == summit.IdLesson);//check trùng
                    //if (check)
                    //{
                    //    continue;
                    //}
                    await _res.AddAsync(sumithw);
                    await _res.SaveChangesAsync();
                }
                catch
                {
                    return 0;
                }
            }
            return 1;
        }

        public async Task<int> AddList(SubmitListHomeWorkCreateVM summit)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteSubmit(Guid idClass, Guid idSubject, Guid idStudent)
        {
            try
            {
                var delete = _res.AsQueryable().Where(c => Guid.Equals(idStudent, c.IdStudent)&& Guid.Equals(idSubject, c.IdSubject) && Guid.Equals(idClass, c.IdClass)).ToList();
                if (delete.Count() == 0) return 0;
                await _res.RemoveRangeAsync(delete);
                await _res.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public async Task<List<SubmitHomeWorkDtos>> GetAll()
        {
            var result = new List<SubmitHomeWorkDtos>();

            var _lssinhviensumit = _res.AsQueryable().ToList()
                .Join(_studentRepository.AsQueryable().ToList(), sumit => sumit.IdStudent, studen => studen.Id, (sumit, studen) => new
                {
                    IdSubmit = sumit.Id,
                    IdClass = sumit.IdClass,
                    IdLesson = sumit.IdLesson,
                    IdSinhVien = studen.Id,
                    MaSv = studen.StudentCode,
                    TenSV = studen.StudentName,
                    Status = sumit.Status,
                    LinkNop = sumit.SubmitLink,
                    SubTime = sumit.SubmitTime,
                    idSubject = sumit.IdSubject,
                });

            foreach (var student in _lssinhviensumit)
            {
                var item = new SubmitHomeWorkDtos();
                item.Id = student.IdSubmit;
                item.IdClass = student.IdClass;
                item.IdLesson = student.IdLesson;
                item.IdStudent = student.IdSinhVien;
                item.Status = student.Status;
                item.SubmitLink = student.LinkNop;
                item.StudentCode = student.MaSv;
                item.StudentName = student.TenSV;
                item.SubmitTime = student.SubTime;
                item.IdSubject = student.idSubject;
                result.Add(item);
            }
            return result;
        }


        public async Task<PageList<SubmitHomeWorkDtos>> ThongkeNopbai(ListSubmitHomeWorkSeach parameters, Guid idclass, Guid idlesson)
        {
            var result = new List<SubmitHomeWorkDtos>();

            var _lssinhviensumit = _res.AsQueryable().Where(c => c.IdLesson == idlesson && c.IdClass == idclass)
                .Join(_studentRepository.AsQueryable(), sumit => sumit.IdStudent, studen => studen.Id, (sumit, studen) => new
                {
                    IdSubmit = sumit.Id,
                    IdClass = idclass,
                    IdLesson = sumit.IdLesson,
                    IdSinhVien = studen.Id,
                    MaSv = studen.StudentCode,
                    TenSV = studen.StudentName,
                    Status = sumit.Status,
                    LinkNop = sumit.SubmitLink,
                });

            foreach (var student in _lssinhviensumit)
            {
                var item = new SubmitHomeWorkDtos();
                item.Id = student.IdSubmit;
                item.IdClass = student.IdClass;
                item.IdLesson = student.IdLesson;
                item.IdStudent = student.IdSinhVien;
                item.Status = student.Status;
                item.SubmitLink = student.LinkNop;
                item.StudentCode = student.MaSv;
                item.StudentName = student.TenSV;
                result.Add(item);
            }
            if (!string.IsNullOrEmpty(parameters.Status))
                result = result.Where(x => x.Status == Convert.ToInt16(parameters.Status)).ToList();
            var count = result.Count();
            var data = result
                .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                .Take(parameters.PageSize)
                .ToList();

            return new PageList<SubmitHomeWorkDtos>(data, count
                , parameters.PageNumber
                , parameters.PageSize);
        }
    }
}
