using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FPLSP.Server.Infrastructure.Services.Implements.FPLExam
{
    public class SubjectTeacherService : ISubjectTeacherService
    {
        private readonly IRepository<SubjectTeacher> _Irepository;

        public SubjectTeacherService(IRepository<SubjectTeacher> irepository)
        {
            _Irepository = irepository ?? throw new ArgumentNullException(nameof(irepository));
        }

        public async Task<bool> AddingSubjectTeacher(SubjectTeacherViewModel addingSubjectTeacher)
        {
            var newSubjectTeacher = new SubjectTeacher();
            newSubjectTeacher.IdSubject = addingSubjectTeacher.IdSubject;
            newSubjectTeacher.IdTeacher = addingSubjectTeacher.IdTeacher;
            newSubjectTeacher.AddingTime = addingSubjectTeacher.AddingTime;
            newSubjectTeacher.Status = addingSubjectTeacher.Status;
            try
            {
                await _Irepository.AddAsync(newSubjectTeacher);
                await _Irepository.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteSubjectTeacher(Guid IdTeacher, Guid IdSubject)
        {
            var listSubjectTeacher = _Irepository.AsQueryable().ToList();

            var listDelete = listSubjectTeacher.Where(c => c.IdTeacher == IdTeacher && IdSubject == IdSubject).ToList();
            try
            {
                await _Irepository.RemoveRangeAsync(listDelete);
                await _Irepository.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<SubjectTeacherViewModel>> SearchSubjectTeacher(Guid IdTeacher, Guid IdSubject)
        {

            var listSubjectTeacher = _Irepository.AsQueryable().ToList();
            if (IdTeacher != Guid.Empty && IdSubject != Guid.Empty)
            {
                var resuals = listSubjectTeacher.Where(c => c.IdSubject == IdSubject && c.IdTeacher == IdTeacher)
                    .Select(x => new SubjectTeacherViewModel()
                {
                    IdSubject = x.IdSubject,
                    IdTeacher = x.IdTeacher,
                    AddingTime = x.AddingTime,
                    Status = x.Status
                }).ToList();
                return resuals;
            }
            else if (IdTeacher != Guid.Empty && IdSubject == Guid.Empty)
            {
                var resuals = listSubjectTeacher.Where(c => c.IdTeacher == IdTeacher)
                   .Select(x => new SubjectTeacherViewModel()
                   {
                       IdSubject = x.IdSubject,
                       IdTeacher = x.IdTeacher,
                       AddingTime = x.AddingTime,
                       Status = x.Status
                   }).ToList();
                return resuals;
            }
            else if (IdTeacher == Guid.Empty && IdSubject != Guid.Empty)
            {
                var resuals = listSubjectTeacher.Where(c => c.IdSubject == IdSubject)
                   .Select(x => new SubjectTeacherViewModel()
                   {
                       IdSubject = x.IdSubject,
                       IdTeacher = x.IdTeacher,
                       AddingTime = x.AddingTime,
                       Status = x.Status
                   }).ToList();
                return resuals;
            }
            else
            {
                var resuals = listSubjectTeacher.Select(x => new SubjectTeacherViewModel()
                {
                    IdSubject = x.IdSubject,
                    IdTeacher = x.IdTeacher,
                    AddingTime = x.AddingTime,
                    Status = x.Status
                }).ToList();
                return resuals;
            }
        }

        public async Task<bool> UpdateSubjectTeacher(SubjectTeacherViewModel updateSubjectTeacher)
        {
            try
            {
                var updateSTeacher = _Irepository.AsQueryable().ToList()
                    .FirstOrDefault(c =>c.IdSubject == updateSubjectTeacher.IdSubject && c.IdTeacher == updateSubjectTeacher.IdTeacher);

                updateSTeacher.AddingTime = updateSubjectTeacher.AddingTime;
                updateSTeacher.Status = updateSubjectTeacher.Status;
                await _Irepository.UpdateAsync(updateSTeacher);
                await _Irepository.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
