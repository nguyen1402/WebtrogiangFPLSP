using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.QuizUp.ViewModels;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.QuizUp;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class QuizUPServices : IQuizUPServices
    {
        private readonly IRepository<QuizUP> _quizUpRespository;
        private readonly IMapper _mapper;
        public QuizUPServices(IRepository<QuizUP> quizUpRespository, IMapper mapper)
        {
            _quizUpRespository = quizUpRespository ?? throw new ArgumentNullException(nameof(quizUpRespository)); ;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<bool> Add(QuizUpVm quizUpvm, Guid idsubject)
        {
            try
            {

                QuizUP quizUp = new QuizUP();
                quizUp.QuizTitle = quizUpvm.QuizTitle;
                quizUp.QuizName = quizUpvm.QuizName;
                quizUp.StartDay = quizUpvm.StartDay;
                quizUp.EndDay = quizUpvm.EndDay;
                quizUp.MaxTurn = quizUpvm.MaxTurn;
                quizUp.IsDeleted = false;
                quizUp.SubjectId = idsubject;
                quizUp.Status = quizUpvm.Status;
                quizUp.Descriptions = quizUpvm.Descriptions;
                await _quizUpRespository.AddAsync(quizUp);
                await _quizUpRespository.SaveChangesAsync();
                return await Task.FromResult(true);
            }
            catch (Exception)
            {

                return await Task.FromResult(false);
            }
        }

        public async Task<bool> Delete(Guid idQuiz)
        {
            try
            {
                QuizUP quizUP = _quizUpRespository.AsQueryable().FirstOrDefault(c => c.Id == idQuiz);
                await _quizUpRespository.RemoveAsync(quizUP);
                await _quizUpRespository.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteAll(List<Guid> listId)
        {
            List<QuizUP> lstQuizUps = new List<QuizUP>();
            foreach (var item in listId)
            {
                var quizUps = _quizUpRespository.AsQueryable().FirstOrDefault(c => c.Id == item);
                if (quizUps != null)
                {
                    lstQuizUps.Add(quizUps);
                }

            }
            try
            {
                await _quizUpRespository.RemoveRangeAsync(lstQuizUps);
                await _quizUpRespository.SaveChangesAsync();
                return await Task.FromResult(true);
            }
            catch (Exception)
            {

                return await Task.FromResult(false);
            }
        }

        public async Task<List<QuizUpDto>> Get()
        {
            return await Task.FromResult(_quizUpRespository.AsQueryable().ProjectTo<QuizUpDto>(_mapper.ConfigurationProvider).ToList());
        }

        public Task<QuizUpEditVm> GetById(Guid Id)
        {
            QuizUpEditVm quizUpVm = new QuizUpEditVm();
            QuizUP quizUp = _quizUpRespository.AsQueryable().FirstOrDefault(c => c.Id == Id);
            quizUpVm.QuizTitle = quizUp.QuizTitle;
            quizUpVm.QuizName = quizUp.QuizName;
            quizUpVm.StartDay = quizUp.StartDay;
            quizUpVm.EndDay = quizUp.EndDay;
            quizUpVm.MaxTurn = quizUp.MaxTurn;
            quizUpVm.SubjectId = quizUp.SubjectId;
            quizUpVm.IsDeleted = false;
            quizUpVm.Status = quizUp.Status;
            quizUpVm.Descriptions = quizUp.Descriptions;
            return Task.FromResult(quizUpVm);
        }

        public async Task<PageList<QuizUpDto>> GetPageList(ListQuizUpSearch listQuizSearch, Guid idsubject)
        {
            var lst = from a in _quizUpRespository.AsQueryable().Where(c => c.IsDeleted == false && c.SubjectId == idsubject)
                      select new QuizUpDto()
                      {
                          Id = a.Id,
                          QuizTitle = a.QuizTitle,
                          QuizName = a.QuizName,
                          Descriptions = a.Descriptions,
                          EndDay = a.EndDay,
                          StartDay = a.StartDay,
                          Status = a.Status,
                          MaxTurn = a.MaxTurn,

                      };
            if (listQuizSearch.Status != null)
            {
                lst = lst.Where(x => x.Status == listQuizSearch.Status);
            }
            if (listQuizSearch.Search != null)
            {
                lst = lst.Where(x => x.QuizName.Contains(listQuizSearch.Search));
            }
            var count = await lst.CountAsync();
            var data = await lst.Skip((listQuizSearch.PageNumber - 1) * listQuizSearch.PageSize).Take(listQuizSearch.PageSize).ToListAsync();
            return new PageList<QuizUpDto>(data, count, listQuizSearch.PageNumber, listQuizSearch.PageSize);
        }

        public Task<bool> Update(Guid Id, QuizUpEditVm quizUpVm)
        {
            try
            {

                QuizUP quizUP = _quizUpRespository.AsQueryable().FirstOrDefault(c => c.Id == Id);
                quizUP.QuizTitle = quizUpVm.QuizTitle;
                quizUP.QuizName = quizUpVm.QuizName;
                quizUP.StartDay = quizUpVm.StartDay;
                quizUP.EndDay = quizUpVm.EndDay;
                quizUP.MaxTurn = quizUpVm.MaxTurn;
                quizUP.Status = quizUpVm.Status;
                quizUP.Descriptions = quizUpVm.Descriptions;
                _quizUpRespository.UpdateAsync(quizUP);
                _quizUpRespository.SaveChangesAsync();
                return Task.FromResult(true);
            }
            catch (Exception)
            {

                return Task.FromResult(false);
            }
        }
    }
}
