namespace FPLSP.Server.Infrastructure.ViewModels.BookMark
{
    public class BookMarkClassVM
    {

        public Guid Id { get; set; }
        //[Required(ErrorMessage = "Status Must Be Checked")]
        //[RegularExpression(@"\d{1}$",
        // ErrorMessage = "Invalid Status")]
        //[Range(0, 3, ErrorMessage = "Status InValid")]
        public int Status { get; set; }
        //[Required(ErrorMessage = "Priority Must Be Checked")]
        //[RegularExpression(@"\d{1}$",
        // ErrorMessage = "Invalid Priority")]
        //[Range(0, 100, ErrorMessage = "Priority InValid")]
        public int Priority { get; set; }
        //[Required]
        public bool IsBookMark { get; set; }

        //[Required]
        public string IdUser { get; set; }


        //[Required]
        public Guid? IdClass { get; set; }
        // [Required]
        public Guid? IdSubject { get; set; }

    }
}
