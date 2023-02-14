using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.ImagesCP;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services
{
    public class ImageCPRepo : IImageCPRepo
    {
        public ImageCPRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public HttpClient _httpClient { get; set; }


        public async Task<bool> CreateImageCP(ImageCPCreateVm CreateVm)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/ImageCPs", CreateVm);
            return result.IsSuccessStatusCode;
        }



        public async Task<bool> DeleteImageCP(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"/api/ImageCPs/{id}");
            return result.IsSuccessStatusCode;
        }

        public async Task<ImageCP> GetImageCPById(Guid Id)
        {
            var url = Path.Combine("/api/ImageCPs", Id.ToString());
            var result = await _httpClient.GetFromJsonAsync<ImageCP>(url);
            return result;
        }

        public async Task<PageList<ImageCPDto>> GetImageCPList(ImageCPListSearchVm ListSearch)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = ListSearch.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(ListSearch.Path))
            {
                queryStringParam.Add("ExamLinkCode", ListSearch.Path);
            }
            if (!string.IsNullOrEmpty(ListSearch.Descriptions))
            {
                queryStringParam.Add("Path", ListSearch.Descriptions);
            }
            if (ListSearch.Status != null)
            {
                queryStringParam.Add("Status", ListSearch.Status.ToString());
            }
            string url = QueryHelpers.AddQueryString("/api/ImageCPs", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PageList<ImageCPDto>>(url);
            return result;
        }

        public async Task<PageList<ImageCPDto>> GetImageCPListByExamId(Guid Id, ImageCPListSearchVm ListSearch)
        {
            string Getid = Id.ToString();
            var result = await _httpClient.GetFromJsonAsync<PageList<ImageCPDto>>($"/api/ImageCPs/{Getid}");
            return result;
        }


        public async Task<bool> UpdateImageCP(Guid id, ImageCPUpdateVm UpdateVm)
        {
            string oker = id.ToString();
            var result = await _httpClient.PutAsJsonAsync($"/api/ImageCPs/{oker}", UpdateVm);

            return result.IsSuccessStatusCode;
        }
    }
}
