namespace FPLSP.Server.Infrastructure.ViewModels.NewFeed
{
    public class NewFeedOverView
    {

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string? Image { get; set; }

        public int Status { get; set; }
        public DateTime CratedTime { get; set; }


        public DateTime EndDate { get; set; }
        public string Sender { get; set; }
        public string TypeOfNewFeed { get; set; }
        public int Priority { get; set; }
        //xét đến khóa ngoại
        public bool IsReaded { get; set; }
        public string ClassName { get; set; }
        public string SubjectName { get; set; }
        public Guid IdLesson { get; set; }
        public string UserName { get; set; }
        public string IdUser { get; set; }
        public Guid? IdClass { get; set; }
        public Guid? IdSubject { get; set; }
        public Guid? IdTypeOfNewFeed { get; set; }



    }
}
