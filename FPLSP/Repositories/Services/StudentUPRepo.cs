using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Dtos.StudentStatisticVM;
using FPLSP.Server.Domain.Dtos.StudentUPDtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.StudentStatistics;
using FPLSP.Server.Infrastructure.ViewModels.StudentsUPVm;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class StudentUPRepo : IStudentUPRepo
    {
        private readonly HttpClient _client;

        public StudentUPRepo(HttpClient client)
        {
            _client = client;
        }

        public async Task<int> CreateStudentUP(StudentUPCreateVm student)
        {
            var result = await _client.PostAsJsonAsync("/api/student", student);
            if (result != null)
            {
                return 1;
            }
            return 0;
        }

        public async Task<int> CreateStudentUPstudentInClass(StudentUpDto studentInClassCreate)
        {
            var url = Path.Combine($"/api/StudentClassUPs/createStudentInClass");
            var result = await _client.PostAsJsonAsync(url, studentInClassCreate);
            if (result != null)
            {
                return 1;
            }
            return 0;
        }

        public async Task<int> DeleteStudentUP(Guid id)
        {
            var result = await _client.DeleteAsync($"/api/Student/{id}");
            if (result != null)
            {
                return 1;
            }
            return 0;
        }
        public async Task<int> RemoveRangeStudentUP(StudentRemovRangeVM id)
        {
            var result = await _client.PostAsJsonAsync($"/api/Student/RemoveRange", id);
            if (result != null)
            {
                return 1;
            }
            return 0;
        }

        public async Task<List<StudentUP>> GetAllStudentAsync()
        {
            var url = Path.Combine("/api/Student/all");

            var result = await _client.GetFromJsonAsync<List<StudentUP>>(url);
            return result;
        }

        public async Task<List<StudentUpDto>> GetAllStudentDtosAsync()
        {
            var url = Path.Combine("/api/Student/allStudentDto");

            var result = await _client.GetFromJsonAsync<List<StudentUpDto>>(url);
            return result;
        }
        public async Task<List<StudentUP>> GetAllStudentUPAsync()
        {
            var result = await _client.GetFromJsonAsync<List<StudentUP>>(("/api/Student/all"));
            return result;
        }

        public async Task<StudentUP> GetMaxIdStudentUP()
        {
            var url = Path.Combine("/api/Student/maxId");
            var result = await _client.GetFromJsonAsync<StudentUP>(url);
            return result;
        }


        public async Task<StudentUpDto> GetStudentUPById(Guid id)
        {
            var url = Path.Combine("api/Student", id.ToString());

            var result = await _client.GetFromJsonAsync<StudentUpDto>(url);

            return result;
        }

        public async Task<PageList<StudentUpDto>> GetStudentUPList(StudentUPListSearchVm student)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = student.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(student.NameStudent))
            {
                queryStringParam.Add("NameStudent", student.NameStudent);
            }
            if (!string.IsNullOrEmpty(student.Status))
            {
                queryStringParam.Add("Status", student.Status);
            }
            string url = QueryHelpers.AddQueryString("/api/Student", queryStringParam);

            var result = await _client.GetFromJsonAsync<PageList<StudentUpDto>>(url);

            return result;
        }

        public async Task<int> UpdateStudentUP(Guid id, StudentUpdateVM student)
        {

            //var url = Path.Combine("/api/Student", id.ToString());
            var putResult = await _client.PutAsJsonAsync($"/api/Student/{id}", student);
            if (putResult.IsSuccessStatusCode)
                return 1;

            return 0;
        }

        public async Task<PageList<StudentStatisticsDtos>> StudentStatisticsDtos(Guid idclass, Guid idsubject, StudentStatisticListSearch studentParameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = studentParameters.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(studentParameters.Masv))
            {
                queryStringParam.Add("masv", studentParameters.Masv);
            }
            if (!string.IsNullOrEmpty(studentParameters.trangthai))
            {
                queryStringParam.Add("trangthai", studentParameters.trangthai);
            }

            string url = QueryHelpers.AddQueryString($"/api/Student/getall/{idclass}/{idsubject}", queryStringParam);

            var result = await _client.GetFromJsonAsync<PageList<StudentStatisticsDtos>>(url);

            return result;
        }

        public async Task<PageList<StudentStatisticsDtos>> QuizStatisticsDtos(Guid idclass, Guid idsubject, StudentStatisticListSearch studentParameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = studentParameters.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(studentParameters.Masv))
            {
                queryStringParam.Add("masv", studentParameters.Masv);
            }
            if (!string.IsNullOrEmpty(studentParameters.quizid))
            {
                queryStringParam.Add("quizid", studentParameters.quizid);
            }

            string url = QueryHelpers.AddQueryString($"/api/Student/getall/quiz/{idclass}/{idsubject}", queryStringParam);

            var result = await _client.GetFromJsonAsync<PageList<StudentStatisticsDtos>>(url);

            return result;
        }

        public async Task<ListIdStudent> GetListIdStudents(Guid idclass)
        {
            var url = Path.Combine($"/api/Student/getall/list/{idclass}");

            var result = await _client.GetFromJsonAsync<ListIdStudent>(url);

            return result;
        }
        public async Task<Thongtinlop> Thongtinlop(Guid id, Guid idsubject)
        {
            var url = Path.Combine($"/api/Student/get/thongtin/lop/{id}/{idsubject}");

            var result = await _client.GetFromJsonAsync<Thongtinlop>(url);

            return result;
        }
    }
}
