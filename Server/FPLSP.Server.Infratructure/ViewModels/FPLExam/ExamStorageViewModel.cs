namespace FPLSP.Server.Infrastructure.ViewModels.FPLExam
{
    public class ExamStorageViewModel
    {

        public Guid Id { get; set; }
        public DateTime CreateTime { get; set; }
        public string FileName { get; set; }
        public byte[] ExamFile { get; set; }
        public int IndexOfExamStorageFile { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }

        public DateTime DeleteTime { get; set; }

        public Guid SubjectId { get; set; }
        public string IdUserUpLoad { get; set; }
        //
        public string UserNameUpload { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }


    }
}
