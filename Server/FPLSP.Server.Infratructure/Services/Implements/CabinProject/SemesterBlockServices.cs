using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.Services.Interfaces.Cabin;
using FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements.Cabin
{
    public class SemesterBlockServices : ISemesterBlockServices
    {
        public IRepository<SemesterBlock> _semesterRes;
        public IBlockServices _blockRes;
        public ISemesterServices _semRes;
        public IMapper _mapper;
        public SemesterBlockServices(IRepository<SemesterBlock> semesterRes, IBlockServices blockRes, ISemesterServices semRes, IMapper mapper)
        {
            _semesterRes = semesterRes ?? throw new ArgumentNullException(nameof(semesterRes));
			_blockRes = blockRes ?? throw new ArgumentNullException(nameof(blockRes));
			_semRes = semRes ?? throw new ArgumentNullException(nameof(semRes));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        /// <summary>
        /// Hàm tạo Kì và Block học
        /// </summary>
        /// <param name="semester">Truyền vào View Model SemesterBlock</param>
        /// <returns>Trả về kết quả true or false</returns>
        public async Task<bool> CreateSemesterBlock(SemesterBlockVM semester)
        {
            try
            {
                var count = _semesterRes.AsQueryable().Where(x => x.Status == 0).Count();
                var addSemester = new SemesterBlock
                {
                    IdBlock = semester.IdBlock,
                    IdSemester = semester.IdSemester,
                    StartTime = semester.StartTime,
                    EndTime = semester.EndTime,
                    IndexOfSemesterBlock = count + 1,
                    Status = 2
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
        /// Hàm xóa đi Kì và Block học
        /// </summary>
        /// <param name="IdBlock">Id Block để tìm ra block</param>
        /// <param name="IdSemester">Id Semester để tìm ra kì </param>
        /// Phải tìm thấy cả 2 id 1 lúc mới xóa được
        /// <returns>Đúng trả về true sai trả về false</returns>
        public async Task<bool> DeleteSemesterBlock(Guid IdBlock, Guid IdSemester)
        {
            try
            {
                var semester = await _semesterRes.AsQueryable().FirstOrDefaultAsync(x => x.IdBlock == IdBlock && x.IdSemester == IdSemester);
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
        /// Phương thức lấy ra danh sách tất cả các Kì-Block
        /// </summary>
        /// <returns>Trả về danh sách Kì-Block</returns>
        public Task<IQueryable<SemesterBlockDto>> GetAll()
        {
            return Task.FromResult(_semesterRes.AsQueryable().ProjectTo<SemesterBlockDto>(_mapper.ConfigurationProvider));
        }
        /// <summary>
        /// Lấy ra chi tiết 1 Kì-Block
        /// </summary>
        /// <param name="IdBlock">Id của block</param>
        /// <param name="IdSemester">Id của kì học</param>
        /// <returns>Trả về 1 Kì-Block</returns>
        public async Task<SemesterBlockVM> GetById(Guid IdBlock, Guid IdSemester)
        {
			var semesterblock = await _semesterRes.AsQueryable().ProjectTo<SemesterBlockVM>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(x => x.IdBlock == IdBlock && x.IdSemester == IdSemester);
            var semester = await _semRes.GetById(IdSemester);
            var block = await _blockRes.GetById(IdBlock);
			semesterblock.NameofSemester = semester.NameofSemester;
			semesterblock.NameofBlock = block.NameOfBlock;
            return semesterblock;

		}
        /// <summary>
        /// Phương thức phân trang
        /// </summary>
        /// <param name="semesterBlockSearch">Gửi request xuống để phân trang</param>
        /// <returns>Trả về 1 pagelist đã phân trang</returns>
        public async Task<PageList<SemesterBlockDto>> GetPageList(SemesterBlockSearch semesterBlockSearch)
        {
            var lst = from a in _semesterRes.AsQueryable().Where(x => x.Status != 1)
					  select new SemesterBlockDto()
                      {
                          IdBlock = a.IdBlock,
                          IdSemester = a.IdSemester,
                          IndexOfSemesterBlock = a.IndexOfSemesterBlock,
                          Status = a.Status,
                          StartTime = a.StartTime,
                          EndTime = a.EndTime,

                      };
            if (semesterBlockSearch.Status != null)
            {
                lst = lst.Where(x => x.Status == semesterBlockSearch.Status);
            }

			var count = await lst.CountAsync();
            var data = await lst.Skip((semesterBlockSearch.PageNumber - 1) * semesterBlockSearch.PageSize).Take(semesterBlockSearch.PageSize).ToListAsync();
            return new PageList<SemesterBlockDto>(data, count, semesterBlockSearch.PageNumber, semesterBlockSearch.PageSize);
        }
        /// <summary>
        /// Phương thức cập nhật Kì-Block học
        /// </summary>
        /// <param name="semester">Truyền vào 1 ViewModel từ trên view xuống sau đó tìm đối tượng theo ID và thay đổi các thuộc tính đó bằng với các thuộc tính đã truyền xuống</param>
        /// <returns>Nếu update thành công sẽ trả về true sai thì false</returns>
        public async Task<bool> UpdateSemesterBlock(SemesterBlockVM semester)
        {
            try
            {
                var updateSemester = await _semesterRes.AsQueryable().FirstOrDefaultAsync(x => x.IdBlock == semester.IdBlock && x.IdSemester == semester.IdSemester);
                if (updateSemester != null)
                {
                    updateSemester.StartTime = semester.StartTime;
                    updateSemester.EndTime = semester.EndTime;
                    updateSemester.Status = semester.Status;
                    updateSemester.IndexOfSemesterBlock = semester.IndexOfSemesterBlock;
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
