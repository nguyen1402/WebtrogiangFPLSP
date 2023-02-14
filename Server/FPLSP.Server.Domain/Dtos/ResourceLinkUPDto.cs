namespace FPLSP.Server.Domain.Dtos
{
    public class ResourceLinkUPDto
    {
        public Guid Id { get; set; }
        public string ResourcesTitle { get; set; }
        public string Path { get; set; }
        public string? Descriptions { get; set; }
        public int Status { get; set; }
        public bool IsChecked { get; set; } = false;
    }
}
