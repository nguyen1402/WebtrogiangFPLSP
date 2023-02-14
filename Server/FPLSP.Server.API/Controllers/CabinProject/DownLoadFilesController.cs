using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers.CabinProject
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownLoadFilesController : ControllerBase
    {


        [HttpGet("DownloadServerFile")]
        public async Task<string> DownloadServerFile()
        {
            var filePath = @"wwwroot/files/TemplateTeachingSchedule.xlsx";

            using (var fileInput = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                MemoryStream memoryStream = new MemoryStream();
                await fileInput.CopyToAsync(memoryStream);

                var buffer = memoryStream.ToArray();
                return Convert.ToBase64String(buffer);
            }
        }
    }
}
