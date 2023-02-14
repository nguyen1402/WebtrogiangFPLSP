using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop;
using FPLSP.Server.Infrastructure.ViewModels.Subject;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectUPsController : ControllerBase
    {
        private readonly ISubjectUPServices _subjectUPServices;

        public SubjectUPsController(ISubjectUPServices subjectUPServices)
        {
            _subjectUPServices = subjectUPServices ?? throw new ArgumentNullException(nameof(subjectUPServices));
        }
        [HttpGet("all/{idspecializedUP}")]
        public async Task<IActionResult> GetList(Guid idspecializedUP, [FromQuery] SubjectListSearch subjectParameters)
        {
            var pagelist = await _subjectUPServices.GetSubjects(idspecializedUP, subjectParameters);

            return Ok(pagelist);
        }  
        [HttpGet("GetAllSubjectbyIdLecture/{idLecture}")]
        public async Task<IActionResult> GetList(Guid idLecture)
        {
            var GetAllSubject = await _subjectUPServices.GetAllSubjectbyIdLecture(idLecture);

            return Ok(GetAllSubject);
        }
        [HttpGet("getall/{lectuterId}/{idspec}")]
        public async Task<IActionResult> GetAllLectuterSpecializedSubject([FromQuery] SubjectListSearch subjectParameters, Guid lectuterId, Guid? idspec)
        {
            var pagelist = await _subjectUPServices.GetAllLectuterSpecializedSubject(subjectParameters, lectuterId, idspec);

            var subjectDtos = pagelist.Items.Select(c => new LectuterSpecializedSubjectVM()
            {
                LectuterId = c.LectuterId,
                SpecializedId = c.SpecializedId,
                SubjectId = c.SubjectId,
                SpecializationName = c.SpecializationName,
                SubjectName = c.SubjectName,
                StartDay = c.StartDay,
                EndDay = c.EndDay,
                TotalOfSub = c.TotalOfSub,

                LecturersName = c.LecturersName,
                Gender = c.Gender,
                Dob = c.Dob,
                Email = c.Email,
                PhoneNumber = c.PhoneNumber,
                Address = c.Address,
                ImageUrl = c.ImageUrl,
            });
            return Ok(new PageList<LectuterSpecializedSubjectVM>(subjectDtos.ToList(),
                pagelist.MetaData.TotalCount,
                pagelist.MetaData.CurrentPage,
                pagelist.MetaData.PageSize));
        }
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var subjectDtos = await _subjectUPServices.GetAllSubjectAsync();

            return Ok(subjectDtos);
        }

        [HttpGet("all/timkiem")]
        public async Task<IActionResult> GetTimKiem([FromQuery] SubjectListSearchMonDeThi mon)
        {
            var pagelist = await _subjectUPServices.GetAllSubjectAsync2(mon);

            var subjectDtosa = pagelist.Items.Select(c => new SubjectDto()
            {
                Id = c.Id,
                SubjectCode = c.SubjectCode,
                SubjectName = c.SubjectName,
                CreatedDay = c.CreatedDay,
                StartDay = c.StartDay,
                Image = c.Image,
                EndDay = c.EndDay,
                TotalOfSub = c.TotalOfSub,
                Status = c.Status,
                Soluongdethi = c.Soluongdethi,
            });
            return Ok(new PageList<SubjectDto>(subjectDtosa.ToList(),
                pagelist.MetaData.TotalCount,
                pagelist.MetaData.CurrentPage,
                pagelist.MetaData.PageSize));
        }
        [HttpGet("all/isdemo")]
        public async Task<IActionResult> GetAllIsDemo()
        {
            var subjectDtos = await _subjectUPServices.GetAllSubjectIsdemo();

            return Ok(subjectDtos);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetbyId(Guid id)
        {
            var subject = await _subjectUPServices.GetSubjectbyId(id);
            return Ok(subject);
        }
        [HttpPost("{idspecializedUP}")]
        public async Task<IActionResult> CreateSubject(Guid idspecializedUP, [FromBody] SubjectCreateVM subject)
        {
            if (subject == null)
                return BadRequest();

            var result = await _subjectUPServices.CreateSubject(idspecializedUP, subject);
            if (!result)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateSubject(Guid Id, [FromBody] SubjectUpdateVM subject)
        {
            if (subject == null)
                return BadRequest();

            var result = await _subjectUPServices.UpdateSubject(Id, subject);
            if (!result)
            {
                return BadRequest(result);
            }
            return Ok();
        }
        [HttpDelete("{idspecializedUP}/{id}")]
        public async Task<IActionResult> DeleteSubject(Guid idspecializedUP, Guid id)
        {
            if (id == null)
                return BadRequest();

            var result = await _subjectUPServices.DeleteSubject(idspecializedUP, id);
            if (!result)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPut("deletelist")]
        public async Task<IActionResult> DeleteListSubjectUP([FromBody] List<Guid> idsubjectUP)
        {
            var result = await _subjectUPServices.DeleteListSubjectUP(idsubjectUP);
            return Ok(result);
        }
    }
}
