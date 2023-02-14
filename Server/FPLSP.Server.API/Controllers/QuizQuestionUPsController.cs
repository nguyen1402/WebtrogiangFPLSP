using FPLSP.Server.Domain.Dtos.QuizQuestionUPDto;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuestionUp;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizQuestionUPsController : ControllerBase
    {
        private IQuizQuestionUPServices _quizQuestionUPServices;
        public QuizQuestionUPsController(IQuizQuestionUPServices quizQuestionUPServices)
        {
            _quizQuestionUPServices = quizQuestionUPServices ?? throw new ArgumentNullException(nameof(quizQuestionUPServices)); ;
        }
        [HttpGet]
        public Task<IQueryable<QuizQuestionUpDto>> GetAll()
        {
            return _quizQuestionUPServices.GetAll();
        }
        [HttpGet]
        [Route("{Id}")]
        public async Task<QuizQuestionUP> GetDetails([FromRoute] Guid Id)
        {
            return await _quizQuestionUPServices.GetDetails(Id);
        }
        [HttpPost]
        public Task<bool> Add([FromBody] QuizQuestionUpVm quizQuestionUpVm)
        {
            return _quizQuestionUPServices.Add(quizQuestionUpVm);
        }
        [HttpPut]
        [Route("{Id}")]
        public Task<bool> Update([FromRoute] Guid Id, QuizQuestionUpVm quizQuestionUpVm)
        {
            return _quizQuestionUPServices.Update(Id, quizQuestionUpVm);
        }
        [HttpDelete]
        [Route("{Id}")]
        public Task<bool> Delete([FromRoute] Guid Id)
        {
            return _quizQuestionUPServices.Delete(Id);
        }
    }
}
