using AutoMapper;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements.FPLExam
{
    public class ExamFileServices : IExamFileServices
    {
        private readonly IRepository<ExamStorage> _examStorageRepo;
        private readonly UserManager<UserSignIn> _userManager;
        private readonly ISubjectUPServices _IsubjectUpServices;
        private List<ExamStorage> _lstExamStorage = new List<ExamStorage>();
        private IMapper _mapper;
        public ExamFileServices(IRepository<ExamStorage> examStorageRepo, IMapper mapper, UserManager<UserSignIn> userManager, ISubjectUPServices IsubjectUpServices)
        {
            _examStorageRepo = examStorageRepo ?? throw new ArgumentNullException(nameof(examStorageRepo));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _userManager = userManager;
            _IsubjectUpServices = IsubjectUpServices;
        }
        public async Task<bool> AddMultipleExamFile(List<ExamStorageViewModel> examStorageViewModels)
        {
            //var finalList = _mapper.Map<List<ExamStorage>>(examStorageViewModels);
            foreach (var x in examStorageViewModels)
            {
                ExamStorage examStorage = new ExamStorage()
                {
                    Id = x.Id,
                    CreateTime = x.CreateTime,
                    FileName = x.FileName,

                    ExamFile = x.ExamFile,
                    IndexOfExamStorageFile = x.IndexOfExamStorageFile,
                    Status = x.Status,
                    Note = x.Note,
                    IdUserUpLoad = x.IdUserUpLoad,

                    DeleteTime = default,
                    SubjectId = x.SubjectId,
                };
                _lstExamStorage.Add(examStorage);

            }
            if (_lstExamStorage != null && _lstExamStorage.Count != 0)
            {
                var totaladding = await _examStorageRepo.AddRangeAsync(_lstExamStorage);
                await _examStorageRepo.SaveChangesAsync();
                if (totaladding.Count() != examStorageViewModels.Count())
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public async Task<List<ExamStorage>> GetAllExamFiles()
        {

            //đây là trạng thái xóa
            var finalList = await _examStorageRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            return finalList;
        }
        public async Task<List<ExamStorage>> GetAllExamFilesForOnlySubject(Guid IdSubject)
        {

            //đây là trạng thái xóa
            var finalList = await _examStorageRepo.AsQueryable().Where(c => c.Status != 1 && c.SubjectId == IdSubject).ToListAsync();
            return finalList;
        }
        public async Task<List<ExamStorage>> GetAllExamFilesForLectuterSubject(Guid Idlec, Guid IdSubject)
        {

            //đây là trạng thái xóa
            var finalList = await _examStorageRepo.AsQueryable().Where(c => c.Status != 1 && c.SubjectId == IdSubject && c.IdUserUpLoad == Idlec.ToString()).ToListAsync();
            return finalList;
        }
        public async Task<PageList<ExamStorageViewModel>> GetFileForPaging(ExamFileSearch examFileSearch)
        {
            var finalList = await _examStorageRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            var listsub = await _IsubjectUpServices.GetAllSubjectAsync();
            var listuser = await _userManager.Users.ToListAsync();
            var joinlist = (from a in finalList
                            join b in listsub on a.SubjectId equals b.Id
                            join c in listuser on a.IdUserUpLoad equals c.Id

                            select new ExamStorageViewModel()
                            {
                                Id = a.Id,
                                CreateTime = a.CreateTime,
                                FileName = a.FileName,
                                ExamFile = a.ExamFile,
                                IndexOfExamStorageFile = a.IndexOfExamStorageFile,
                                Status = a.Status,
                                Note = a.Note,


                                DeleteTime = a.DeleteTime,
                                SubjectId = a.SubjectId,
                                IdUserUpLoad = a.IdUserUpLoad,
                                UserNameUpload = c.UserName,
                                SubjectName = b.SubjectName,
                                SubjectCode = b.SubjectCode
                            }
                            ).ToList();
            if (!string.IsNullOrEmpty(examFileSearch.IdUserUpload))
            {
                joinlist = joinlist.Where(c => c.IdUserUpLoad == examFileSearch.IdUserUpload).ToList();
            }
            if (!string.IsNullOrEmpty(examFileSearch.FileName))
            {
                joinlist = joinlist.Where(c => c.FileName.ToLower().Contains(examFileSearch.FileName.ToLower())).ToList();
            }
            if (!string.IsNullOrEmpty(examFileSearch.SubjectName))
            {
                joinlist = joinlist.Where(c => c.SubjectName.ToLower().Contains(examFileSearch.SubjectName.ToLower())).ToList();
            }
            if (examFileSearch.CreateTime.HasValue)
            {
                joinlist = joinlist.Where(c => c.CreateTime == examFileSearch.CreateTime).ToList();
            }
            if (examFileSearch.DeleteTime.HasValue)
            {
                joinlist = joinlist.Where(c => c.DeleteTime == examFileSearch.DeleteTime).ToList();
            }

            var data = joinlist.Skip((examFileSearch.PageNumber - 1) * examFileSearch.PageSize).Take(examFileSearch.PageSize).ToList();
            return new PageList<ExamStorageViewModel>(data, joinlist.Count, examFileSearch.PageNumber, examFileSearch.PageSize);
        }
        public async Task<bool> DeleteExamFile(Guid IdExamFile)
        {
            if (IdExamFile == Guid.Empty)
            {
                return false;
            }
            var finalList = await _examStorageRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            foreach (var file in finalList.Where(c => c.Id == IdExamFile))
            {
                //file.Status = 1;
                //file.DeleteTime = DateTime.Now;
                await _examStorageRepo.RemoveAsync(file);
                await _examStorageRepo.SaveChangesAsync();
            }



            return true;
        }

        public async Task<bool> QuickChangeExamFile(Guid Id, int status)
        {
            if (Id == Guid.Empty)
            {
                return false;
            }
            var finalList = await _examStorageRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            foreach (var file in finalList.Where(c => c.Id == Id))
            {
                file.Status = status;

                await _examStorageRepo.UpdateAsync(file);
                await _examStorageRepo.SaveChangesAsync();
            }

            return true;
        }
        public async Task<bool> UpdateExamFile(ExamStorageViewModel examStorageViewModel)
        {
            if (examStorageViewModel == null)
            {
                return false;
            }
            ExamStorage examStorage = new ExamStorage()
            {
                Id = examStorageViewModel.Id,
                CreateTime = examStorageViewModel.CreateTime,
                FileName = examStorageViewModel.FileName,
                ExamFile = examStorageViewModel.ExamFile,
                IndexOfExamStorageFile = examStorageViewModel.IndexOfExamStorageFile,
                Status = examStorageViewModel.Status,

                Note = examStorageViewModel.Note,
                IdUserUpLoad = examStorageViewModel.IdUserUpLoad,
                DeleteTime = examStorageViewModel.DeleteTime,
                SubjectId = examStorageViewModel.SubjectId,
            };
            await _examStorageRepo.UpdateAsync(examStorage);
            await _examStorageRepo.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateFastExamFile(Guid idExam)
        {
            if (idExam == Guid.Empty)
            {
                return false;
            }
            var finalList = await _examStorageRepo.AsQueryable().Where(c => c.Status != 1).ToListAsync();
            foreach (var x in finalList.Where(c => c.Id == idExam))
            {

                await _examStorageRepo.UpdateAsync(x);
                await _examStorageRepo.SaveChangesAsync();
            }

            return true;
        }
        public async Task<List<ExamStorage>> GetAllExamFilesForLectuer(Guid IdLecturter)
        {
            var finalList = await _examStorageRepo.AsQueryable().Where(c => c.Status != 1 && c.IdUserUpLoad == IdLecturter.ToString()).ToListAsync();
            return finalList;
        }
        public async Task<List<ExamStorage>> GetAllExamFilesBySubjectId(Guid IdSubject)
        {
            var finalList = await _examStorageRepo.AsQueryable().Where(c => c.Status != 1 && c.Status != 4 && c.SubjectId == IdSubject).ToListAsync();
            return finalList;
        }
    }
}

