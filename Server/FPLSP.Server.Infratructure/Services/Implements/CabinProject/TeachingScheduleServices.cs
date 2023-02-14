using AutoMapper;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.TeachingSchedule;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements.CabinProject
{
    public class TeachingScheduleServices : ITeachingScheduleServices
    {
        private IRepository<TeachingSchedule> _teachingScheduleRep;
        private readonly IMapper _mapper;

        public TeachingScheduleServices(IRepository<TeachingSchedule> teachingScheduleRep, IMapper mapper)
        {
            _teachingScheduleRep = teachingScheduleRep ?? throw new ArgumentNullException(nameof(teachingScheduleRep));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        /// <summary>
        /// Thêm mới lịch giảng dạy theo thông tin của đối tượng được truyền xuống
        /// </summary>
        /// <param name="teachingSchedule">Thông tin của lịch giảng dạy</param>
        /// <returns>Trả về true nếu thêm mới thành công, trả về false nếu thêm mới không thành công</returns>
        public async Task<bool> Add(TeachingScheduleCreateVM teachingSchedule)
        {
            try
            {
                int index = 0;
                var listteaching = _teachingScheduleRep.AsQueryable().ToList();
                if (listteaching.Count > 0)
                {
                    index = listteaching.Max(c => c.IndexOfTeachingSchedule);
                }
                var addteachingSchedule = new TeachingSchedule
                {
                    ImportTime = teachingSchedule.ImportTime,
                    IdAdminImport = teachingSchedule.IdAdminImport,
                    SubjectId = teachingSchedule.SubjectId,
                    ClassId = teachingSchedule.ClassId,
                    IdShift = teachingSchedule.IdShift,
                    IndexOfTeachingSchedule = index++,
                    Status = teachingSchedule.Status,
                    IdBlock = teachingSchedule.IdBlock,
                    IdTrainingFacility = teachingSchedule.IdTrainingFacility,
                    IdSemester = teachingSchedule.IdSemester,
                    TeachingDay = teachingSchedule.TeachingDay,
                };
                var result = _teachingScheduleRep.AddAsync(addteachingSchedule);
                await _teachingScheduleRep.SaveChangesAsync();
                return result.IsCompletedSuccessfully;
            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// Xóa lịch giảng dạy theo id bằng với id được truyền xuống
        /// </summary>
        /// <param name="Id">id giảng dạy</param>
        /// <returns>Trả về true nếu xóa thành công, trả về false nếu xóa không thành công</returns>
        public async Task<bool> Delete(Guid Id)
        {
            try
            {
                var ts = _teachingScheduleRep.AsQueryable().FirstOrDefault(c => c.Id == Id);
                ts.Status = 1;//Trạng thái xóa mặc định là 1

                var result = _teachingScheduleRep.UpdateAsync(ts);
                await _teachingScheduleRep.SaveChangesAsync();
                return result.IsCompletedSuccessfully;
            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// Lấy tất cả danh sách lịch giảng dạy
        /// </summary>
        /// <returns>Trả về tất cả danh sách giảng dạy</returns>
        public async Task<List<TeachingScheduleVM>> GetAll()
        {

            var ts = _teachingScheduleRep.AsQueryable();
            var result = ts.Select(c => new TeachingScheduleVM
            {
                Id = c.Id,
                ImportTime = c.ImportTime,
                IdAdminImport = c.IdAdminImport,
                SubjectId = c.SubjectId,
                ClassId = c.ClassId,
                IdShift = c.IdShift,
                IndexOfTeachingSchedule = c.IndexOfTeachingSchedule,
                Status = c.Status,
                IdBlock = c.IdBlock,
                IdSemester = c.IdSemester,
                IdTrainingFacility = c.IdTrainingFacility,
                TeachingDay = c.TeachingDay,
                IdLecturter = c.IdLecturter,
                Note = c.Note,
                Remote = c.Remote,
            }).ToList();
            return result.Where(c => c.Status != 1).ToList();
        }
        /// <summary>
        /// Lấy ra lịch giảng dạy theo id bằng với id được truyền xuống
        /// </summary>
        /// <param name="Id">id giảng dạy</param>
        /// <returns>Trả về lịch giảng dạy theo id bằng với id được truyền xuống</returns>
        public async Task<TeachingScheduleVM> GetById(Guid Id)
        {
            var ts = _teachingScheduleRep.AsQueryable().FirstOrDefault(c => c.Id == Id && c.Status != 1);
            if (ts == null)
            {
                return null;
            }
            var result = new TeachingScheduleVM
            {
                ImportTime = ts.ImportTime,
                IdAdminImport = ts.IdAdminImport,
                SubjectId = ts.SubjectId,
                ClassId = ts.ClassId,
                IdShift = ts.IdShift,
                IndexOfTeachingSchedule = ts.IndexOfTeachingSchedule,
                Status = ts.Status,
                IdBlock = ts.IdBlock,
                IdSemester = ts.IdSemester,
                TeachingDay = ts.TeachingDay,
                IdLecturter = ts.IdLecturter
            };
            return result;
        }
        /// <summary>
        /// Lấy danh sách lịch giảng dạy theo keyword search
        /// </summary>
        /// <param name="search">keyword search</param>
        /// <returns>Trả về danh sách lịch giảng dạy theo keyword search</returns>
        public async Task<PageList<TeachingScheduleVM>> GetForSearch(TeachingScheduleSearch search)
        {
            var ts = _teachingScheduleRep.AsQueryable();
            var result = ts.Select(c => new TeachingScheduleVM
            {
                ImportTime = c.ImportTime,
                IdAdminImport = c.IdAdminImport,
                SubjectId = c.SubjectId,
                ClassId = c.ClassId,
                IdShift = c.IdShift,
                IndexOfTeachingSchedule = c.IndexOfTeachingSchedule,
                Status = c.Status,
                IdBlock = c.IdBlock,
                IdSemester = c.IdSemester,
                TeachingDay = c.TeachingDay,
                IdLecturter = c.IdLecturter
            }).ToList();

            if (!string.IsNullOrEmpty(search.IndexOfTeachingSchedule.ToString()))
            {
                result = result.Where(c => c.IndexOfTeachingSchedule == search.IndexOfTeachingSchedule).ToList();
            }
            var count = result.Count();
            var data = result
                .Skip((search.PageNumber - 1) * search.PageSize)
                .Take(search.PageSize)
                .ToList();

            return new PageList<TeachingScheduleVM>(data, count
                , search.PageNumber
                , search.PageSize);
        }
        /// <summary>
        /// Cập nhật lịch có id bằng id được truyền xuống và theo thông tin đối tượng được truyền xuống
        /// </summary>
        /// <param name="Id">id lịch giảng dạy</param>
        /// <param name="teachingSchedule">thông tin đối tượng</param>
        /// <returns>Trả về true nếu cập nhật thành công, trả về false nếu cập nhật không thành công</returns>
        public async Task<bool> Update(Guid Id, TeachingscheduleUpdateVM teachingSchedule)
        {
            try
            {
                var ts = _teachingScheduleRep.AsQueryable().FirstOrDefault(c => c.Id == Id);

                ts.ImportTime = teachingSchedule.ImportTime;
                ts.IdAdminImport = teachingSchedule.IdAdminImport;
                ts.SubjectId = teachingSchedule.SubjectId;
                ts.ClassId = teachingSchedule.ClassId;
                ts.IdShift = teachingSchedule.IdShift;
                // ts.IndexOfTeachingSchedule = teachingSchedule.IndexOfTeachingSchedule;
                ts.Status = teachingSchedule.Status;
                ts.IdBlock = teachingSchedule.IdBlock;
                ts.IdSemester = teachingSchedule.IdSemester;
                ts.TeachingDay = teachingSchedule.TeachingDay;

                var result = _teachingScheduleRep.UpdateAsync(ts);
                await _teachingScheduleRep.SaveChangesAsync();
                return result.IsCompletedSuccessfully;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> AddTeachingSchedules(TeachingSchedule teachingSchedule)
        {
            var res = await _teachingScheduleRep.AddAsync(teachingSchedule);
            await _teachingScheduleRep.SaveChangesAsync();
            var result = false;
            if (res.Id == teachingSchedule.Id)
            {
                result = true;
            }

            return result;
        }
        public async Task<bool> UpdateTeachingSchedules(TeachingSchedule teachingSchedule)
        {
            var result = false;
            if (teachingSchedule == null)
            {
                return result;
            }
            else
            {
                var res = await _teachingScheduleRep.UpdateAsync(teachingSchedule);
                await _teachingScheduleRep.SaveChangesAsync();

                if (res.Id == teachingSchedule.Id)
                {
                    result = true;
                }
            }


            return result;
        }
        public async Task<TeachingSchedule> GetTeachingScheduleById(Guid Id)
        {
            var listcheck = await _teachingScheduleRep.AsQueryable().ToListAsync();
            var res = listcheck.Where(c => c.Status != 1).FirstOrDefault(c => c.Id == Id);
            return res;
        }

        public async Task<bool> DeteleTeachingSchedules(Guid Id)
        {
            var result = false;
            var listcheck = await _teachingScheduleRep.AsQueryable().AsNoTracking().ToListAsync();
            if (listcheck.Any(c => c.Id == Id) == false)
            {
                return result;
            }
            else
            {
                foreach (var x in listcheck.Where(c => c.Id == Id))
                {
                    x.Status = 1;
                    await _teachingScheduleRep.UpdateAsync(x);
                    await _teachingScheduleRep.SaveChangesAsync();
                }
                return result = true;
            }



        }
    }
}