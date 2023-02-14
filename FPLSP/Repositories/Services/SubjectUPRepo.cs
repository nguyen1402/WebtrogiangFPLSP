using DocumentFormat.OpenXml.Spreadsheet;
using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop;
using FPLSP.Server.Infrastructure.ViewModels.Subject;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class SubjectUPRepo : ISubjectUPRepo
    {
        private readonly HttpClient _httpClient;

        public SubjectUPRepo(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<bool> CreateSubject(Guid idspecializedUP, SubjectCreateVM subject)
        {
            var postResult = await _httpClient.PostAsJsonAsync($"/api/subjectups/{idspecializedUP}", subject);
            if (postResult.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<bool> DeleteSubject(Guid idspecializedUP, SubjectDto subject_delete)
        {
            var url = Path.Combine($"/api/subjectups/{idspecializedUP}", subject_delete.Id.ToString());

            var deleteResult = await _httpClient.DeleteAsync(url);
            if (deleteResult.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<List<SubjectDto>> GetAllSubjectAsync()
        {
            var url = Path.Combine("/api/subjectups/all");

            var result = await _httpClient.GetFromJsonAsync<List<SubjectDto>>(url);
            return result;
        }

        public async Task<PageList<SubjectDto>> GetAllSubjectAsync2(SubjectListSearchMonDeThi mon)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = mon.PageNumber.ToString(),
            };
            if (!string.IsNullOrEmpty(mon.namemon))
                queryStringParam.Add("namemon", mon.namemon);

            var url = QueryHelpers.AddQueryString($"/api/subjectups/all/timkiem/", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<SubjectDto>>(url);
            return result;
        }

        public async Task<SubjectDto> GetSubjectbyId(Guid id)
        {
            var url = Path.Combine("/api/subjectups", id.ToString());

            var result = await _httpClient.GetFromJsonAsync<SubjectDto>(url);
            return result;
        }  
        public async Task<List<SubjectUP>> GetAllSubjectbyIdLecture(Guid idLecture)
        {
            var url = Path.Combine("/api/subjectups/GetAllSubjectbyIdLecture", idLecture.ToString());

            var result = await _httpClient.GetFromJsonAsync<List<SubjectUP>>(url);
            return result;
        }
        public async Task<PageList<LectuterSpecializedSubjectVM>> GetAllLectuterSpecializedSubject(SubjectListSearch subjectParameters, Guid lectuterId, Guid? idspec)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["name"] = subjectParameters.Name,
                ["pageNumber"] = subjectParameters.PageNumber.ToString(),
                ["subjectcode"] = subjectParameters.SubjectCode,
            };
            string url = QueryHelpers.AddQueryString($"/api/SubjectUPs/getall/{lectuterId}/{idspec}", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<LectuterSpecializedSubjectVM>>(url);

            return result;
        }
        public async Task<PageList<SubjectDto>> GetSubjects(Guid idspecializedUP, SubjectListSearch subjectParameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["name"] = subjectParameters.Name,
                ["pageNumber"] = subjectParameters.PageNumber.ToString(),
                ["subjectcode"] = subjectParameters.SubjectCode,
                ["status"] = subjectParameters.Status.ToString(),
            };
            string url = QueryHelpers.AddQueryString($"/api/subjectups/all/{idspecializedUP}", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<SubjectDto>>(url);

            return result;
        }

        public async Task<bool> UpdateSubject(Guid Id, SubjectUpdateVM subject)
        {
            var putResult = await _httpClient.PutAsJsonAsync($"/api/subjectups/{Id}", subject);
            return putResult.IsSuccessStatusCode;

        }

        public async Task<string> UploadProductImage(MultipartFormDataContent content)
        {
            var postResult = await _httpClient.PostAsync("/api/uploads", content);
            var postContent = await postResult.Content.ReadAsStringAsync();
            if (!postResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(postContent);
            }
            else
            {
                var imgUrl = Path.Combine("https://localhost:5001/", postContent);
                return imgUrl;
            }
        }

        public async Task<bool> DeleteListSubject(List<Guid> idsubjectUP)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/subjectups/deletelist", idsubjectUP);
            return result.IsSuccessStatusCode;
        }
    }
}
