using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;

namespace FPLSP.Repositories.Interfaces.FPLExam
{
    public interface IExaminationRoomDetailRepo
    {
        Task<List<ExaminationRoomDetail>> GetAllExaminationRoomDetail();
        Task<PageList<ExaminationRoomDetailViewModel>> GetALlOfficialExaminationroom(ExamRoomDetailSearch examRoomDetailSearch);
        Task<List<ExaminationRoomDetailViewModel>> GetALlOfficialForSupervisor(Guid IdSuper);
        Task<List<ExaminationRoomDetailViewModel>> GetALlOfficialForStudent(Guid IdStu);
        Task<List<ExaminationRoomDetailViewModel>> GetExamFileForSubject(Guid IdSubject);
        Task<ExaminationRoomDetailViewModel> GetExaminamRoomDetailBySecret(string SercretKey);
        Task<bool> AddingRangeExamRoomDtail(ExamDetaiRoomForAdding examDetaiRoomForAdding);
        Task<bool> UpdatingExamRoomDtail(ExaminationRoomDetailViewModel examinationRoomDetailView);
        Task<bool> DeletingExamRoomDtail(ExaminationRoomDetailViewModel examinationRoomDetailView);
        Task<bool> AutoHideExamRoomDtail(ExaminationRoomDetailViewModel examinationRoomDetailView);
        string RandomString(int length);
        Task<byte[]> GetExamFileBySerceate(string Secret);

        Task<List<LecturersCP>> GetAllLectureAddExam();


    }
}
