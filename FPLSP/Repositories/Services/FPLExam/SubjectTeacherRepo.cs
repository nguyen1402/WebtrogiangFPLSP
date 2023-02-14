using FPLSP.Repositories.Interfaces.FPLExam;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FPLSP.Repositories.Services.FPLExam
{
    public class SubjectTeacherRepo : ISubjectTeacherRepo
    {
        private static HttpClient _httpClient;
        public SubjectTeacherRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> AddingSubjectTeacher(SubjectTeacherViewModel addingSubjectTeacher)
        {
            var res = await _httpClient.PostAsJsonAsync("/api/SubjectTeachers/", addingSubjectTeacher);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteSubjectTeacher(Guid IdTeacher, Guid IdSubject)
        {
            var res = await _httpClient.DeleteAsync($"/api/SubjectTeachers/{IdTeacher}/{IdSubject}");
            return res.IsSuccessStatusCode;
        }

        public async Task<List<SubjectTeacherViewModel>> SearchSubjectTeacher(Guid IdTeacher, Guid IdSubject)
        {

            var res = await _httpClient.GetFromJsonAsync<List<SubjectTeacherViewModel>>($"/api/SubjectTeachers/{IdTeacher}/{IdSubject}");
            return res;
        }

        public async Task<bool> UpdateSubjectTeacher(SubjectTeacherViewModel updateSubjectTeacher)
        {
            var res = await _httpClient.PutAsJsonAsync("/api/SubjectTeachers/", updateSubjectTeacher);
            return res.IsSuccessStatusCode;
        }
    }
}
