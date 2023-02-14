using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.LecturerCPVm;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Text.RegularExpressions;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class LecturersCPServices : ILecturersCPServices
    {
        private readonly IRepository<LecturersCP> _Irepository;
        private IRepository<LectuterSpecializedCP> _res;
        private IRepository<RoleCP> _resRoleCP;
        private readonly IMapper _mapper;

        private LectuterSpecializedCPServices _lecturersCPServices;
        private TrainingFacilitiesCPServices _trainingFacilitiesCPServices;
        private readonly IRepository<LectuterSpecializedCP> _lectuterSpecializedCP;

        public LecturersCPServices(IRepository<LecturersCP> Irepository, IMapper mapper
            , IRepository<TrainingFacilitiesCP> trainingFacilityRepository
            , IRepository<SpecializedCP> resspecialized
            , IRepository<LecturersCP> reslecture
            , IRepository<LectuterSpecializedCP> res, IRepository<LectuterSpecializedCP> lectuterSpecializedCP, IRepository<RoleCP> resRoleCP)
        {
            _Irepository = Irepository;
            _res = res;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

            _lectuterSpecializedCP = lectuterSpecializedCP;
            _resRoleCP = resRoleCP;
        }
        public async Task<LecturersCPViewModel> CreateLecturer(LecturersCPRequest lecturersCPViewModel)
        {
            try
            {
                if (lecturersCPViewModel.Id == Guid.Empty)
                {
                    lecturersCPViewModel.Id = Guid.NewGuid();
                }
                var lecturer = new LecturersCP
                {
                   
                    Id = lecturersCPViewModel.Id,
                    LecturersCode = await GetMaxCode(),
                    LecturersName = lecturersCPViewModel.LecturersName,
                    Gender = lecturersCPViewModel.Gender,
                    Dob = lecturersCPViewModel.Dob,
                    Email = AutoZenUsername(lecturersCPViewModel.LecturersName, await GetMaxCode()) + "@fpt.edu.vn",
                    PhoneNumber = lecturersCPViewModel.PhoneNumber,
                    PassWord = AutoZenUsername(lecturersCPViewModel.LecturersName, await GetMaxCode()),
                    Address = lecturersCPViewModel.Address,
                    IdentityCard = lecturersCPViewModel.IdentityCard,
                    IssuedOn = lecturersCPViewModel.IssuedOn,
                    Ethnic = lecturersCPViewModel.Ethnic,
                    ImageUrl = lecturersCPViewModel.ImageUrl,
                    YearsOfExperience = lecturersCPViewModel.YearsOfExperience,
                    HomeTown = lecturersCPViewModel.HomeTown,
                    Description = lecturersCPViewModel.Description,
                    TrainingFacilitiesId = lecturersCPViewModel.TrainingFacilitiesId,
                    Status = lecturersCPViewModel.Status,
                    RoleId = _resRoleCP.AsQueryable().ToList().FirstOrDefault().Id,
                };
                await _Irepository.AddAsync(lecturer);
                await _Irepository.SaveChangesAsync();
                return await GetLecturerListById(lecturer.Id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> CreateLecturerForTrain(CreateleatureForTrainVm lecturersCPVm)
        {
            try
            {
                var leture = new LecturersCP()
                {
                    LecturersCode = await GetMaxCode(),
                    LecturersName = "Role",
                    PassWord = "Role",
                    Address = "Role",
                    IdentityCard = "Role",
                    HomeTown = "Role",
                    Description = "Role",
                    PhoneNumber = "Role",
                    ImageUrl = "Role",
                    Id = lecturersCPVm.Id,
                    Ethnic = "Role",
                    IsDeleted = false,
                    Email = lecturersCPVm.Email,
                    TrainingFacilitiesId = lecturersCPVm.IdTrain
                };
                var resutl = _Irepository.AddAsync(leture);
                await _Irepository.SaveChangesAsync();
                return resutl.IsCompletedSuccessfully;
            }
            catch
            {
                return false;
            }
        }
        public static string convertToUnSign3(string s)
        {
            try
            {
                Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
                string temp = s.Normalize(NormalizationForm.FormD);
                return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> UpdateLecturer(Guid Id, LecturersCPRequest lecturersCPViewModel)
        {
            try
            {

                var lecture =  _Irepository.AsQueryable().ToList().FirstOrDefault(c => Equals(Id, c.Id));
                lecture.LecturersName = lecturersCPViewModel.LecturersName;
                lecture.Gender = lecturersCPViewModel.Gender;
                lecture.Dob = lecturersCPViewModel.Dob;
                lecture.PhoneNumber = lecturersCPViewModel.PhoneNumber;
                lecture.Address = lecturersCPViewModel.Address;
                lecture.IdentityCard = lecturersCPViewModel.IdentityCard;
                lecture.IssuedOn = lecturersCPViewModel.IssuedOn;
                lecture.Ethnic = lecturersCPViewModel.Ethnic;
                lecture.ImageUrl = lecturersCPViewModel.ImageUrl;
                lecture.YearsOfExperience = lecturersCPViewModel.YearsOfExperience;
                lecture.HomeTown = lecturersCPViewModel.HomeTown;
                lecture.Description = lecturersCPViewModel.Description;
                lecture.Status = lecturersCPViewModel.Status;
                lecture.TrainingFacilitiesId = lecturersCPViewModel.TrainingFacilitiesId;

                await _Irepository.UpdateAsync(lecture);
                await _Irepository.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> UpdateLectureCP(LecturersCP lecturerCP)
        {
            try
            {
                await _Irepository.UpdateAsync(lecturerCP);
                await _Irepository.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> UpdateLecturerTrain(Guid Id, CreateleatureForTrainVm createleatureForTrain)
        {
            try
            {

                var lecture =  _Irepository.AsQueryable().ToList().FirstOrDefault(c => Equals(Id, c.Id) || c.Email == createleatureForTrain.Email);
                lecture.Id = createleatureForTrain.Id;
                lecture.Email = createleatureForTrain.Email;
                lecture.TrainingFacilitiesId = createleatureForTrain.IdTrain;
                lecture.IsDeleted = false;
                
                await _Irepository.UpdateAsync(lecture);
                await _Irepository.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> DeleteLecturer(Guid Id)
        {
            try
            {
                var lecturer =  _Irepository.AsQueryable().ToList().FirstOrDefault(c => Equals(Id, c.Id));
                await _Irepository.RemoveAsync(lecturer);
                await _Irepository.SaveChangesAsync();

                var lecSpec = _lectuterSpecializedCP.AsQueryable().ToList().Where(c => Equals(Id, c.LectuterId));
                if (lecSpec != null && lecSpec.Count() > 0)
                {
                    await _lectuterSpecializedCP.RemoveRangeAsync(lecSpec);
                    await _lectuterSpecializedCP.SaveChangesAsync();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<PageList<LecturersCPViewModel>> GetLecturerList(PagingParameters pagingParameters)
        {
            try
            {
                var lecturerCollection = _Irepository.AsQueryable().ProjectTo<LecturersCPViewModel>(_mapper.ConfigurationProvider);

                var data = await lecturerCollection.Skip((pagingParameters.PageNumber - 1) * pagingParameters.PageSize).Take(pagingParameters.PageSize).ToListAsync();
                return new PageList<LecturersCPViewModel>(data.Where(c => c.Status != 1).ToList(), data.Where(c => c.Status != 1).ToList().Count, pagingParameters.PageNumber, pagingParameters.PageSize);
            }
            catch
            {
                return null;
            }
        }

        public async Task<PageList<LecturersCPViewModel>> GetLecturerListSearch(LecturersCPListSearch search)
        {
            try
            {
                //var query = _Irepository.AsQueryable().ToList().Where(x => x.IsDeleted != true).ProjectTo<LecturersCPViewModel>(_mapper.ConfigurationProvider);

                var resuals = _Irepository.AsQueryable().Where(x => x.IsDeleted == false).ProjectTo<LecturersCPViewModel>(_mapper.ConfigurationProvider).ToList();
                //var querry = from c in _Irepository.AsQueryable().ToList()
                //             join ct in _res.AsQueryable().ToList() on c.Id equals ct.LectuterId
                //             select new { c, ct };
                //var resuals = querry.Select(x => new LecturersCPViewModel()
                //{
                //    Id = x.c.Id,
                //    LecturersCode = x.c.LecturersCode,
                //    LecturersName = x.c.LecturersName,
                //    Gender = x.c.Gender,
                //    Dob = x.c.Dob,
                //    Email = x.c.Email,
                //    PhoneNumber = x.c.PhoneNumber,
                //    Address = x.c.Address,
                //    IdentityCard = x.c.IdentityCard,
                //    IssuedOn = x.c.IssuedOn,
                //    Ethnic = x.c.Ethnic,
                //    ImageUrl = x.c.ImageUrl,
                //    YearsOfExperience = x.c.YearsOfExperience,
                //    HomeTown = x.c.HomeTown,
                //    Description = x.c.Description,
                //    Status = x.c.Status,
                //    idspec = x.ct.SpecializedId,
                //    namechuyennganh = x.ct.SpecializedCP.SpecializationName,
                //    RoleId = x.c.RoleId,
                //    TrainingFacilitiesId = x.c.TrainingFacilitiesId
                //}).ToList();
                if (search.TrainingFacilityID.HasValue)
                    resuals = resuals.Where(x => x.TrainingFacilitiesId == search.TrainingFacilityID).ToList();
                if (!string.IsNullOrEmpty(search.Name))
                    resuals = resuals.Where(x => x.LecturersCode.ToLower().Contains(search.Name.ToLower()) || x.LecturersName.ToLower().Contains(search.Name.ToLower()) || x.Email.ToLower().Contains(search.Name.ToLower()) || x.PhoneNumber.ToLower().Contains(search.Name.ToLower())).ToList();
                if (search.Status != null)
                    resuals = resuals.Where(x => x.Status == search.Status).ToList();
                if (search.RoleId.HasValue)
                    resuals = resuals.Where(x => x.RoleId == search.RoleId).ToList();


                var count = resuals.Count();

                var data = resuals.Skip((search.PageNumber - 1) * search.PageSize).Take(search.PageSize).ToList();
                var result = new PageList<LecturersCPViewModel>(data, count, search.PageNumber, search.PageSize);
                return result;
            }
            catch
            {
                return null;
            }
        }


        public async Task<LecturersCPViewModel> GetLecturerListById(Guid Id)
        {
            try
            {
                var lecturersCP =  _Irepository.AsQueryable().ToList().SingleOrDefault(c => c.Id == Id);
                var lecturerModel = _mapper.Map<LecturersCPViewModel>(lecturersCP);
                return lecturerModel;
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<LecturersCP>> GetLecturerMapper()
        {
            try
            {
                var lecturerCollection = _Irepository.AsQueryable().ToList();
                return lecturerCollection;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string AutoZenCode()
        {
            try
            {
                var lecturerCollection = GetAllLecturerAsync().Result;
                if (lecturerCollection.Count() == 0) return "GV1";

                string result = "GV" + (lecturerCollection.Max(x => Convert.ToInt32(x.LecturersCode.Substring(2, x.LecturersCode.Length - 2))) + 1).ToString();

                return result;
            }
            catch (Exception)
            {
                return null;
            }

        }

        private string AutoZenUsername(string lecturerName, string lecturerCode)
        {
            try
            {
                var temp = lecturerName;

                string[] nameParts = temp.Split(' ');
                for (int i = 0; i < nameParts.Count(); i++)
                {
                    nameParts[i] = convertToUnSign3(nameParts[i]);
                }
                string name = nameParts[nameParts.Length - 1];
                string afterName = null;

                for (int i = 0; i < nameParts.Length - 1; i++)
                {
                    afterName += nameParts[i][0];
                }

                return (name + afterName + lecturerCode).ToLower(); //=> dungnagv000
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Task<List<LecturersCP>> GetAllLecturerAsync()
        {
            try
            {
                var result =  _Irepository.AsQueryable().ToList();
                return Task.FromResult(result);
            }
            catch
            {
                return null;
            }
        }

        private async Task<string> GetMaxCode()
        {
            try
            {
                var lecturerCollection = await GetAllLecturerAsync();
                if (lecturerCollection.Count == 0) return "GV0";
                //foreach (var item in lecturerCollection)
                //{
                //    var a = await GetAllLecturerAsync();
                //    var max = a.Where(c => c.LecturersCode.Contains("GV")).Max(x => Convert.ToInt32(x.LecturersCode.Substring(2)));
                //    if (item.LecturersCode.StartsWith("GV"))
                //    {
                //        item.LecturersCode = "GV" + max;
                //    }
                //}
                string result = "GV" + lecturerCollection.Where(c => c.LecturersCode.Contains("GV")).Max(x => Convert.ToInt32(x.LecturersCode.Substring(2, x.LecturersCode.Length - 2))).ToString();

                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<LecturersCP> GetLecturerMaxCode()
        {
            try
            {
                var result = new LecturersCP();
                string maxCode = await GetMaxCode();
                if (maxCode == null)
                {
                    result.LecturersCode = "GV0000";
                }
                if (maxCode == "GV0")
                {
                    result.LecturersCode = maxCode;
                }
                else
                {
                    result = _Irepository.AsQueryable().ToList().FirstOrDefault(p => string.Equals(p.LecturersCode.ToLower(), maxCode.ToLower()));
                }
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> RemoveListLecturersCP(List<Guid> listId)
        {
            try
            {
                List<LecturersCP> lecturersCP = new List<LecturersCP>();
                foreach (var item in listId)
                {
                    lecturersCP.AddRange(_Irepository.AsQueryable().ToList().Where(c => c.Id == item));
                }
                var result = _Irepository.RemoveRangeAsync(lecturersCP);
                await _Irepository.SaveChangesAsync();
                return result.IsCompletedSuccessfully;
            }
            catch
            {
                return false;
            }
        }
    }
}
