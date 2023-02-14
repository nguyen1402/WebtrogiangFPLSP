using FPLSP.Server.Data.FPLSPDbContext;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.SubjectsSpecializedVM;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsSpecializedUPsController : ControllerBase
    {
        private readonly ISubjectsSpecializedUPServices _repo;
        private readonly ISpecializedUPServices _specRepo;
        private ApplicationDbContext _ApplicationDbContext = new ApplicationDbContext();

        public SubjectsSpecializedUPsController(ISubjectsSpecializedUPServices repo, ISpecializedUPServices specRepo)
        {
            _repo = repo;
            _specRepo = specRepo;
        }

        [HttpGet("getall/{specializedId}")]
        public async Task<IActionResult> Get(Guid specializedId, [FromQuery] SubjectsSpecializedCPListSearch parameters)
        {
            var listAllSpec = _ApplicationDbContext.SpecializedUPs.ToList();
            var Spec = listAllSpec.FirstOrDefault(c => c.Id == specializedId);
            List<Guid> specializedIds = new List<Guid>();

            // Lấy tất cả ngành con trong chuyên ngành
            if (Spec != null)
            {
                List<SpecializedUP> listSmaller = listAllSpec.Where(c => c.SpecialityId == Spec.Id && c.Level == Spec.Level + 1).ToList();
                int levelMax = Spec.Level;
                for (int i = 0; i <= levelMax; i++)
                {
                    List<SpecializedUP> listMoreSmaller = new List<SpecializedUP>();
                    if (listSmaller.Count != 0)
                    {
                        foreach (var item in listSmaller)
                        {
                            listMoreSmaller.AddRange(listAllSpec.Where(c => c.SpecialityId == item.Id && c.Level == item.Level + 1).ToList());
                            specializedIds.Add(item.Id);
                        }
                        listSmaller = listMoreSmaller;
                        levelMax++;
                    }
                }
            }

            var pagel = await _repo.GetPagingParamets(specializedIds, parameters);
            var data = pagel.Items.Select(x => new SubjectsSpecializedDtos()
            {
                SpecializedId = x.SpecializedId,
                SubjectId = x.SubjectId,
                SubjectName = x.SubjectName,
                SpecializationName = x.SpecializationName,
                StatusSpecialized = x.StatusSpecialized,
                StartDay = x.StartDay,
                EndDay = x.EndDay,
                TotalOfSub = x.TotalOfSub,
                Image = x.Image,
                StatusSubject = x.StatusSubject,
            });
            return Ok(new PageList<SubjectsSpecializedDtos>(data.ToList(),
                pagel.MetaData.TotalCount,
                pagel.MetaData.CurrentPage,
                pagel.MetaData.PageSize));
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _repo.GetAllAsync();
            return Ok(data);

        }
        [HttpGet("{specializedId}/{lecturerid}")]
        public async Task<IActionResult> Get(Guid specializedId, Guid lecturerid)
        {
            if (string.IsNullOrEmpty(specializedId.ToString())) return BadRequest();
            var result = await _repo.GetbyId(specializedId, lecturerid);
            if (result == null)
                return BadRequest();
            return Ok(result);
        }
        [HttpPost("{specializedId}")]
        public async Task<IActionResult> Add(Guid specializedId, [FromBody] SubjectsSpecializedCreateVM lesson)
        {
            if (lesson == null) return BadRequest();
            var result = await _repo.Create(specializedId, lesson);
            if (result != true)
                return BadRequest();
            return Ok();
        }
    }
}
