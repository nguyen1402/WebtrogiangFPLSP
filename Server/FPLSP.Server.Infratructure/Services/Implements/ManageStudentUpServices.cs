using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Dtos.StudentUPDtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class ManageStudentUpServices : IManageStudentUpServices
    {

        private readonly IRepository<ClassUp> _classRepository;
        private readonly IRepository<StudentUP> _studentRepository;
        private readonly IRepository<SubjectUP> _subjectRepository;

        public ManageStudentUpServices(IRepository<ClassUp> classRepository, IRepository<StudentUP> studentRepository, IRepository<SubjectUP> subjectRepository)
        {
            _classRepository = classRepository;
            _studentRepository = studentRepository;
            _subjectRepository = subjectRepository;
        }

        public async Task<StudentUP> AddStudentToClass(CreateStudentInClassDto createStudentInClassDto)
        {

            var st = _studentRepository.AsQueryable().FirstOrDefault(c => Guid.Equals(createStudentInClassDto.idStudent, c.Id));
            //st.ClassId = createStudentInClassDto.idClass;

            await _studentRepository.UpdateAsync(st);
            await _studentRepository.SaveChangesAsync();
            return st;
        }

        public async Task<List<StudentUpDto>> GetDetailStudents(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ManageStudentUpDto>> GetListStudentsInClass(Guid id)
        {
            List<ManageStudentUpDto> data = new List<ManageStudentUpDto>();
            //var idSub = _classRepository.AsQueryable().Where(c => c.Id == id).Select(c => c.SubjectId).FirstOrDefault();
            //var lstSb = _subjectRepository.AsQueryable().Where(c => Guid.Equals(idSub, c.Id)).ToList();
            //var LstSt = _studentRepository.AsQueryable().Where(c => Guid.Equals(id, c.ClassId)).ToList();
            var lstClass = _classRepository.AsQueryable().Where(c => Guid.Equals(id, c.Id)).ToList();
            //var Amount = LstSt.Count();
            //if (lstSb.Count == 0 && LstSt.Count == 0)
            //{
            //    var query = (from cl in lstClass
            //                 select new { cl }).ToList();
            //    data = query
            //                .Select(x => new ManageStudentUpDto()
            //                {
            //                    ClassroomCode = x.cl.ClassroomName,
            //                    ClassroomName = x.cl.ClassroomName,
            //                    Address = x.cl.Address,
            //                    StudentAmount = x.cl.StudentAmount,
            //                    StudentCode = null,
            //                    StudentName = null,
            //                    Status = x.cl.Status,
            //                    SubjectName = null,
            //                    StudentAmountInClass = Amount,
            //                    IdClass = x.cl.Id
            //                }).ToList();
            //}
            //else if (lstSb.Count == 0)
            //{
            //    var query = (from st in LstSt
            //                 join cl in lstClass on st.ClassId equals cl.Id

            //                 select new { st, cl }).ToList();
            //    data = query
            //                .Select(x => new ManageStudentUpDto()
            //                {
            //                    ClassroomCode = x.cl.ClassroomName,
            //                    ClassroomName = x.cl.ClassroomName,
            //                    Address = x.cl.Address,
            //                    StudentAmount = x.cl.StudentAmount,
            //                    StudentCode = x.st.StudentCode,
            //                    StudentName = x.st.StudentName,
            //                    Status = x.cl.Status,
            //                    SubjectName = null,
            //                    StudentAmountInClass = Amount,
            //                    IdClass = x.cl.Id
            //                }).ToList();
            //}
            //else if (LstSt.Count == 0)
            //{
            //    var query = (from cl in lstClass
            //                 join sb in lstSb on cl.SubjectId equals sb.Id
            //                 select new { cl, sb }).ToList();
            //    data = query
            //                .Select(x => new ManageStudentUpDto()
            //                {
            //                    ClassroomCode = x.cl.ClassroomName,
            //                    ClassroomName = x.cl.ClassroomName,
            //                    Address = x.cl.Address,
            //                    StudentAmount = x.cl.StudentAmount,
            //                    StudentCode = null,
            //                    StudentName = null,
            //                    Status = x.cl.Status,
            //                    SubjectName = x.sb.SubjectName,
            //                    StudentAmountInClass = Amount,
            //                    IdClass = x.cl.Id
            //                }).ToList();
            //}
            //else
            //{
            //    var query = (from st in LstSt
            //                 join cl in lstClass on st.ClassId equals cl.Id
            //                 join sb in lstSb on cl.SubjectId equals sb.Id
            //                 select new { st, cl, sb }).ToList();
            //    data = query
            //                .Select(x => new ManageStudentUpDto()
            //                {
            //                    ClassroomCode = x.cl.ClassroomName,
            //                    ClassroomName = x.cl.ClassroomName,
            //                    Address = x.cl.Address,
            //                    StudentAmount = x.cl.StudentAmount,
            //                    StudentCode = x.st.StudentCode,
            //                    StudentName = x.st.StudentName,
            //                    Status = x.cl.Status,
            //                    SubjectName = x.sb.SubjectName,
            //                    StudentAmountInClass = Amount,
            //                    IdClass = x.cl.Id
            //                }).ToList();
            //}

            return data;


        }


        public async Task<StudentUP> RemoveStudentFromClass(Guid idStudent)
        {


            var st = _studentRepository.AsQueryable().FirstOrDefault(c => Guid.Equals(idStudent, c.Id));
            //st.ClassId = null;

            await _studentRepository.UpdateAsync(st);
            await _studentRepository.SaveChangesAsync();
            return st;
        }
    }
}
