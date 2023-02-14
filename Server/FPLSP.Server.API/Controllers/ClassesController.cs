using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels;
using IdentityServer4;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Server.API.Controllers
{

   
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClassesController : ControllerBase
    {
        private readonly IClassServices _classServices;

        private IStudentUpServices _studentUpServices;

        private ISubjectUPServices _subjectUPServices;

        public ClassesController(IClassServices classServices, IStudentUpServices studentUpServices, ISubjectUPServices subjectUPServices)
        {
            _classServices = classServices;
            _studentUpServices = studentUpServices;
            _subjectUPServices = subjectUPServices;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetClassList([FromQuery] PagingParameters pagingParameters)
        //{
        //    var Classes = await _classServices.GetClassList(pagingParameters);

        //    //var Subject = _ApplicationDbContext.SubjectUPs.ToList();

        //    var ClassDTO = Classes.Items.Select(c => new ClassUPViewModel
        //    {
        //    }).ToList();
        //    return Ok(new PageList<ClassUPViewModel>(ClassDTO, Classes.MetaData.TotalCount, Classes.MetaData.CurrentPage, Classes.MetaData.PageSize));
        //}

        [HttpGet("all")]
        public async Task<List<ClassUPViewModel>> GetAllClass()
        {
            var Classes = _classServices.GetAllClassesAsync();
            var ClassesVm = Classes.Select(c => new ClassUPViewModel
            {
                Id = c.Id,
                SubjectName = c.SubjectName,
                ClassroomName = c.ClassroomName,
                
                Building = c.Building,
                StudentAmount = c.StudentAmount,
                DateCreated = c.DateCreated,
                DateStarted = c.DateCreated,
                EndDate = c.EndDate,
                Status = c.Status,
                SpecializedId = c.SpecializedId,
                JoinCode = c.JoinCode,
                HomeroomLecturer = c.HomeroomLecturer,
                HomeroomLecturerId = c.HomeroomLecturerId,
                HomeroomLecturerEmail = c.HomeroomLecturerEmail,
                HomeroomLecturerPhoneNumber = c.HomeroomLecturerPhoneNumber,
                ActualNumberOfStudent = c.ActualNumberOfStudent,
                subjectUP = c.subjectUP,
                ListStudent = c.ListStudent
            }).ToList();
            return ClassesVm;
        }

        [HttpGet]
        [Route("fordetail")]
        public async Task<PageList<ClassUPViewModel>> GetClassListDetail([FromQuery] ClassSearchDTO classSearchDTO)
        {
            var Classes = await _classServices.GetListClassDetail(classSearchDTO);

            var ClassDTO = Classes.Items.Select(c => new ClassUPViewModel
            {
                Id = c.Id,
                SubjectName = c.SubjectName,
                ClassroomName = c.ClassroomName,
             
                Building = c.Building,
                StudentAmount = c.StudentAmount,
                DateCreated = c.DateCreated,
                DateStarted = c.DateCreated,
                EndDate = c.EndDate,
                SubjectId = c.SubjectId,
                Status = c.Status,
                SpecializedId = c.SpecializedId,
                JoinCode = c.JoinCode,
                HomeroomLecturerId = c.HomeroomLecturerId,
                HomeroomLecturer = c.HomeroomLecturer,
                HomeroomLecturerEmail = c.HomeroomLecturerEmail,
                HomeroomLecturerPhoneNumber = c.HomeroomLecturerPhoneNumber,
                ActualNumberOfStudent = c.ActualNumberOfStudent,
                subjectUP = c.subjectUP,
                ListStudent = c.ListStudent
            }).OrderByDescending(c => c.DateCreated).ToList();
            return new PageList<ClassUPViewModel>(ClassDTO, Classes.MetaData.TotalCount, Classes.MetaData.CurrentPage, Classes.MetaData.PageSize);
        }
       
        [HttpGet]
        [Route("fordetail-all/{idstu}")]
        public async Task<List<ClassUPViewModel>> GetAllClass([FromRoute] Guid idstu)
        {
            var res = await _classServices.GetAllClass(idstu);

            return res.OrderByDescending(c => c.DateCreated).ToList();
        }
        [HttpGet("{idclass}")]

        public async Task<CreateClassVM> GetClassById(string idclass)
        {
            var classModel = await _classServices.GetClassListById(idclass);


            return classModel;
        }
        [HttpGet]
        [Route("getclass-forlec/{emaillec}")]
        public async Task<List<ClassUPViewModel>> GetClassOfLecturter(string emaillec)
        {
            var classModel = await _classServices.GetListClassDetailForLec(emaillec);
            return classModel.OrderByDescending(c => c.DateCreated).ToList();
        }
        [HttpPost]
        [Route("creater")]

        public async Task<IActionResult> AddClass([FromBody] CreateClassVM viewModelTest)
        {
            var returnmodel = await _classServices.CreateClass(viewModelTest);
            return Ok(returnmodel);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateClass(string id, [FromBody] CreateClassVM classUp)
        {
            var classUpdate = await _classServices.GetClassListById(id);
            if (classUpdate == null)
            {
                return NotFound();
            }
            await _classServices.UpdateClass(id, classUp);
            return Ok();



        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteClass([FromRoute] string id)
        {


            var x = await _classServices.DeleteClass(id);
            return Ok();
        }
        [HttpGet]
        [Route("manage-create")]
        public async Task<IActionResult> GetClassListDetailCreate()
        {

            var Classes = await _classServices.ClassCreater();
            return Ok(Classes);
        }

    }
}