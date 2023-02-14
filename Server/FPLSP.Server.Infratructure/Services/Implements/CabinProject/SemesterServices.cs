using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.Services.Interfaces.Cabin;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements.CabinProject
{
    public class SemesterServices : ISemesterServices
    {
        public IRepository<Semester> _semesterRes;
        public IMapper _mapper;
        public SemesterServices(IRepository<Semester> semesterRes, IMapper mapper)
        {
            _semesterRes = semesterRes ?? throw new ArgumentNullException(nameof(semesterRes));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        /// <summary>
        /// Tạo 1 kì học
        /// </summary>
        /// <param name="semester">Truyền vào 1 đối tượng để tạo</param>
        /// <returns>Đúng trả về true sai trả về false<returns>
        public async Task<bool> CreateSemester(SemesterVM semester)
        {
            try
            {
                var count = _semesterRes.AsQueryable().Where(x => x.Status == 0).Count();
                var addSemester = new Semester
                {
                    Id = semester.Id,
                    NameofSemester = semester.NameofSemester,
                    IndexOfSemester = count + 1,
                    Status = 0
                };
                await _semesterRes.AddAsync(addSemester);
                await _semesterRes.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// Xóa kì học
        /// </summary>
        /// <param name="Id">Truyền vào ID để tìm ra kì học cần xóa nhưng không xóa cứng mà chỉ thay đổi trạng thái</param>
        /// <returns>Đúng trả về true sai trả về false</returns>
        public async Task<bool> DeleteSemester(Guid Id)
        {
            try
            {
                var semester = await _semesterRes.AsQueryable().Where(x => x.Status == 0).FirstOrDefaultAsync(x => x.Id == Id);
                if (semester != null)
                {
                    semester.Status = 1;
                }
                await _semesterRes.UpdateAsync(semester);
                await _semesterRes.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// Lấy ra danh sách tất cả kì học
        /// </summary>
        /// <returns> Trả về 1 danh sách kì học </returns>
        public Task<IQueryable<SemesterDto>> GetAll()
        {
            return Task.FromResult(_semesterRes.AsQueryable().ProjectTo<SemesterDto>(_mapper.ConfigurationProvider));
        }
        /// <summary>
        /// Tìm ra 1 kì học 
        /// </summary>
        /// <param name="Id">Truyền vào Id để tìm ra kì học</param>
        /// <returns>Nếu tìm thấy sẽ trả về 1 kì học</returns>
        public async Task<SemesterVM> GetById(Guid Id)
        {
            var semester = _semesterRes.AsQueryable().ProjectTo<SemesterVM>(_mapper.ConfigurationProvider).Where(x => x.Status == 0).FirstOrDefaultAsync(x => x.Id == Id);

            return await semester;
        }
        /// <summary>
        /// Thay đổi thông tin 1 kì học
        /// </summary>
        /// <param name="semester">Truyền vào đối tượng mới đã thay đổi và cập nhật đối tượng cũ theo những thông tin mới này</param>
        /// <returns></returns>
        public async Task<bool> UpdateSemester(SemesterVM semester)
        {
            try
            {
                var updateSemester = await _semesterRes.AsQueryable().Where(x => x.Status == 0).FirstOrDefaultAsync(x => x.Id == semester.Id);
                if (updateSemester != null)
                {
                    updateSemester.NameofSemester = semester.NameofSemester;
                    updateSemester.IndexOfSemester = semester.IndexOfSemester;
                    updateSemester.Status = semester.Status;
                    await _semesterRes.UpdateAsync(updateSemester);
                    await _semesterRes.SaveChangesAsync();
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
