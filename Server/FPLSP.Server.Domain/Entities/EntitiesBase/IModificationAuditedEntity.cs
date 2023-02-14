namespace FPLSP.Server.Domain.Entities.EntitiesBase;

public interface IModificationAuditedEntity
{
    DateTimeOffset ModifiedTime { get; }
    Guid? ModifiedBy { get; }
}