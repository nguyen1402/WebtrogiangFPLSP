namespace FPLSP.Server.Domain.Entities.UserParts
{
    public class TypeOfNewFeed
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }

        public virtual ICollection<News> News { get; set; }
    }
}
