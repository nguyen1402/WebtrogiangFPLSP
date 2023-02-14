namespace FPLSP.Server.Data.SeedWork
{
    public class PageForTeachingSchedule<T>
    {
        public MetaData MetaData { get; set; }
        public List<T> Items { set; get; }

        public PageForTeachingSchedule() { }
        //Class Này Sẽ Nhận 1 List  Truyền Vào Và Để Thực Hiện Tính Toán Và Biết Được Số Trang Hiện Tại Để Có Thể Tính Toán Ra Số Bản Ghi Hiển Thị
        public PageForTeachingSchedule(List<T> items, int count, int pageNumber, int pageSize)
        {
            MetaData = new MetaData
            {
                TotalCount = count,
                PageSize = pageSize,
                CurrentPage = pageNumber,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize)// Math.Ceiling Làm Tròn
                                                                        // Để Chia Ra Tổng Số Trang Ví Dụ Như 1 List Có 3 Phần Tử
                                                                        // Mà Người Dùng Muốn Hiển Thị 2 Bản Ghi Trên 1 Trang Thì 3/2 Không Thể Nào Mà Để Tổng Số Trang Là 1.5 Trang Được
                                                                        //Mà Bắt Buộc Phải Làm Tròn Lên Thành Tổng 2 Trang
            };
            Items = items;
        }



    }
}
