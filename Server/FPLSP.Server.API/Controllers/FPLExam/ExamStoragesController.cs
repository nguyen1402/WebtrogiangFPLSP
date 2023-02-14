using FPLSP.Server.Infrastructure.Services.Implements;
using FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace FPLSP.Server.API.Controllers.FPLExam
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamStoragesController : ControllerBase
    {
        private readonly IExamFileServices _examFileServices;
        private readonly IHubContext<NotificationHub> _hubContext;
        public ExamStoragesController(IExamFileServices examFileServices, IHubContext<NotificationHub> hubContext)
        {
            _examFileServices = examFileServices;
            _hubContext = hubContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllExamFile()
        {

            var res = await _examFileServices.GetAllExamFiles();
            return Ok(res);
        }

        [HttpGet]
        [Route("examfile-paging")]
        public async Task<IActionResult> GetAllExamFilePaging([FromQuery] ExamFileSearch examFileSearch)
        {

            var res = await _examFileServices.GetFileForPaging(examFileSearch);
            return Ok(res);
        }

        [HttpGet]
        [Route("examfile-forlecsub/{Idlec}/{IdSubject}")]
        public async Task<IActionResult> GetAllExamFilePagingForLecSub(Guid Idlec, Guid IdSubject)
        {

            var res = await _examFileServices.GetAllExamFilesForLectuterSubject(Idlec, IdSubject);
            return Ok(res);
        }


        [HttpGet]
        [Route("examfile-foronlysub/{IdSubject}")]
        public async Task<IActionResult> GetAllExamFilePagingForOnlySub(Guid IdSubject)
        {

            var res = await _examFileServices.GetAllExamFilesForOnlySubject(IdSubject);
            return Ok(res);
        }


        [HttpGet]
        [Route("examfile-foronlylec/{Idlec}")]
        public async Task<IActionResult> GetAllExamFilePagingForOnlyLec(Guid Idlec)
        {

            var res = await _examFileServices.GetAllExamFilesForLectuer(Idlec);
            return Ok(res);
        }

        [HttpGet]
        [Route("examfile-byid/{idsubject}")]
        public async Task<IActionResult> GetAllExamFileBydIdSubject(Guid idsubject)
        {
            var res = await _examFileServices.GetAllExamFilesBySubjectId(idsubject);
            return Ok(res);
        }


        [HttpPost]
        [Route("examfile-adding")]
        public async Task<IActionResult> AddingExamFiles([FromBody] List<ExamStorageViewModel> examStorageViewModels)
        {

            var res = await _examFileServices.AddMultipleExamFile(examStorageViewModels);
            if (res)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("ExamStorages", responsemess);
            }
            return Ok(res);
        }
        [HttpPut]
        [Route("examfile-updating")]
        public async Task<IActionResult> UpdatingExamFiles([FromBody] ExamStorageViewModel examStorageViewModels)
        {

            var res = await _examFileServices.UpdateExamFile(examStorageViewModels);
            return Ok(res);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteExamFiles([FromRoute] Guid id)
        {

            var res = await _examFileServices.DeleteExamFile(id);
            if (res)
            {
                var responsemess = "Done";
                await _hubContext.Clients.All.SendAsync("ExamStorages", responsemess);
            }
            return Ok(res);

        }

        [HttpPut]
        [Route("fastupdate-examfile")]
        public async Task<IActionResult> QuickChange([FromBody] Guid Id)
        {

            var res = await _examFileServices.UpdateFastExamFile(Id);
            return Ok(res);
        }

        [HttpPut]
        [Route("quickchange/{Id}")]
        public async Task<IActionResult> QuickChange([FromRoute] Guid Id, [FromBody] int status)
        {

            var res = await _examFileServices.QuickChangeExamFile(Id, status);
            return Ok(res);
        }
    }
}
