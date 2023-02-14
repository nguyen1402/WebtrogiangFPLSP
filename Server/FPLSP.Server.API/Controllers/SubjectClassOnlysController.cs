using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectClassOnlysController : ControllerBase
    {

        private readonly IClassServices _classServices;
        public SubjectClassOnlysController(IClassServices classServices)
        {
            _classServices = classServices;
        }

        [HttpGet]
        public async Task<List<SubjectClassUP>> GetAllSubjectClass()
        {
            var res = await _classServices.getSubjectClass();
            return res;
        }
        [HttpGet]
        [Route("only-class")]
        public async Task<List<ClassUp>> GetAllClass()
        {
            var res = await _classServices.getOnlyClass();
            return res;
        }
    }
}
