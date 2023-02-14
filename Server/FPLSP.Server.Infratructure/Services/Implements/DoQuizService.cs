using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Dtos.DoQuizDtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.DoQuizsVM;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace FPLSP.Server.Infrastructure.Services.Implements;

public class DoQuizService : IDoQuizService
{
    private readonly IRepository<AnswerUP> _answerUPRepository;
    private readonly IRepository<QuizUP> _quizUPRepository;
    private readonly IRepository<QuizQuestionQuizUP> _quizQuestionUPRepository;
    private readonly IRepository<QuizQuestionUP> _questionUPRepository;
    private readonly IRepository<QuestionType> _questionTypeRepository;
    private readonly IRepository<StudentUP> _studentUpRepository;
    private readonly IRepository<StudentQuizUP> _studentQuizUPRepository;
    private readonly IRepository<TakeAnswerUP> _takeAnswerRepository;
    private readonly IMapper _mapper;

    //private readonly ILogger<DoQuizService> _logger;


    public DoQuizService(IRepository<AnswerUP> answerUpRepository, IRepository<QuizUP> quizUpRepository, IRepository<QuizQuestionQuizUP> quizQuestionUpRepository, IRepository<QuizQuestionUP> questionUpRepository, IRepository<QuestionType> questionTypeRepository, IRepository<StudentUP> studentUpRepository, IRepository<StudentQuizUP> studentQuizUpRepository, IRepository<TakeAnswerUP> takeAnswerRepository, IMapper mapper)
    {
        _quizQuestionUPRepository = quizQuestionUpRepository ?? throw new ArgumentNullException(nameof(quizQuestionUpRepository));
        _answerUPRepository = answerUpRepository ?? throw new ArgumentNullException(nameof(answerUpRepository));
        _quizUPRepository = quizUpRepository ?? throw new ArgumentNullException(nameof(quizUpRepository));
        _questionUPRepository = questionUpRepository ?? throw new ArgumentNullException(nameof(questionUpRepository));
        _questionTypeRepository = questionTypeRepository ?? throw new ArgumentNullException(nameof(questionTypeRepository));
        _studentUpRepository = studentUpRepository ?? throw new ArgumentNullException(nameof(studentUpRepository));
        _studentQuizUPRepository = studentQuizUpRepository ?? throw new ArgumentNullException(nameof(studentQuizUpRepository));
        _takeAnswerRepository = takeAnswerRepository ?? throw new ArgumentNullException(nameof(takeAnswerRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }
    /// <summary>
    /// gét list Question và bao gồm các điểm, câu trả lời trước đó của Sinh viên nếu có.
    /// </summary>
    /// <param name="viewModel"> bao gồm QuizId và StudentId</param>
    /// <returns></returns>
    public Task<GetListQuestionAndScore> GetQuestionCollection(GetQuestionCollectionVm viewModel)
    {
        var getListQuestionAndScore = new GetListQuestionAndScore();
        var questionCollection = new List<QuestionDto>();


        #region Cheesck Sinh viên làm Quiz hay chưa. nếu chưa thì thêm mới. với điểm =0
        var checkStudentQuizExited = _studentQuizUPRepository.AsQueryable().ToList().Any(c => Guid.Equals(viewModel.QuizId, c.QuizId) && Guid.Equals(viewModel.StudentId, c.StudentId));
        if (!checkStudentQuizExited) // check Sinh vien da lam quiz nay chua??
        {
            var createStudentQuiz = new StudentQuizUP()
            {
                StudentId = viewModel.StudentId,
                QuizId = viewModel.QuizId,
            };
            _studentQuizUPRepository.AddAsync(createStudentQuiz);
            _studentQuizUPRepository.SaveChangesAsync();
        }
        #endregion

        var answerCollection = _answerUPRepository.AsQueryable().ProjectTo<AnswerDto>(_mapper.ConfigurationProvider).ToList(); // máp từ AnswerUp=>answer Dto

        #region Join các bảng questionUP, quizQuestionUP, questionType lấy title, content, questionType
        var questions = _questionUPRepository.AsQueryable().Where(c=>c.Status == 1).ToList()
           .Join(_quizQuestionUPRepository.AsQueryable().ToList().Where(c => Guid.Equals(viewModel.QuizId, c.QuizId)),
               question => question.Id, quiz => quiz.QuizQuestionId, (question, quiz) => new
               {

                   question.ContentQuestion,
                   question.QuestionTital,
                   question.Id,
                   question.QuestionTypeId,
                   quiz.QuizId
               })
           .Join(_questionTypeRepository.AsQueryable().ToList(), question => question.QuestionTypeId, type => type.Id,
               (question, type)
                   => new
                   {
                       question.ContentQuestion,
                       question.QuestionTital,
                       question.Id,
                       question.QuestionTypeId,
                       question.QuizId,
                       type.QuestionForm
                   });
        #endregion
        #region map từ questionUP => QuestionDto
        foreach (var question in questions)
        {
            var questionDto = new QuestionDto();
            questionDto.Id = question.Id;
            questionDto.QuestionNumber++;
            questionDto.ContentQuestion = question.ContentQuestion;
            questionDto.QuestionTital = question.QuestionTital;
            questionDto.AnswerDtoCollection = answerCollection.Where(c => Guid.Equals(question.Id, c.QuizQuestionId)).ToList();
            questionDto.TypeId = question.QuestionTypeId ?? Guid.Empty;
            questionDto.TypeName = question.QuestionForm;
            // _logger.LogDebug(question.Id.ToString());
            questionCollection.Add(questionDto);
        }
        #endregion
        #region lấy  lít take answer
        var listTakeAnswer = new List<AnswersOfQuizDto>();
        //var checkStudentQuizExited =  _studentQuizUPRepository.AsQueryable().ToList().Any(c => Guid.Equals(viewModel.QuizId, c.QuizId) && Guid.Equals(viewModel.StudentId, c.StudentId));
        if (!checkStudentQuizExited) // check Sinh vien da lam quiz nay chua??
        {
            listTakeAnswer = null;
        }

        #region chuyển từ Dictionary TakeAnswer => List câu trả lời của Sinh viên đã làm
        var didTakeAnswers = _takeAnswerRepository.AsQueryable().ToList();
        foreach (var temp in didTakeAnswers.Where(c => Guid.Equals(viewModel.QuizId, c.QuizId) && Guid.Equals(viewModel.StudentId, c.StudentId)))
        {
            var checkTakeAnswerExited = didTakeAnswers.Any(c => Guid.Equals(viewModel.QuizId, c.QuizId) && Guid.Equals(viewModel.StudentId, c.StudentId) && Guid.Equals(temp.QuestionId, c.QuestionId));
            if (checkTakeAnswerExited) // check xem sinh viên đã làm chưa.
            {
                var listAnswer = new List<TakeAnswerToList>();
                foreach (var answer in didTakeAnswers.Where(c => Guid.Equals(viewModel.QuizId, c.QuizId) && Guid.Equals(viewModel.StudentId, c.StudentId) && Guid.Equals(temp.QuestionId, c.QuestionId)))
                {
                    var answersOfQuestion = new AnswersOfQuizDto();
                    answersOfQuestion.QuestionId = answer.QuestionId;
                    foreach (var dic in answer.TakeAnswers)
                    {
                        var result = new TakeAnswerToList()
                        {
                            AnswerId = dic.Key,
                            QuestionId = dic.Value
                        };
                        listAnswer.Add(result);
                    }
                    answersOfQuestion.AnswerCollectionOfQuestion.AddRange(listAnswer);
                    listTakeAnswer.Add(answersOfQuestion);
                }

            }
        }
        #endregion

        #region Gán các đáp án sinh viên đã làm trả lên cùng
        var takeAnswerExited = didTakeAnswers.Any(c => Guid.Equals(viewModel.QuizId, c.QuizId) && Guid.Equals(viewModel.StudentId, c.StudentId));
        if (takeAnswerExited)
        {
            foreach (var question in questionCollection)
            {
                foreach (var answersOfQuizDto in listTakeAnswer.Where(c => Guid.Equals(question.Id, c.QuestionId)))
                {
                    foreach (var answer in question.AnswerDtoCollection)
                    {
                        foreach (var chooseAnswer in answersOfQuizDto.AnswerCollectionOfQuestion)
                        {
                            if (Guid.Equals(answer.Id, chooseAnswer.AnswerId))
                            {
                                var indexAnswer = question.AnswerDtoCollection.FindIndex(c =>
                                    Guid.Equals(answer.QuizQuestionId, c.QuizQuestionId) &&
                                    Guid.Equals(answer.Id, c.Id));
                                question.AnswerDtoCollection[indexAnswer].StudentChoose = true;
                                var aaa = question.AnswerDtoCollection[indexAnswer];
                            }
                        }

                    }
                }

                var indexQuestion = questionCollection.FindIndex(c => c.Id == question.Id);
                questionCollection[indexQuestion].AnswerDtoCollection = question.AnswerDtoCollection;
            }
        }
        #endregion
        //{foreach (var question in questionCollection)
        //{
        //    #region con ver veef DIc
        //    var answerConvert = new Dictionary<Guid, Guid>();
        //    foreach (var answers in question.AnswerDtoCollection)
        //    {
        //        answerConvert.Add(answers.Id, question.Id);
        //    }
        //    #endregion

        //    foreach (var tempAnswerUp in didTakeAnswers.Where(c => Equals(viewModel.QuizId, c.QuizId) && Equals(viewModel.StudentId, c.StudentId) && Equals(question.Id, c.QuestionId)))
        //    {
        //        if (EqualComparisonDictionary(tempAnswerUp.TakeAnswers, answerConvert))
        //        {

        //        }
        //    }
        //}


        #endregion

        //var count = questionCollection.Count;
        //var data = questionCollection.Skip((viewModel.PageNumber - 1) * viewModel.PageSize).Take(viewModel.PageSize)
        //    .ToList();
        //var result = new PageList<QuestionDto>(data, count, viewModel.PageNumber, viewModel.PageSize);
        getListQuestionAndScore.QuestionCollectionGet = questionCollection;
        getListQuestionAndScore.Score = _studentQuizUPRepository.AsQueryable().ToList().FirstOrDefault(c => Guid.Equals(viewModel.StudentId, c.StudentId) && Guid.Equals(viewModel.QuizId, c.QuizId)).ScoreQuizOfStudent;// get điểm của sinh viên lên

        return Task.FromResult(getListQuestionAndScore);

    }
    /// <summary>
    ///     
    /// </summary>
    /// <param name="quizId">đâu vào IdQuizId</param>
    /// <param name="viewModel"> bao gồm StudentId, list Question kèm Id câu trả lời của Sinh viên </param>
    /// <returns></returns>
    public async Task<double> SubmitQuizAsync(Guid quizId, DoQuizViewModel viewModel)
    {
        var takeAnswerCollection = new List<TakeAnswerUP>();

        #region them vao StudentQuiz  Cheesck Sinh viên đã làm quiz này chưa. nếu chưa thì tạo mới.

        var checkStudentQuizExited = _studentQuizUPRepository.AsQueryable().ToList().Any(c => Guid.Equals(quizId, c.QuizId) && Guid.Equals(viewModel.StudentId, c.StudentId));
        if (!checkStudentQuizExited) // check Sinh vien da lam quiz nay chua??
        {
            var createStudentQuiz = new StudentQuizUP()
            {
                StudentId = viewModel.StudentId,
                QuizId = quizId,
            };
            await _studentQuizUPRepository.AddAsync(createStudentQuiz);
            await _studentQuizUPRepository.SaveChangesAsync();
        }
        #endregion

        var didTakeAnswers = _takeAnswerRepository.AsQueryable().ToList();
        foreach (var takeAnswer in viewModel.QuestionIdCollection)
        {
            var takeAnswerNew = new Dictionary<Guid, Guid>();
            foreach (var temp in takeAnswer.AnswerId)
            {
                takeAnswerNew.Add(temp, takeAnswer.QuestionId); // gán các AnswerId về dictionary< key= AnswerId, value= QuestionId>
            }

            var checkTakeAnswerExited = didTakeAnswers.Any(c => Guid.Equals(quizId, c.QuizId) && Guid.Equals(viewModel.StudentId, c.StudentId) && Guid.Equals(takeAnswer.QuestionId, c.QuestionId));
            if (!checkTakeAnswerExited) //check xem takeAnswer da lam chua nếu chưa làm thì tạo mới
            {
                var createTakeAnswer = new TakeAnswerUP();
                createTakeAnswer.Id = Guid.NewGuid();
                createTakeAnswer.QuestionId = takeAnswer.QuestionId;
                createTakeAnswer.StudentId = viewModel.StudentId;
                createTakeAnswer.QuizId = quizId;
                createTakeAnswer.TakeAnswers = takeAnswerNew;
                await _takeAnswerRepository.AddAsync(createTakeAnswer);
                await _takeAnswerRepository.SaveChangesAsync();
            }
            else // nếu làm rồi thì update đáp án sinh viên lastest
            {
                var updateTakeAnswer = didTakeAnswers.FirstOrDefault((c => Guid.Equals(quizId, c.QuizId) && Guid.Equals(viewModel.StudentId, c.StudentId) && Guid.Equals(takeAnswer.QuestionId, c.QuestionId)));
                if (!EqualComparisonDictionary(updateTakeAnswer.TakeAnswers, takeAnswerNew))
                {
                    updateTakeAnswer.TakeAnswers = takeAnswerNew;
                    await _takeAnswerRepository.UpdateAsync(updateTakeAnswer);
                    await _takeAnswerRepository.SaveChangesAsync();
                }
            }
        }

        var correctAnswerCollection = new Collection<QuestionDto>();
        //var questionCollection = new Collection<QuestionDto>();
        var answerCollection = _answerUPRepository.AsQueryable().ProjectTo<AnswerDto>(_mapper.ConfigurationProvider).ToList();
        var getQuestions = _questionUPRepository.AsQueryable().ToList()
            .Join(_quizQuestionUPRepository.AsQueryable().ToList().Where(c => Guid.Equals(quizId, c.QuizId)), question => question.Id, quiz => quiz.QuizQuestionId, (question, quiz) => new
            {
                question.ContentQuestion,
                question.QuestionTital,
                question.Id,
                quiz.QuizId
            });
        foreach (var question in getQuestions)
        {
            var questionDto = new QuestionDto();
            questionDto.Id = question.Id;
            questionDto.ContentQuestion = question.ContentQuestion;
            questionDto.QuestionTital = question.QuestionTital;
            questionDto.AnswerDtoCollection = answerCollection.Where(c => Guid.Equals(question.Id, c.QuizQuestionId) && int.Equals(true, c.IsCorrect)).ToList();
            correctAnswerCollection.Add(questionDto);
        }

        #region Convert Correct answer to Dictionary< key= AnswerId, value= QuestionId >

        var correctAnswerDicList = new List<Dictionary<Guid, Guid>>();
        foreach (var temp in correctAnswerCollection)
        {
            var correctAnswersOfQuestion = new Dictionary<Guid, Guid>();

            foreach (var answerOfQuestion in temp.AnswerDtoCollection)
            {
                correctAnswersOfQuestion.Add(answerOfQuestion.Id, answerOfQuestion.QuizQuestionId);
            }
            correctAnswerDicList.Add(correctAnswersOfQuestion);
        }
        #endregion
        takeAnswerCollection = _takeAnswerRepository.AsQueryable().ToList();
        //var takeAnswerCollectionOfStudent = new List<AnswersOfQuizDto>(); //list đáp án của Sinh viên trả lời trong 1 question
        var takeAnswerList = takeAnswerCollection.Where(c => correctAnswerCollection.Select(c => c.Id).Contains(c.QuestionId) && c.StudentId == viewModel.StudentId).Select(c => c.TakeAnswers).ToList();


        double scoresQuiz = 0; // biến chứa điểm khi hoàn thành 
        int countAnswerCorrect = 0;// biến tính số câu trả lời đúng
        #region tính sô câu trả lời đúng của sinh viên = function EqualComparisonDictionary(result, expect)
        foreach (var expect in takeAnswerList)
        {
            foreach (var result in correctAnswerDicList)
            {
                if (EqualComparisonDictionary(result, expect)) //nếu trả ra true thì 2 Dic bằng nhau.
                {
                    countAnswerCorrect++;
                }
            }
        }
        #endregion

        double scoresCorrect = 100 / correctAnswerCollection.Count(); //điểm một câu trả lời đúng
        scoresQuiz = scoresCorrect * countAnswerCorrect; // tính điểm của sinh viên khi hoàn thành bài quiz.

        #region Update điểm quiz vừa làm cho Sinh viên
        var studentQuiz = _studentQuizUPRepository.AsQueryable().ToList().FirstOrDefault(c => Guid.Equals(viewModel.StudentId, c.StudentId) && Guid.Equals(quizId, c.QuizId));
        var count = studentQuiz.CounterTurn + 1;
        if (studentQuiz != null)
        {
            studentQuiz.ScoreQuizOfStudent = scoresQuiz;
            studentQuiz.CounterTurn = count;
            await _studentQuizUPRepository.UpdateAsync(studentQuiz);
            await _studentQuizUPRepository.SaveChangesAsync();
        }
        #endregion
        return scoresQuiz;
    }

    public Task<List<AnswersOfQuizDto>> GetTakeAnswersOfQuizAsync(GetTakeAnswerOfStudentVM viewModel)
    {
        var listTakeAnswer = new List<AnswersOfQuizDto>();
        var checkStudentQuizExited = _studentQuizUPRepository.AsQueryable().ToList().Any(c => Guid.Equals(viewModel.QuizId, c.QuizId) && Guid.Equals(viewModel.StudentId, c.StudentId));
        if (!checkStudentQuizExited) // check Sinh vien da lam quiz nay chua??
        {
            listTakeAnswer = null;
            return Task.FromResult(listTakeAnswer);
        }

        var didTakeAnswers = _takeAnswerRepository.AsQueryable().ToList();
        foreach (var temp in didTakeAnswers.Where(c => Guid.Equals(viewModel.QuizId, c.QuizId) && Guid.Equals(viewModel.StudentId, c.StudentId)))
        {
            var checkTakeAnswerExited = didTakeAnswers.Any(c =>
                Guid.Equals(viewModel.QuizId, c.QuizId) && Guid.Equals(viewModel.StudentId, c.StudentId) &&
                Guid.Equals(temp.QuestionId, c.QuestionId));
            if (checkTakeAnswerExited)
            {
                var listAnswer = new List<TakeAnswerToList>();
                foreach (var answer in didTakeAnswers.Where(c => Guid.Equals(viewModel.QuizId, c.QuizId) && Guid.Equals(viewModel.StudentId, c.StudentId) && Guid.Equals(temp.QuestionId, c.QuestionId)))
                {
                    var answersOfQuestion = new AnswersOfQuizDto();
                    answersOfQuestion.QuestionId = answer.QuestionId;
                    foreach (var dic in answer.TakeAnswers)
                    {
                        var result = new TakeAnswerToList()
                        {
                            QuestionId = dic.Key,
                            AnswerId = dic.Value
                        };
                        listAnswer.Add(result);
                    }
                    answersOfQuestion.AnswerCollectionOfQuestion.AddRange(listAnswer);
                    listTakeAnswer.Add(answersOfQuestion);
                }
            }
        }
        return Task.FromResult(listTakeAnswer);
    }
    /// <summary>
    /// 1- so sánh số phần tử 2 Dic.
    /// 2- lấy key  rồi => Value và so sanh value 
    /// </summary>
    /// <param name="d"> Dic 1 cần so sánh </param>
    /// <param name="d2">Dic 2 cần so sánh </param>
    /// <returns></returns>
    private bool EqualComparisonDictionary(Dictionary<Guid, Guid> d, Dictionary<Guid, Guid> d2)
    {// function để So sánh 2 dic với nhau.   
        bool equal = false;
        if (d.Count == d2.Count)
        { // Require equal count.
            equal = true;
            foreach (var pair in d)
            {
                Guid value;
                if (d2.TryGetValue(pair.Key, out value))
                {
                    if (value != pair.Value)
                    {
                        equal = false;
                        break;
                    }
                }
                else
                {
                    equal = false;
                    break;
                }
            }
        }

        return equal;
    }
}