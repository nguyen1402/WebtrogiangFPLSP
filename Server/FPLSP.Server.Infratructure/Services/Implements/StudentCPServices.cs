using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.StudentCP;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class StudentCPServices : IStudentCPServices
    {
        private readonly IRepository<StudentCP> _studentRepository;
        private readonly IMapper _mapper;

        public StudentCPServices(IRepository<StudentCP> studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository ?? throw new ArgumentNullException(nameof(studentRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<int> CreateStudentCP(CreateStudentCPVm student)
        {
            string id = GetMaxId();
            string ids = "PH" + Convert.ToString(Convert.ToInt32(id) + 1);
            var newstudent = new StudentCP()
            {
                StudentCode = ids,
                StudentName = student.StudentName,
                Gender = student.Gender,
                DateOfBirth = student.DateOfBirth,
                Address = student.Address,
                Email = student.Email,
                Password = student.Password,
                PhoneNumber = student.PhoneNumber,
                IdentityCardNumber = student.IdentityCardNumber,
                IssuedOn = student.IssuedOn,
                Ethnic = student.Ethnic,
                ImageUrl = student.ImageUrl,
                Description = student.Description,
                FathersName = student.FathersName,
                MotherName = student.MotherName,
                HomeTown = student.HomeTown,
                Status = student.Status

            };
            var studentcode = await _studentRepository.AsQueryable().AnyAsync(c => String.Equals(newstudent.StudentCode, c.StudentCode));
            if (studentcode) { return 0; }

            await _studentRepository.AddAsync(newstudent);
            await _studentRepository.SaveChangesAsync();

            return 1;
        }

        public async Task<IQueryable<StudentCP>> GetAllStudentCPAsync()
        {
            var result = _studentRepository.AsQueryable().Where(c => Boolean.Equals(false, c.IsDeleted));
            return result;
        }

        public string GetMaxId()
        {
            var result = _studentRepository.AsQueryable().Max(p => Convert.ToInt32(p.StudentCode.Substring(2, (p.StudentCode.Length - 2))));
            return result.ToString();
        }

        public async Task<StudentCP> GetStudentCPbyId(Guid id)
        {
            var result = await _studentRepository.AsQueryable().FirstOrDefaultAsync(c => Guid.Equals(id, c.Id));
            return result;
        }

        public async Task<StudentCP> GetStudentCPMaxId()
        {
            string id = GetMaxId().ToString();
            var result = _studentRepository.AsQueryable().FirstOrDefault(p => string.Equals(p.StudentCode.Substring(2, (p.StudentCode.Length - 2)), id));
            return result;
        }

        public async Task<PageList<StudentCP>> GetStudentList(StudentCPListSearch student)
        {
            var result = _studentRepository.AsQueryable().Where(c => Boolean.Equals(false, c.IsDeleted));
            if (student.Status != null)
            {
                result = result.Where(x => x.Status == Convert.ToInt32(student.Status));
            }
            if (student.NameStudent != null)
            {
                result = result.Where(x => x.StudentName.ToLower().Contains(student.NameStudent.ToLower()) || x.StudentCode.ToLower().Contains(student.NameStudent.ToLower()));
            }
            var count = await result.CountAsync();
            var data = await result.Skip((student.PageNumber - 1) * student.PageSize).Take(student.PageSize).ToListAsync();
            return new PageList<StudentCP>(data, count, student.PageNumber, student.PageSize);
        }

        public async Task<IQueryable<StudentDto>> GetStudentsAsync()
        {
            Serilog.Log.Information("Started--Log Of Weather Forecast-- > Get Method");

            var studentCollection = _studentRepository.AsQueryable().ProjectTo<StudentDto>(_mapper.ConfigurationProvider);
            // _logger.Information(studentCollection.ToString());

            return await Task.FromResult(studentCollection);
        }

        public async Task<int> UpdateStudentCP(Guid id, UpdateStudentCPVm student)
        {
            var studentdb = await _studentRepository.AsQueryable().FirstOrDefaultAsync(c => Equals(id, c.Id));
            studentdb.StudentName = student.StudentName;
            studentdb.Gender = student.Gender;
            studentdb.DateOfBirth = student.DateOfBirth;
            studentdb.Email = student.Email;
            studentdb.Password = student.Password;
            studentdb.PhoneNumber = student.PhoneNumber;
            studentdb.Address = student.Address;
            studentdb.IdentityCardNumber = student.IdentityCardNumber;
            studentdb.IssuedOn = student.IssuedOn;
            studentdb.Ethnic = student.Ethnic;
            studentdb.ImageUrl = student.ImageUrl;
            studentdb.Description = student.Description;
            studentdb.FathersName = student.FathersName;
            studentdb.MotherName = student.MotherName;
            studentdb.HomeTown = student.HomeTown;
            studentdb.Status = student.Status;

            await _studentRepository.UpdateAsync(studentdb);
            await _studentRepository.SaveChangesAsync();
            return 1;
        }

    }
}
