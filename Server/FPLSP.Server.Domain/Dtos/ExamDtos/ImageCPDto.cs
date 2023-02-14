namespace FPLSP.Server.Domain.Dtos
{
    public class ImageCPDto
    {
        public Guid Id { get; set; }
        public Guid CoeId { get; set; }
        public string Path { get; set; }
        public string Descriptions { get; set; }
        public int Status { get; set; }
    }
}
