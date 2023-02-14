using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.Quizz;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizzsController : ControllerBase
    {
        private readonly IQuizzForStudentServices _quizzForStudentServices;
        public QuizzsController(IQuizzForStudentServices quizzForStudentServices)
        {
            _quizzForStudentServices = quizzForStudentServices;
        }



        [HttpGet]
        public async Task<List<QuizzForStudent>> QuizzForStudents([FromQuery] RouterQuizz routerQuizz)
        {
            var res = await _quizzForStudentServices.GetListQuiz(routerQuizz);
            return res;
        }
    }
}
