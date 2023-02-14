namespace FPLSP.Server.Domain.Entities.EntitiesBase;

public interface IDeletionAuditedEntity
{
    bool IsDeleted { get; }

    Guid? DeletedBy { get; }

    DateTimeOffset DeletedTime { get; }
}