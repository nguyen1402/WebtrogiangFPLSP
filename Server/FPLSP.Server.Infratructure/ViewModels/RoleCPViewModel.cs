namespace FPLSP.Server.Infrastructure.ViewModels
{

    public class RoleCPViewModel
    {
        public Guid Id { get; set; }
        public string RoleCode { get; set; }
        public int Status { get; set; }
        public string RoleName { get; set; }
        public bool IsChecked { get; set; } = false;
    }
}
