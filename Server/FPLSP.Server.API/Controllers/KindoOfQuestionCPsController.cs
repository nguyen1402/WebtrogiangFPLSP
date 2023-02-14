using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.KindOfQuestionCPDtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.KìnOfQuestionCPVm;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KindoOfQuestionCPsController : ControllerBase
    {
        private readonly IKindoOfQuestionCPServices _koqCPServices;
        private readonly ILogger<KindoOfQuestionCPsController> _logger;

        public KindoOfQuestionCPsController(IKindoOfQuestionCPServices koqCPServices, ILogger<KindoOfQuestionCPsController> logger)
        {
            _koqCPServices = koqCPServices ?? throw new ArgumentNullException(nameof(koqCPServices));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpPost]
        public async Task<IActionResult> CreateKOQCP([FromBody] KindOfQuestionCPVm koq)
        {
            if (koq == null)
                return BadRequest();

            var newsquiz = await _koqCPServices.CreateKOQCP(koq);

            if (newsquiz != 1)
            {
                return BadRequest(newsquiz);
            }
            return Ok(newsquiz);
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] ListKOQCPSearch koq)
        {
            var pagelist = await _koqCPServices.GetKOQList(koq);

            var MonhocDTOs = pagelist.Items.Select(c => new KindOfQuestionCPDtos()
            {
                Id = c.Id,
                QuestionTypeName = c.QuestionTypeName,
                QuestionForm = c.QuestionForm
            });
            return Ok(new PageList<KindOfQuestionCPDtos>(MonhocDTOs.ToList(),
                pagelist.MetaData.TotalCount,
                pagelist.MetaData.CurrentPage,
                pagelist.MetaData.PageSize));
        }
        [HttpGet("GetAllKoq")]
        public async Task<IActionResult> GetAllKoq()
        {
            var list = await _koqCPServices.GetAllKoq();
            return Ok(list);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateKOQCP(Guid id, [FromBody] KindOfQuestionCPVm koq)
        {

            if (koq == null)
                return BadRequest();

            var kq = await _koqCPServices.UpdateKOQCP(id, koq);
            if (kq != 1)
            {
                return BadRequest(kq);
            }
            return Ok(kq);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetQuizById([FromRoute] Guid id)
        {
            var student = await _koqCPServices.GetKOQCPbyId(id);
            if (student == null) return NotFound($"{id} is not found");
            return Ok(student);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuizCP(Guid id)
        {
            if (id == null)
                return BadRequest();

            var result = await _koqCPServices.DeleteKOQCP(id);
            if (result != 1)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
