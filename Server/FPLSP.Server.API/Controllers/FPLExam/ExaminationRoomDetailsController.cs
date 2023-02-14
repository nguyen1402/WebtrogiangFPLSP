using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers.FPLExam
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExaminationRoomDetailsController : ControllerBase
    {

        private readonly IExaminationRoomDetailServices _examinationRoomDetail;
        public ExaminationRoomDetailsController(IExaminationRoomDetailServices examinationRoomDetail)
        {
            _examinationRoomDetail = examinationRoomDetail;
        }
        [HttpGet]
        [Route("GetAllExamRoomDetail")]
        public async Task<IActionResult> GetAllExamRoomDetail()
        {

            var res = await _examinationRoomDetail.GetAllExaminationRoomDetail();
            return Ok(res);
        }

        [HttpGet]
        [Route("examroomdetail-GetAllLectureAddExam")]
        public async Task<IActionResult> GetAllLectureAddExam()
        {
            var res = await _examinationRoomDetail.GetAllLectureAddExam();
            return Ok(res);
        }
        [HttpGet]
        [Route("examroomdetail-paging")]
        public async Task<IActionResult> GetAllExamRoomDetailPaging([FromRoute] ExamRoomDetailSearch examRoomDetailSearch)
        {

            var res = await _examinationRoomDetail.GetALlOfficialExaminationroom(examRoomDetailSearch);
            return Ok(res);
        }

        [HttpGet]
        [Route("examroomdetail-forsupervisior/{Id}")]
        public async Task<IActionResult> GetAllExamRoomDetailForSup([FromRoute] Guid Id)
        {

            var res = await _examinationRoomDetail.GetALlOfficialForSupervisor(Id);
            return Ok(res);
        }
        [HttpGet]
        [Route("examroomdetail-forstudent/{Id}")]
        public async Task<IActionResult> GetAllExamRoomDetailForStudent([FromRoute] Guid Id)
        {

            var res = await _examinationRoomDetail.GetALlOfficialForStudent(Id);
            return Ok(res);
        }
        [HttpGet]
        [Route("examroomdetail-forsubject/{Id}")]
        public async Task<IActionResult> GetAllExamRoomDetailForSubject([FromRoute] Guid Id)
        {

            var res = await _examinationRoomDetail.GetExamFileForSubject(Id);
            return Ok(res);
        }
        [HttpGet]
        [Route("examroomdetailbysecret/{secret}")]
        public async Task<IActionResult> GetAllExamRoomDetailForSubject([FromRoute] string secret)
        {

            var res = await _examinationRoomDetail.GetExaminamRoomDetailBySecret(secret);
            return Ok(res);
        }
        [HttpPost]
        [Route("examroomdetail-addingrange")]
        public async Task<IActionResult> AddingRangeExamRoomDtail([FromBody] ExamDetaiRoomForAdding detaiRoomForAdding)
        {

            var res = await _examinationRoomDetail.AddingRangeExamRoomDtail(detaiRoomForAdding);
            return Ok(res);
        }
        [HttpPut]
        [Route("examroomdetail-updating")]
        public async Task<IActionResult> UpdatingExamRoomDtail([FromBody] ExaminationRoomDetailViewModel examinationRoomDetailView)
        {

            var res = await _examinationRoomDetail.UpdatingExamRoomDtail(examinationRoomDetailView);
            return Ok(res);
        }

        [HttpPut]
        [Route("examroomdetail-delete")]
        public async Task<IActionResult> DeletingExamRoomDtail([FromBody] ExaminationRoomDetailViewModel examinationRoomDetailView)
        {

            var res = await _examinationRoomDetail.DeletingExamRoomDtail(examinationRoomDetailView);
            return Ok(res);
        }

        [HttpPut]
        [Route("examroomdetail-autohide")]
        public async Task<IActionResult> AutoHideExamRoomDtail([FromBody] ExaminationRoomDetailViewModel examinationRoomDetailView)
        {

            var res = await _examinationRoomDetail.AutoHideExamRoomDtail(examinationRoomDetailView);
            return Ok(res);
        }
        //
        [HttpGet]
        [Route("showexamfile/{secret}")]
        public async Task<IActionResult> ExamShowing([FromRoute] string secret)
        {

            var res = await _examinationRoomDetail.GetExamFileBySerceate(secret);
            return Ok(res);
        }
    }
}
