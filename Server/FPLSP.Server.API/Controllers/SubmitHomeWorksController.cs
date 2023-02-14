using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.SubmitHomeWorkVM;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubmitHomeWorksController : ControllerBase
    {
        private readonly ISubmitHomeWorkServices _repo;
        private readonly IStudentSubmitHomeWork _ISubmit;
        public SubmitHomeWorksController(ISubmitHomeWorkServices repo, IStudentSubmitHomeWork iSubmit)
        {
            _repo = repo;
            _ISubmit = iSubmit;
        }
        [HttpGet("getall/tatca")]
        public async Task<IActionResult> GetAlTca()
        {
            var pagel = await _repo.GetAll();
            return Ok(pagel);
        }
        
        [HttpGet("getall/{idclass}/{idlesson}")]
        public async Task<IActionResult> Get(Guid idclass, Guid idlesson, [FromQuery] ListSubmitHomeWorkSeach parameters)
        {
            var pagel = await _repo.ThongkeNopbai(parameters, idclass, idlesson);
            var data = pagel.Items.Select(x => new SubmitHomeWorkDtos()
            {
                Id = x.Id,
                IdClass = x.IdClass,
                IdLesson = x.IdLesson,
                IdStudent = x.IdStudent,
                Status = x.Status,
                SubmitLink = x.SubmitLink,
                StudentCode = x.StudentCode,
                StudentName = x.StudentName
            });
            return Ok(new PageList<SubmitHomeWorkDtos>(data.ToList(),
                pagel.MetaData.TotalCount,
                pagel.MetaData.CurrentPage,
                pagel.MetaData.PageSize));
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SubmitHomeWorkCreateVM modelcreate)
        {
            if (modelcreate == null)
                return BadRequest();

            var kq = await _repo.Add(modelcreate);
            if (kq != 1)
            {
                return BadRequest(kq);
            }
            return Ok(kq);
        }
        [HttpDelete]
        [Route("{idClass}/{idSubject}/{idStudent}")]
        public async Task<IActionResult> Delete(Guid idClass, Guid idSubject, Guid idStudent)
        {
            var delete = await _repo.DeleteSubmit(idClass, idSubject, idStudent);
            return Ok(delete);

        }

        [HttpPost]
        [Route("add-multiple-deadline")]
        public async Task<IActionResult> AddMultipleDeadLine([FromBody] ListHomeWorkForStudent listHomeWorkFor)
        {
            if (listHomeWorkFor == null)
                return BadRequest();

            var kq = await _ISubmit.AddHomeWorkForClass(listHomeWorkFor);

            return Ok(kq);
        }
    }
}
