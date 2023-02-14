using AutoMapper;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.KindOfQuestionCPDtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.KìnOfQuestionCPVm;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class KindoOfQuestionCPServices : IKindoOfQuestionCPServices
    {
        //
        private readonly IRepository<KindoOfQuestionCP> _koqCPtRepository;
        private readonly IMapper _mapper;

        public KindoOfQuestionCPServices(IRepository<KindoOfQuestionCP> koqCPtRepository, IMapper mapper)
        {
            _koqCPtRepository = koqCPtRepository ?? throw new ArgumentNullException(nameof(koqCPtRepository)); ;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<int> CreateKOQCP(KindOfQuestionCPVm koq)
        {
            try
            {
                var newKOQ = new KindoOfQuestionCP()
                {
                    QuestionTypeName = koq.QuestionTypeName,
                    QuestionForm = koq.QuestionForm
                };
                await _koqCPtRepository.AddAsync(newKOQ);
                await _koqCPtRepository.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public async Task<int> DeleteKOQCP(Guid id)
        {
            try
            {
                var deleteKOQ = await _koqCPtRepository.AsQueryable().FirstOrDefaultAsync(c => Guid.Equals(id, c.Id));
                await _koqCPtRepository.RemoveAsync(deleteKOQ);
                await _koqCPtRepository.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public async Task<KindOfQuestionCPDtos> GetKOQCPbyId(Guid id)
        {
            try
            {
                var koq = await _koqCPtRepository.AsQueryable().FirstOrDefaultAsync(c => Guid.Equals(id, c.Id));
                var result = new KindOfQuestionCPDtos()
                {
                    Id = koq.Id,
                    QuestionTypeName = koq.QuestionTypeName,
                    QuestionForm = koq.QuestionForm
                };

                return result;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public async Task<List<KindOfQuestionCPDtos>> GetAllKoq()
        {
            try
            {
                var koq = _koqCPtRepository.AsQueryable().ToList().Select(c=>new KindOfQuestionCPDtos()
                {
                    Id = c.Id,
                    QuestionTypeName = c.QuestionTypeName,
                    QuestionForm = c.QuestionForm
                }).ToList();
                return koq;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<PageList<KindOfQuestionCPDtos>> GetKOQList(ListKOQCPSearch koq)
        {
            try
            {
                var listkoq = from a in _koqCPtRepository.AsQueryable()
                              select new KindOfQuestionCPDtos()
                              {
                                  Id = a.Id,
                                  QuestionTypeName = a.QuestionTypeName,
                                  QuestionForm = a.QuestionForm
                              };
                if (koq.QuestionForm != null)
                {
                    listkoq = listkoq.Where(p => p.QuestionForm == koq.QuestionForm);
                }
                if (koq.QuestionTypeName != null)
                {
                    listkoq = listkoq.Where(p => p.QuestionTypeName.Contains(koq.QuestionTypeName));
                }

                var count = await listkoq.CountAsync();
                var data = await listkoq.Skip((koq.PageNumber - 1) * koq.PageSize).Take(koq.PageSize).ToListAsync();
                return new PageList<KindOfQuestionCPDtos>(data, count, koq.PageNumber, koq.PageSize);
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<int> UpdateKOQCP(Guid id, KindOfQuestionCPVm koq)
        {
            try
            {
                var updatekoq = await _koqCPtRepository.AsQueryable().FirstOrDefaultAsync(c => Guid.Equals(id, c.Id));
                updatekoq.QuestionForm = koq.QuestionForm;
                updatekoq.QuestionTypeName = koq.QuestionTypeName;
                await _koqCPtRepository.UpdateAsync(updatekoq);
                await _koqCPtRepository.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
    }
}
