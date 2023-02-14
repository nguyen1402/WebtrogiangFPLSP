using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.CabinProject.ShiftOfCabin
{
    public class ShiftOfCabinFullVM
    {
        // ShiftOfCabin
        public Guid? IdShiftOfCabin { get; set; }
        //TeachingSchedule
        public Guid? IdBlock { get; set; }
        public Guid? IdSemester { get; set; }
        public Guid? IdClass { get; set; }
        public Guid? IdSubject { get; set; }
        public Guid? IdLecturer { get; set; }
        public Guid? IdCabin { get; set; }
        //public Guid? IdGroupCabin { get; set; }
        public Guid? IdSpecialized { get; set; }
        public Guid? IdTrainingFacility { get; set; }

        // Dựa vào IdShiftOfCabin
        public string ShiftName { get; set; }
        public TimeSpan? StartTimeOfShift { get; set; }
        public TimeSpan? EndTimeOfShift { get; set; }

        // Dựa vào IdBlock, IdSemester
        public string BlockName { get; set; }
        public string SemesterName { get; set; }
        public DateTime? StartTimeOfSemesterBlock { get; set; }
        public DateTime? EndTimeOfSemesterBlock { get; set; }
        public DateTime? TeachingDay { get; set; }

        // Dựa vào IdClass, IdSubject
        public string ClassName { get; set; }
        public string SubjectCode { get; set; }

        // Dựa vào IdLecturer
        public string LecturerName { get; set; }
        public string LecturerUserName { get; set; }
        // Dựa vào IdCabin
        public string CabinName { get; set; }
        public string BuildingName { get; set; }

        // Dựa vào IdTrainingFacility { get; set; }
        public string TrainingFacilityName { get; set; }

        // Dựa vào IdSpecialized
        public string SpecializedName { get; set; }
    }
}
