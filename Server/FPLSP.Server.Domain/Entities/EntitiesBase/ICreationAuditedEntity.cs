namespace FPLSP.Server.Domain.Entities.EntitiesBase;

public interface ICreationAuditedEntity
{
    DateTimeOffset CreatedTime { get; }

    Guid? CreatedBy { get; }
}