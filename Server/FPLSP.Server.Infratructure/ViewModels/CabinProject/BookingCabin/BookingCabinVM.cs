using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingCabin
{
    public class BookingCabinVM
    {
        public Guid Id { get; set; }
        public Guid SubjectId { get; set; }
        public Guid ClassId { get; set; }
        public Guid IdCabin { get; set; }
        public Guid IdShift { get; set; }
        public DateTime DateCreated { get; set; }
        //xong hết các quan hệ
        public byte[] CheckinImage { get; set; }//Lưu ảnh theo kiểu byte
        public DateTime CheckinTime { get; set; }
        public DateTime CheckoutTime { get; set; }
        public int IndexOfBookingCabin { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public Guid IdLectuter { get; set; }
        //quan hệ với các bảng
    }
}
