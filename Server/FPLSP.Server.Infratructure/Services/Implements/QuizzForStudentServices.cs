using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.Quizz;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class QuizzForStudentServices : IQuizzForStudentServices
    {
        private readonly IRepository<AnswerUP> _answerUPRepository;

        private readonly IRepository<QuizQuestionQuizUP> _quizQuestionUPRepository;

        private readonly IRepository<StudentQuizUP> _studentQuizUPRepository;
        private readonly IRepository<TakeAnswerUP> _takeAnswerRepository;

        public QuizzForStudentServices(IRepository<AnswerUP> answerUpRepository, IRepository<QuizQuestionQuizUP> quizQuestionUpRepository, IRepository<StudentQuizUP> studentQuizUpRepository, IRepository<TakeAnswerUP> takeAnswerRepository)
        {
            _quizQuestionUPRepository = quizQuestionUpRepository ?? throw new ArgumentNullException(nameof(quizQuestionUpRepository));
            _answerUPRepository = answerUpRepository ?? throw new ArgumentNullException(nameof(answerUpRepository));

            _studentQuizUPRepository = studentQuizUpRepository ?? throw new ArgumentNullException(nameof(studentQuizUpRepository));
            _takeAnswerRepository = takeAnswerRepository ?? throw new ArgumentNullException(nameof(takeAnswerRepository));


        }

        public async Task<List<QuizzForStudent>> GetListQuiz(RouterQuizz routerQuizz)
        {
            var finallist = (from a in _studentQuizUPRepository.AsQueryable().ToList().Where(c => c.QuizId == routerQuizz.IdQuizz && c.StudentId == routerQuizz.IdStudent)
                             select new QuizzForStudent()
                             {
                                 StudentId = a.StudentId,
                                 QuizId = a.QuizId,
                                 ListQuizzQuestion = _quizQuestionUPRepository.AsQueryable().Where(c => c.QuizId == a.QuizId).ToList(),
                                 ListAnswer = _answerUPRepository.AsQueryable().Where(c => c.QuizQuestionId == _quizQuestionUPRepository.AsQueryable().Where(c => c.QuizId == a.QuizId).Select(c => c.QuizQuestionId).FirstOrDefault()).Select(c => c.Id).ToList(),
                                 takeAnswerUP = _takeAnswerRepository.AsQueryable().FirstOrDefault(c => c.StudentId == routerQuizz.IdStudent && c.QuizId == routerQuizz.IdQuizz)

                             }).ToList();
            return finallist;
        }
    }
}
