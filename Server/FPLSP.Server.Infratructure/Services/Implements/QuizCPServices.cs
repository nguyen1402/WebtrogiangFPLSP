using AutoMapper;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.QuizCPDtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.QuizCPVm;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class QuizCPServices : IQuizCPServices
    {
        private readonly IRepository<QuizCP> _quizCPtRepository;
        private readonly IRepository<SubjectCP> _subjectCPtRepository;
        private readonly IRepository<QuizQuestionCP> _quizQuestionCPRepository;
        private readonly IRepository<QuizAnswerCP> _quizAnswerCPRepository;
        private readonly IRepository<QuizQuestionQuizCP> _quizQuestionQuizCPRepository;
        private readonly IRepository<KindoOfQuestionCP> _kindoOfQuestionCPRepository;
        private readonly IMapper _mapper;

        public QuizCPServices(IRepository<QuizCP> quizCPtRepository, IRepository<SubjectCP> subjectCPtRepository, IRepository<QuizQuestionCP> quizQuestionCPRepository, IRepository<QuizAnswerCP> quizAnswerCPRepository, IRepository<QuizQuestionQuizCP> quizQuestionQuizCPRepository, IRepository<KindoOfQuestionCP> kindoOfQuestionCPRepository, IMapper mapper)
        {
            _quizCPtRepository = quizCPtRepository;
            _subjectCPtRepository = subjectCPtRepository;
            _quizQuestionCPRepository = quizQuestionCPRepository;
            _quizAnswerCPRepository = quizAnswerCPRepository;
            _quizQuestionQuizCPRepository = quizQuestionQuizCPRepository;
            _kindoOfQuestionCPRepository = kindoOfQuestionCPRepository;
            _mapper = mapper;
        }

        //public QuizCPServices(IRepository<QuizCP> quizCPRepository, IMapper mapper, IRepository<SubjectCP> subjectCPRepository)
        //{
        //    _quizCPtRepository = quizCPRepository ?? throw new ArgumentNullException(nameof(quizCPRepository));
        //    _subjectCPtRepository = subjectCPRepository ?? throw new ArgumentNullException(nameof(subjectCPRepository));
        //    _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        //}
        public async Task<int> CreateQuizCP(Guid idsubject, QuizCPVm quiz)
        {
            try
            {
                TimeSpan result = quiz.EndDay - quiz.StartDay;
                if (result.Days < 0)
                    return 0;
                var subject = _subjectCPtRepository.AsQueryable().ToList().FirstOrDefault(p => p.Id == idsubject);
                if (subject == null) return 0;
                var newquiz = new QuizCP()
                {
                    SubjectId = idsubject,
                    QuizName = quiz.QuizName,
                    Descriptions = quiz.Descriptions,
                    MaxTurn = quiz.MaxTurn,
                    EndDay = quiz.EndDay,
                    StartDay = quiz.StartDay,
                    Status = quiz.Status,
                    QuizTitle = quiz.QuizName
                };
                await _quizCPtRepository.AddAsync(newquiz);
                await _quizCPtRepository.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<PageList<SubjectQuizCPDtos>> GetQuizList(Guid idsubject, ListQuizSearch quiz)
        {
            try
            {
                //var subjectquiz = from a in _quizCPtRepository.AsQueryable().ToList()
                //                  join b in _subjectCPtRepository.AsQueryable().ToList() on a.SubjectId equals b.Id
                //                  where a.SubjectId == idsubject && a.IsDeleted == false
                //                  select new SubjectQuizCPDtos()
                //                  {
                //                      Id = a.Id,
                //                      QuizName = a.QuizName,
                //                      Descriptions = a.Descriptions,
                //                      MaxTurn = a.MaxTurn,
                //                      StartDay = a.StartDay,
                //                      EndDay = a.EndDay,
                //                      Status = a.Status,
                //                  };

                var lstQuiz = _quizCPtRepository.AsQueryable().ToList();
                var subjectquiz = lstQuiz.Where(c=>c.SubjectId == idsubject && c.IsDeleted == false).Select(a=> new SubjectQuizCPDtos()
                {
                    Id = a.Id,
                    QuizName = a.QuizName,
                    Descriptions = a.Descriptions,
                    MaxTurn = a.MaxTurn,
                    StartDay = a.StartDay,
                    EndDay = a.EndDay,
                    Status = a.Status,
                });
                if (quiz.Status != 3)
                {
                    subjectquiz = subjectquiz.Where(x => x.Status == quiz.Status);
                }
                if (quiz.QuizName != null)
                {
                    subjectquiz = subjectquiz.Where(x => x.QuizName.ToLower().Contains(quiz.QuizName.ToLower()));
                }
                subjectquiz = subjectquiz.OrderBy(p => p.QuizName);
                var count = subjectquiz.Count();
                var data = subjectquiz.Skip((quiz.PageNumber - 1) * quiz.PageSize).Take(quiz.PageSize).ToList();
                return new PageList<SubjectQuizCPDtos>(data, count, quiz.PageNumber, quiz.PageSize);
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public async Task<int> UpdateQuizCP(Guid id, UpdateQuizCPVm quiz)
        {
            try
            {
                TimeSpan result = quiz.EndDay - quiz.StartDay;
                if (result.Days < 0) return 0;
                var quizdb = _quizCPtRepository.AsQueryable().ToList().FirstOrDefault(c => Guid.Equals(id, c.Id));
                if (quizdb == null) return 0;
                quizdb.QuizName = quiz.QuizName;
                quizdb.Status = quiz.Status;
                quizdb.StartDay = quiz.StartDay;
                quizdb.EndDay = quiz.EndDay;
                quizdb.Descriptions = quiz.Descriptions;
                quizdb.MaxTurn = quiz.MaxTurn;
                await _quizCPtRepository.UpdateAsync(quizdb);
                await _quizCPtRepository.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        private Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public async Task<int> CreateExcelQuizQuestion(List<ExcelQuizQuestion> lstexcelQuizQuestions)
        {
            try
            {
                if (lstexcelQuizQuestions != null)
                {
                    foreach (var excelQuizQuestion in lstexcelQuizQuestions)
                    {
                     
                        var question = new QuizQuestionCP()
                        {
                            Id = excelQuizQuestion.IdQuestion,
                            ContentQuestion = excelQuizQuestion.ContentQuestion,
                            KindoOfQuestionId = _kindoOfQuestionCPRepository.AsQueryable().ToList().Where(c => c.QuestionTypeName == excelQuizQuestion.QuestionTypeName).Select(c => c.Id).FirstOrDefault(),
                            QuestionCode = RandomString(5),
                            QuestionName = "Câu " + (_quizQuestionQuizCPRepository.AsQueryable().ToList().Where(c => c.QuizId == excelQuizQuestion.IdQuiz).ToList().Count() + 1),
                            Status = 1,
                            QuestionTital = "",
                        };
                        await _quizQuestionCPRepository.AddAsync(question);
                        await _quizQuestionCPRepository.SaveChangesAsync();
                        var lstAnswerCP = new List<QuizAnswerCP>();
                        foreach (var item in excelQuizQuestion.ListAnswer)
                        {
                            var anwer = new QuizAnswerCP()
                            {
                                Answer = item.Answer,
                                Id = item.Id,
                                IdQuizQuestion = item.IdQuizQuestion,
                                IsCorrect = item.IsCorrect==1?true:false,
                            };
                            lstAnswerCP.Add(anwer);
                        }
                        await _quizAnswerCPRepository.AddRangeAsync(lstAnswerCP);
                        await _quizAnswerCPRepository.SaveChangesAsync();
                        var quizQuestion = new QuizQuestionQuizCP()
                        {
                            QuizId = excelQuizQuestion.IdQuiz,
                            QuizQuestionId = excelQuizQuestion.IdQuestion,
                            Status = 1
                        };
                        await _quizQuestionQuizCPRepository.AddAsync(quizQuestion);
                        await _quizQuestionQuizCPRepository.SaveChangesAsync();
                    }
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public async Task<SubjectQuizCPDtos> GetQuizCPbyId(Guid id)
        {
            try
            {
                var subjectquiz = from a in _quizCPtRepository.AsQueryable().ToList()
                                  join b in _subjectCPtRepository.AsQueryable().ToList() on a.SubjectId equals b.Id
                                  select new SubjectQuizCPDtos()
                                  {
                                      Id = a.Id,
                                      QuizName = a.QuizName,
                                      Descriptions = a.Descriptions,
                                      MaxTurn = a.MaxTurn,
                                      Status = a.Status,
                                      StartDay = a.StartDay,
                                      EndDay = a.EndDay,
                                  };
                var quiz = subjectquiz.FirstOrDefault(p => p.Id == id);
                return quiz;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<List<SubjectQuizCPDtos>> GetAllQuizCPbyIdSubject(Guid idsubject)
        {
            try
            {
                var subjectquiz = from a in _quizCPtRepository.AsQueryable().ToList().Where(p => p.SubjectId == idsubject && p.IsDeleted == false)
                                  select a;
                var result = subjectquiz.Select(x => new SubjectQuizCPDtos()
                {
                    Id = x.Id,
                    QuizName = x.QuizName,
                    Descriptions = x.Descriptions,
                    MaxTurn = x.MaxTurn,
                    Status = x.Status,
                    StartDay = x.StartDay,
                    EndDay = x.EndDay,
                }).ToList();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<int> DeleteQuizCP(Guid id)
        {

            try
            {
                var quiz = _quizCPtRepository.AsQueryable().ToList().FirstOrDefault(c => Guid.Equals(id, c.Id));
                if (quiz == null) return 0;
                if (quiz.Status == 0)
                {
                    quiz.Status = 1;
                    await _quizCPtRepository.UpdateAsync(quiz);
                    await _quizCPtRepository.SaveChangesAsync();

                }
                else
                {
                    quiz.Status = 0;
                    await _quizCPtRepository.UpdateAsync(quiz);
                    await _quizCPtRepository.SaveChangesAsync();
                }
                return 1;

            }
            catch
            {
                return 0;
            }
        }

        public async Task<bool> RemoveListQuizCP(List<Guid> listIdQuiz)
        {
            try
            {
                List<QuizCP> subjectCP = new List<QuizCP>();
                foreach (var item in listIdQuiz)
                {
                    var statuss = _quizCPtRepository.AsQueryable().ToList().FirstOrDefault(c => c.Id == item);
                    if (statuss.Status == 0)
                    {
                        statuss.Status = 1;
                        await _quizCPtRepository.UpdateAsync(statuss);
                        await _quizCPtRepository.SaveChangesAsync();
                    }
                    else
                    {
                        statuss.Status = 0;
                        await _quizCPtRepository.UpdateAsync(statuss);
                        await _quizCPtRepository.SaveChangesAsync();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
