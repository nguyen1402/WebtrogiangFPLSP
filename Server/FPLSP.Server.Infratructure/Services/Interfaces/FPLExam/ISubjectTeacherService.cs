﻿using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam
{
    public interface ISubjectTeacherService
    {
        Task<bool> AddingSubjectTeacher(SubjectTeacherViewModel addingSubjectTeacher);
        Task<bool> UpdateSubjectTeacher(SubjectTeacherViewModel updateSubjectTeacher);
        Task<bool> DeleteSubjectTeacher(Guid IdTeacher, Guid IdSubject);
        Task<List<SubjectTeacherViewModel>> SearchSubjectTeacher(Guid IdTeacher, Guid IdSubject);
    }
}
