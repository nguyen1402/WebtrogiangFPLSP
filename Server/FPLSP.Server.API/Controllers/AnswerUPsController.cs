using FPLSP.Server.Domain.Dtos.AnswerUPDtos;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.AnswerUp;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerUPsController : ControllerBase
    {
        private readonly IAnswerUPServices _answerUPServices;
        public AnswerUPsController(IAnswerUPServices answerUPServices)
        {
            _answerUPServices = answerUPServices ?? throw new ArgumentNullException(nameof(answerUPServices));
        }
        [HttpGet]
        public async Task<IQueryable<AnswerUPDto>> GetAll()
        {
            return await _answerUPServices.GetAll();
        }
        [HttpGet]
        [Route("{Id}")]
        public async Task<AnswerUpVm> GetDetails([FromRoute] Guid Id)
        {
            return await _answerUPServices.GetDetails(Id);
        }
        [HttpPost]
        public async Task<bool> AddAnswer([FromBody] AnswerUpVm answerUpVm)
        {
            return await _answerUPServices.AddAnswer(answerUpVm);
        }
        [HttpPut]
        [Route("{Id}")]
        public async Task<bool> Update([FromRoute] Guid Id, AnswerUpVm answerUpVm)
        {
            return await _answerUPServices.Update(Id, answerUpVm);
        }
        [HttpDelete]
        [Route("{Id}")]
        public async Task<bool> Delete([FromRoute] Guid Id)
        {
            return await _answerUPServices.Delete(Id);
        }
    }
}
