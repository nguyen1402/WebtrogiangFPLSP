using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.NewFeed
{
    public class NewFeedVM
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public Guid? IdLesson { get; set; }
        public string? Image { get; set; }
        [Required]
        public int Status { get; set; }
        public DateTime CratedTime { get; set; }
        public DateTime EndDate { get; set; }

        [Required]
        public int Priority { get; set; }
        [Required]
        //xét đến khóa ngoại
        public bool IsReaded { get; set; }
        public string IdUser { get; set; }
        public Guid? IdClass { get; set; }
        public Guid? IdSubject { get; set; }
        public Guid? IdTypeOfNewFeed { get; set; }



    }
}
