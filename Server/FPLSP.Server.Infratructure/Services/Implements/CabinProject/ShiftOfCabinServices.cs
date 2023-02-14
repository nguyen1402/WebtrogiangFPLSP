using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.ShiftOfCabin;
using static IdentityServer4.Models.IdentityResources;

namespace FPLSP.Server.Infrastructure.Services.Implements.CabinProject
{
    public class ShiftOfCabinServices : IShiftOfCabinServices
    {
        private IRepository<Shift> _shiftreps;

        private IRepository<TeachingSchedule> _TeachingScheduleReps;
        private IRepository<SemesterBlock> _SemesterBlockReps;
        private IRepository<Semester> _SemesterReps;
        private IRepository<Block> _BlockReps;
        private IRepository<LecturersCP> _LecturersCPReps;
        private IRepository<SubjectClassUP> _SubjectClassReps;
        private IRepository<ClassUp> _ClassReps;
        private IRepository<SubjectUP> _SubjectUPReps;
        private IRepository<BookingCabin> _BookingCabinReps;
        private IRepository<FPLSP.Server.Domain.Entities.CabinProject.Cabin> _CabinReps;
        private IRepository<GroupCabin> _GroupCabinReps;
        private IRepository<SpecializedUP> _SpecializedUPReps;

        public ShiftOfCabinServices(IRepository<Shift> shiftreps,
            IRepository<TeachingSchedule> TeachingScheduleReps,
            IRepository<SemesterBlock> SemesterBlockReps,
         IRepository<Semester> SemesterReps,
        IRepository<Block> BlockReps,
        IRepository<LecturersCP> LecturersCPReps,
        IRepository<SubjectClassUP> SubjectClassReps,
        IRepository<ClassUp> ClassReps,
        IRepository<SubjectUP> SubjectUPReps,
         IRepository<BookingCabin> BookingCabinReps,
         IRepository<FPLSP.Server.Domain.Entities.CabinProject.Cabin> CabinReps,
         IRepository<GroupCabin> GroupCabinReps,
         IRepository<SpecializedUP> SpecializedUPReps
            )
        {
            _shiftreps = shiftreps ?? throw new ArgumentNullException(nameof(shiftreps));
            _TeachingScheduleReps = TeachingScheduleReps;
            _SemesterBlockReps = SemesterBlockReps;
            _SemesterReps = SemesterReps;
            _BlockReps = BlockReps;
            _LecturersCPReps = LecturersCPReps;
            _SubjectClassReps = SubjectClassReps;
            _ClassReps = ClassReps;
            _SubjectUPReps = SubjectUPReps;
            _BookingCabinReps = BookingCabinReps;
            _CabinReps = CabinReps;
            _GroupCabinReps = GroupCabinReps;
            _SpecializedUPReps = SpecializedUPReps;
        }
        /// <summary>
        /// Thêm mới Ca học theo thông tin của đối tượng được truyền xuống
        /// </summary>
        /// <param name="shiftOfCabinVM">Thông tin của đối tượng được thêm mới</param>
        /// <returns>Trả về true nếu thêm mới thành công, trả về false nếu thêm mới không thành công</returns>
        public async Task<bool> Add(ShiftOfCabinCreateVM shiftOfCabinVM)
        {
            try
            {
                int index = 0;
                var listshift = _shiftreps.AsQueryable().ToList();
                if (listshift.Count > 0)
                {
                    index = listshift.Max(c => c.IndexOfShift);
                }
                var shift = new Shift
                {
                    ShiftName = shiftOfCabinVM.ShiftName,
                    IndexOfShift = index++,
                    StartTime = shiftOfCabinVM.StartTime,
                    EndTime = shiftOfCabinVM.EndTime,
                    Status = shiftOfCabinVM.Status
                };
                var result = _shiftreps.AddAsync(shift);
                await _shiftreps.SaveChangesAsync();
                return result.IsCompletedSuccessfully;
            }
            catch (Exception)
            {

                return false;
            }

        }
        /// <summary>
        /// Xóa Ca với id bằng với id được truyền vào
        /// </summary>
        /// <param name="Id">id Ca</param>
        /// <returns>Trả về true nếu xóa thành công, trả về false nếu xóa không thành công</returns>
        public async Task<bool> Delete(Guid Id)
        {
            try
            {
                var shift = _shiftreps.AsQueryable().FirstOrDefault(c => c.Id == Id);
                shift.Status = 1; //Trạng thái mặc định khi xóa
                var result = _shiftreps.UpdateAsync(shift);

                await _shiftreps.SaveChangesAsync();
                return result.IsCompletedSuccessfully;
            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// Lấy tất cả các Ca
        /// </summary>
        /// <returns>Trả ra danh sách tất cả các Ca</returns>
        public async Task<List<ShiftOfCabinVM>> GetAll()
        {
            var shift = _shiftreps.AsQueryable().Where(c => c.Status != 1).ToList();
            var result = shift.Select(c => new ShiftOfCabinVM
            {
                Id = c.Id,
                ShiftName = c.ShiftName,
                IndexOfShift = c.IndexOfShift,
                StartTime = c.StartTime,
                EndTime = c.EndTime,
                Status = c.Status
            }).ToList();
            return result;
        }

        public async Task<List<ShiftOfCabinFullVM>> GetAllInformationOfShiftOfCabin()
        {
            var listShift = _shiftreps.AsQueryable().ToList();
            var listTeachingSchedule = _TeachingScheduleReps.AsQueryable().ToList();
            listTeachingSchedule = listTeachingSchedule.Where(c => c.Status != 1).ToList();
            var listSemesterBlock = _SemesterBlockReps.AsQueryable().ToList();
            var listSemester = _SemesterReps.AsQueryable().ToList();
            var listBlock = _BlockReps.AsQueryable().ToList();
            //var listSubjectClassUP = _SubjectClassReps.AsQueryable().ToList();
            var listClassUP = _ClassReps.AsQueryable().ToList();
            var listSubjectUP = _SubjectUPReps.AsQueryable().ToList();
            var listLecturersCP = _LecturersCPReps.AsQueryable().ToList();
            var listBookingCabin = _BookingCabinReps.AsQueryable().ToList();
            var listCabin = _CabinReps.AsQueryable().ToList();
            var listGroupCabin = _GroupCabinReps.AsQueryable().ToList();
            var listSpecialized = _SpecializedUPReps.AsQueryable().ToList();

            if (listShift.Count != 0)
            {
                var listShiftForScheduleInBlock = from shift in listShift
                                                  join schedule in listTeachingSchedule
                                                  on shift.Id equals schedule.IdShift into ShiftAndSchedule
                                                  from shiftSchedule in ShiftAndSchedule.DefaultIfEmpty()
                                                  select new ShiftOfCabinFullVM()
                                                  {
                                                      IdShiftOfCabin = /*(shiftSchedule == null) ? null :*/ shift.Id,
                                                      //TeachingSchedule
                                                      IdTrainingFacility = (shiftSchedule == null) ? null : shiftSchedule.IdTrainingFacility,
                                                      IdBlock = (shiftSchedule == null) ? null : shiftSchedule.IdBlock,
                                                      IdSemester = (shiftSchedule == null) ? null : shiftSchedule.IdSemester,
                                                      IdClass = (shiftSchedule == null) ? null : shiftSchedule.ClassId,
                                                      IdSubject = (shiftSchedule == null) ? null : shiftSchedule.SubjectId,
                                                      IdLecturer = (shiftSchedule == null) ? null : shiftSchedule.IdLecturter,
                                                      IdCabin = (shiftSchedule == null || listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift && c.DateCreated.Year == shiftSchedule.TeachingDay.Year && c.DateCreated.Month == shiftSchedule.TeachingDay.Month && c.DateCreated.Day == shiftSchedule.TeachingDay.Day) == null) ? null : listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift && c.DateCreated.Year == shiftSchedule.TeachingDay.Year && c.DateCreated.Month == shiftSchedule.TeachingDay.Month && c.DateCreated.Day == shiftSchedule.TeachingDay.Day).IdCabin,
                                                      IdSpecialized = (shiftSchedule == null || listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift && c.DateCreated.Year == shiftSchedule.TeachingDay.Year && c.DateCreated.Month == shiftSchedule.TeachingDay.Month && c.DateCreated.Day == shiftSchedule.TeachingDay.Day) == null || listGroupCabin.FirstOrDefault(c => c.Status != 1 && c.IdCabin == listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift && c.DateCreated.Year == shiftSchedule.TeachingDay.Year && c.DateCreated.Month == shiftSchedule.TeachingDay.Month && c.DateCreated.Day == shiftSchedule.TeachingDay.Day).IdCabin) == null) ? null : listGroupCabin.FirstOrDefault(c => c.Status != 1 && c.IdCabin == listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift && c.DateCreated.Year == shiftSchedule.TeachingDay.Year && c.DateCreated.Month == shiftSchedule.TeachingDay.Month && c.DateCreated.Day == shiftSchedule.TeachingDay.Day).IdCabin).IdSpec,
                                                      // Dựa vào IdShiftOfCabin
                                                      ShiftName = /*(shiftSchedule == null) ? null :*/ listShift.FirstOrDefault(c => c.Id == shift.Id).ShiftName,
                                                      StartTimeOfShift = /*(shiftSchedule == null) ? null :*/ listShift.FirstOrDefault(c => c.Id == shift.Id).StartTime,
                                                      EndTimeOfShift =/*(shiftSchedule == null) ? null :*/ listShift.FirstOrDefault(c => c.Id == shift.Id).EndTime,

                                                      // Dựa vào IdBlock, IdSemester
                                                      BlockName = (shiftSchedule == null || listBlock.FirstOrDefault(c => c.Id == shiftSchedule.IdBlock) == null) ? null : listBlock.FirstOrDefault(c => c.Id == shiftSchedule.IdBlock).NameOfBlock,
                                                      SemesterName = (shiftSchedule == null || listSemester.FirstOrDefault(c => c.Id == shiftSchedule.IdSemester) == null) ? null : listSemester.FirstOrDefault(c => c.Id == shiftSchedule.IdSemester).NameofSemester,
                                                      StartTimeOfSemesterBlock = (shiftSchedule == null || listSemesterBlock.FirstOrDefault(c => c.IdBlock == shiftSchedule.IdBlock && c.IdSemester == shiftSchedule.IdSemester) == null) ? null : listSemesterBlock.FirstOrDefault(c => c.IdBlock == shiftSchedule.IdBlock && c.IdSemester == shiftSchedule.IdSemester).StartTime,
                                                      EndTimeOfSemesterBlock = (shiftSchedule == null || listSemesterBlock.FirstOrDefault(c => c.IdBlock == shiftSchedule.IdBlock && c.IdSemester == shiftSchedule.IdSemester) == null) ? null : listSemesterBlock.FirstOrDefault(c => c.IdBlock == shiftSchedule.IdBlock && c.IdSemester == shiftSchedule.IdSemester).EndTime,
                                                      TeachingDay = (shiftSchedule == null) ? null : shiftSchedule.TeachingDay,

                                                      // Dựa vào IdClass, IdSubject
                                                      ClassName = (shiftSchedule == null || listClassUP.FirstOrDefault(c => c.Id == shiftSchedule.ClassId) == null) ? null : listClassUP.FirstOrDefault(c => c.Id == shiftSchedule.ClassId).ClassroomName,
                                                      SubjectCode = (shiftSchedule == null || listSubjectUP.FirstOrDefault(c => c.Id == shiftSchedule.SubjectId) == null) ? null : listSubjectUP.FirstOrDefault(c => c.Id == shiftSchedule.SubjectId).SubjectCode,

                                                      // Dựa vào IdLecturer
                                                      LecturerName = (shiftSchedule == null || listLecturersCP.FirstOrDefault(c => c.Id == shiftSchedule.IdLecturter) == null) ? null : listLecturersCP.FirstOrDefault(c => c.Id == shiftSchedule.IdLecturter).LecturersName,
                                                      LecturerUserName = (shiftSchedule == null || listLecturersCP.FirstOrDefault(c => c.Id == shiftSchedule.IdLecturter) == null) ? null : listLecturersCP.FirstOrDefault(c => c.Id == shiftSchedule.IdLecturter).Email.Substring(0, listLecturersCP.FirstOrDefault(c => c.Id == shiftSchedule.IdLecturter).Email.Length - 11),

                                                      // Dựa vào IdCabin
                                                      CabinName = (shiftSchedule == null || listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift && c.DateCreated.Year == shiftSchedule.TeachingDay.Year && c.DateCreated.Month == shiftSchedule.TeachingDay.Month && c.DateCreated.Day == shiftSchedule.TeachingDay.Day) == null) ? null : listCabin.FirstOrDefault(c => c.Id == listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift && c.DateCreated.Year == shiftSchedule.TeachingDay.Year && c.DateCreated.Month == shiftSchedule.TeachingDay.Month && c.DateCreated.Day == shiftSchedule.TeachingDay.Day).IdCabin).CabinName,
                                                      BuildingName = shiftSchedule == null || (listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift && c.DateCreated.Year == shiftSchedule.TeachingDay.Year && c.DateCreated.Month == shiftSchedule.TeachingDay.Month && c.DateCreated.Day == shiftSchedule.TeachingDay.Day) == null) ? null : listCabin.FirstOrDefault(c => c.Id == listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift && c.DateCreated.Year == shiftSchedule.TeachingDay.Year && c.DateCreated.Month == shiftSchedule.TeachingDay.Month && c.DateCreated.Day == shiftSchedule.TeachingDay.Day).IdCabin).BuildingName,

                                                      // Dựa vào IdSpecialized
                                                      SpecializedName = (shiftSchedule == null || listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift && c.DateCreated.Year == shiftSchedule.TeachingDay.Year && c.DateCreated.Month == shiftSchedule.TeachingDay.Month && c.DateCreated.Day == shiftSchedule.TeachingDay.Day) == null || listGroupCabin.FirstOrDefault(c => c.Status != 1 && c.IdCabin == listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift && c.DateCreated.Year == shiftSchedule.TeachingDay.Year && c.DateCreated.Month == shiftSchedule.TeachingDay.Month && c.DateCreated.Day == shiftSchedule.TeachingDay.Day).IdCabin) == null) ? null : listSpecialized.FirstOrDefault(c => c.Id == listGroupCabin.FirstOrDefault(c => c.Status != 1 && c.IdCabin == listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift && c.DateCreated.Year == shiftSchedule.TeachingDay.Year && c.DateCreated.Month == shiftSchedule.TeachingDay.Month && c.DateCreated.Day == shiftSchedule.TeachingDay.Day).IdCabin).IdSpec).SpecializationName

                                                  };
                if (listShiftForScheduleInBlock != null)
                {
                    listShiftForScheduleInBlock = listShiftForScheduleInBlock.ToList();
                    //listShiftForScheduleInBlock = listShiftForScheduleInBlock.Where(c => c.LecturerName.Equals("Nguyễn Thị Thanh Bình")).ToList();
                    return listShiftForScheduleInBlock.ToList();
                }

            }
            return new List<ShiftOfCabinFullVM>();
        }

        public async Task<List<ShiftOfCabinFullVM>> GetAllInformationOfShiftOfCabinIsNotDeleted()
        {
            var listShift = _shiftreps.AsQueryable().Where(c => c.Status != 1).ToList();
            var listTeachingSchedule = _TeachingScheduleReps.AsQueryable().Where(c => c.Status != 1).ToList();
            var listSemesterBlock = _SemesterBlockReps.AsQueryable().Where(c => c.Status != 1).ToList();
            var listSemester = _SemesterReps.AsQueryable().Where(c => c.Status != 1).ToList();
            var listBlock = _BlockReps.AsQueryable().Where(c => c.Status != 1).ToList();
            var listSubjectClassUP = _SubjectClassReps.AsQueryable().Where(c => c.Status != 1).ToList();
            var listClassUP = _ClassReps.AsQueryable().Where(c => c.Status != 1).ToList();
            var listSubjectUP = _SubjectUPReps.AsQueryable().Where(c => c.Status != 1).ToList();
            var listLecturersCP = _LecturersCPReps.AsQueryable().Where(c => c.Status != 1).ToList();
            var listBookingCabin = _BookingCabinReps.AsQueryable().Where(c => c.Status != 1).ToList();
            var listCabin = _CabinReps.AsQueryable().Where(c => c.Status != 1).ToList();
            var listGroupCabin = _GroupCabinReps.AsQueryable().Where(c => c.Status != 1).ToList();
            var listSpecialized = _SpecializedUPReps.AsQueryable().Where(c => c.Status != 1).ToList();

            if (listShift.Count != 0)
            {
                var listShiftForScheduleInBlock = from shift in listShift
                                                  join schedule in listTeachingSchedule
                                                  on shift.Id equals schedule.IdShift into ShiftAndSchedule
                                                  from shiftSchedule in ShiftAndSchedule.DefaultIfEmpty()
                                                  select new ShiftOfCabinFullVM()
                                                  {
                                                      IdShiftOfCabin = (shiftSchedule == null) ? null : shift.Id,
                                                      //TeachingSchedule
                                                      IdBlock = (shiftSchedule == null) ? null : shiftSchedule.IdBlock,
                                                      IdSemester = (shiftSchedule == null) ? null : shiftSchedule.IdSemester,
                                                      IdClass = (shiftSchedule == null) ? null : shiftSchedule.ClassId,
                                                      IdSubject = (shiftSchedule == null) ? null : shiftSchedule.SubjectId,
                                                      IdLecturer = (shiftSchedule == null) ? null : listSubjectClassUP.FirstOrDefault(c => c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId).HomeroomLecturer,
                                                      IdCabin = (listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift) == null) ? null : listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift).IdCabin,
                                                      IdSpecialized = (listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift) == null || listGroupCabin.FirstOrDefault(c => c.Status != 1 && c.IdCabin == listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift).IdCabin) == null) ? null : listGroupCabin.FirstOrDefault(c => c.Status != 1 && c.IdCabin == listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift).IdCabin).IdSpec,
                                                      // Dựa vào IdShiftOfCabin
                                                      ShiftName = (shiftSchedule == null) ? null : listShift.FirstOrDefault(c => c.Id == shift.Id).ShiftName,
                                                      StartTimeOfShift = (shiftSchedule == null) ? null : listShift.FirstOrDefault(c => c.Id == shift.Id).StartTime,
                                                      EndTimeOfShift = (shiftSchedule == null) ? null : listShift.FirstOrDefault(c => c.Id == shift.Id).EndTime,

                                                      // Dựa vào IdBlock, IdSemester
                                                      BlockName = (shiftSchedule == null) ? null : listBlock.FirstOrDefault(c => c.Id == shiftSchedule.IdBlock).NameOfBlock,
                                                      SemesterName = (shiftSchedule == null) ? null : listSemester.FirstOrDefault(c => c.Id == shiftSchedule.IdSemester).NameofSemester,
                                                      StartTimeOfSemesterBlock = (shiftSchedule == null) ? null : listSemesterBlock.FirstOrDefault(c => c.IdBlock == shiftSchedule.IdBlock && c.IdSemester == shiftSchedule.IdSemester).StartTime,
                                                      EndTimeOfSemesterBlock = (shiftSchedule == null) ? null : listSemesterBlock.FirstOrDefault(c => c.IdBlock == shiftSchedule.IdBlock && c.IdSemester == shiftSchedule.IdSemester).EndTime,
                                                      TeachingDay = (shiftSchedule == null) ? null : shiftSchedule.TeachingDay,

                                                      // Dựa vào IdClass, IdSubject
                                                      ClassName = (shiftSchedule == null) ? null : listClassUP.FirstOrDefault(c => c.Id == shiftSchedule.ClassId).ClassroomName,
                                                      SubjectCode = (shiftSchedule == null) ? null : listSubjectUP.FirstOrDefault(c => c.Id == shiftSchedule.SubjectId).SubjectCode,

                                                      // Dựa vào IdLecturer
                                                      LecturerName = (shiftSchedule == null) ? null : listLecturersCP.FirstOrDefault(c => c.Id == listSubjectClassUP.FirstOrDefault(c => c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId).HomeroomLecturer).LecturersName,

                                                      // Dựa vào IdCabin
                                                      CabinName = (listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift) == null) ? null : listCabin.FirstOrDefault(c => c.Id == listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift).IdCabin).CabinName,
                                                      BuildingName = (listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift) == null) ? null : listCabin.FirstOrDefault(c => c.Id == listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift).IdCabin).BuildingName,

                                                      // Dựa vào IdSpecialized
                                                      SpecializedName = (listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift) == null || listGroupCabin.FirstOrDefault(c => c.Status != 1 && c.IdCabin == listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift).IdCabin) == null) ? "Khác" : listSpecialized.FirstOrDefault(c => c.Id == listGroupCabin.FirstOrDefault(c => c.Status != 1 && c.IdCabin == listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == shiftSchedule.SubjectId && c.ClassId == shiftSchedule.ClassId && c.IdShift == shiftSchedule.IdShift).IdCabin).IdSpec).SpecializationName

                                                  };
                if (listShiftForScheduleInBlock != null)
                {
                    return listShiftForScheduleInBlock.ToList();
                }

            }

            return new List<ShiftOfCabinFullVM>();
        }

        /// <summary>
        /// Lấy ra Ca theo id bằng id được truyền xuống
        /// </summary>
        /// <param name="Id">id Ca</param>
        /// <returns>Trả về đối tượng với id bằng id được truyền vào</returns>
        public async Task<ShiftOfCabinVM> GetById(Guid Id)
        {
            var shift = _shiftreps.AsQueryable().FirstOrDefault(c => c.Id == Id && c.Status != 1);
            var result = new ShiftOfCabinVM
            {
                ShiftName = shift.ShiftName,
                IndexOfShift = shift.IndexOfShift,
                StartTime = shift.StartTime,
                EndTime = shift.EndTime,
                Status = shift.Status
            };
            return result;
        }
        /// <summary>
        /// Lấy ra danh sách theo keyword searh 
        /// </summary>
        /// <param name="search">keyword search</param>
        /// <returns>Trả về danh sách Ca theo keyword search</returns>
        public async Task<PageList<ShiftOfCabinVM>> GetForSearch(ShiftOfCabinSearch search)
        {
            var shift = _shiftreps.AsQueryable().Where(c => c.Status != 1).ToList();
            var result = shift.Select(c => new ShiftOfCabinVM
            {
                Id = c.Id,
                ShiftName = c.ShiftName,
                IndexOfShift = c.IndexOfShift,
                StartTime = c.StartTime,
                EndTime = c.EndTime,
                Status = c.Status
            }).ToList();
            if (!string.IsNullOrEmpty(search.ShiftName))
            {
                result = result.Where(c => c.ShiftName.Contains(search.ShiftName)).ToList();
            }
            var count = result.Count();
            var data = result
                .Skip((search.PageNumber - 1) * search.PageSize)
                .Take(search.PageSize)
                .ToList();

            return new PageList<ShiftOfCabinVM>(data, count
                , search.PageNumber
                , search.PageSize);
        }
        /// <summary>
        /// Cập nhật Ca có id bằng với id được truyền xuống theo thôn tin đối tượng được truyền xuống
        /// </summary>
        /// <param name="Id">id Ca</param>
        /// <param name="shiftOfCabinVM">thông tin Ca</param>
        /// <returns>Trả về true nếu cập nhật thành công, trả về false nếu cập nhật không thành công</returns>
        public async Task<bool> Update(Guid Id, ShiftOfCabinUpdateVM shiftOfCabinVM)
        {
            try
            {
                var shift = _shiftreps.AsQueryable().FirstOrDefault(c => c.Id == Id);

                shift.ShiftName = shiftOfCabinVM.ShiftName;
                shift.IndexOfShift = shiftOfCabinVM.IndexOfShift;
                shift.StartTime = shiftOfCabinVM.StartTime;
                shift.EndTime = shiftOfCabinVM.EndTime;
                shift.Status = shiftOfCabinVM.Status;

                var result = _shiftreps.UpdateAsync(shift);
                await _shiftreps.SaveChangesAsync();
                return result.IsCompletedSuccessfully;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
