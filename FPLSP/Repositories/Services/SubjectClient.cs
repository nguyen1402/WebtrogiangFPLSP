using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.Subject;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories
{
    public class SubjectClient : ISubjectClient
    {
        private readonly HttpClient _client;

        public SubjectClient(HttpClient client)
        {
            _client = client;
        }
        public async Task<int> CreateSubject(SubjectCreateVM subject)
        {

            var postResult = await _client.PostAsJsonAsync("/api/Subjects", subject);
            if (postResult.IsSuccessStatusCode)
                return 1;

            return 0;
        }

        public async Task<int> DeleteSubject(Guid id)
        {
            var url = Path.Combine("/api/Subjects", id.ToString());

            var deleteResult = await _client.DeleteAsync(url);
            if (!deleteResult.IsSuccessStatusCode)
            {
                return 0;
            }
            return 1;
        }

        public async Task<List<SubjectDto>> GetAllSubjectAsync()
        {
            var url = Path.Combine("/api/Subjects/all");

            var result = await _client.GetFromJsonAsync<List<SubjectDto>>(url);
            return result;
        }
        public async Task<List<SubjectDto>> GetAllSubjectByIdSpecialzed(Guid idspecialzed)
        {
            var url = Path.Combine("/api/Subjects/allsubjectbyidspecialzed/" + idspecialzed.ToString());

            var result = await _client.GetFromJsonAsync<List<SubjectDto>>(url);
            return result;
        }

        public async Task<SubjectDto> GetSubjectbyId(Guid id)
        {
            var url = Path.Combine("/api/Subjects", id.ToString());

            var result = await _client.GetFromJsonAsync<SubjectDto>(url);
            return result;
        }
         public async Task<SubjectUpdateVM> GetUpdateSubjectbyId(Guid idupdate)
        {
            var url = Path.Combine("/api/Subjects/GetUpdateSubjectbyId", idupdate.ToString());
            var result = await _client.GetFromJsonAsync<SubjectUpdateVM>(url);
            return result;
        }


        public async Task<PageList<SubjectDto>> GetSubjects(Guid specid, SubjectCPSearch subjectParameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = subjectParameters.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(subjectParameters.Name))
                queryStringParam.Add("Name", subjectParameters.Name);
            if (!string.IsNullOrEmpty(subjectParameters.Status.ToString()))
                queryStringParam.Add("Status", subjectParameters.Status.ToString());
            if (!string.IsNullOrEmpty(subjectParameters.SubjectCode))
                queryStringParam.Add("SubjectCode", subjectParameters.SubjectCode);  
          

            string url = QueryHelpers.AddQueryString($"/api/Subjects/all/{specid}", queryStringParam);

            var result = await _client.GetFromJsonAsync<PageList<SubjectDto>>(url);

            return result;
        }

        public async Task<int> UpdateSubject(Guid id, SubjectUpdateVM subject_update)
        {
            var url = Path.Combine("/api/Subjects", id.ToString());
            var putResult = await _client.PutAsJsonAsync(url, subject_update);
            if (putResult.IsSuccessStatusCode)
                return 1;

            return 0;
        }

        public async Task<string> UploadProductImage(MultipartFormDataContent content)
        {
            var postResult = await _client.PostAsync("/api/Uploads", content);
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
        public async Task<bool> RemoveListSubjectCP(List<Guid> listIdSubject)
        {
            var result = await _client.PostAsJsonAsync($"/api/Subjects/deletelist/", listIdSubject);
            return result.IsSuccessStatusCode;
        }
    }
}
