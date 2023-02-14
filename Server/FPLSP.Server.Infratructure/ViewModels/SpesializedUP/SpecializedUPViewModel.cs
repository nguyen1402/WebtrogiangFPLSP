using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.SpesializedUP
{
    public class SpecializedUPViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống Mã Chuyên Ngành Hẹp")]
        [RegularExpression(@"^[A-Z''-'\d/s/]{1,10}$", ErrorMessage = "Mã Chuyên Ngành Hẹp phải in hoa, không được có kí tự đặc biệt, tối đa 10 kí tự")]
        public string SpecializedCode { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống Tên Chuyên Ngành Hẹp")]
        public string SpecializationName { get; set; }

        public int Status { get; set; }

        public Guid? SpecialityId { get; set; }

        public int Level { get; set; }

        public DateTimeOffset CreateTime { get; set; }

        public Guid CreateBy { get; set; }

        public DateTimeOffset ModifiedTime { get; set; }

        public Guid ModifiedBy { get; set; }

        public bool IsDeleted { get; set; }

        public Guid DeletedBy { get; set; }

        public DateTimeOffset DeletedTime { get; set; }


    }
}
