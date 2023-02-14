namespace FPLSP.Server.Domain.Entities.EntitiesBase;

public interface IAuditedEntity : ICreationAuditedEntity,
    IModificationAuditedEntity,
    IDeletionAuditedEntity,
    IEntity
{

}