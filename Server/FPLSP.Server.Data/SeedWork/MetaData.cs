namespace FPLSP.Server.Data.SeedWork
{
    public class MetaData
    {
        //Đây Là Class Sẽ Đảm Nhiệm Việc Tạo Phân Trang Cho Các Phần Với Các Thuộc Tính Dưới Đây
        public int CurrentPage { get; set; }// Trang Hiện Tại
        public int TotalPages { get; set; }//Tổng Số Trang
        public int PageSize { get; set; }//Số Lượng Bản Ghi Hiển Thị Trên 1 Trang
        public int TotalCount { get; set; }//Tổng Số Trang
        public bool HasPrevious => CurrentPage > 1;//Kiểm Tra Xem Trang Hiện Tại Có Lớn Hơn 1 Không Để Có Thể Lùi Lại
        public bool HasNext => CurrentPage < TotalPages;////Kiểm Tra Xem Trang Hiện Tại Có Nhỏ Hơn Tổng Số Trang(Tức Là Trang Cuối Cùng) Để Có Thể Tiến Thêm 1 Trang Nữa
    }
}
