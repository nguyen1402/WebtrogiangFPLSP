namespace FPLSP.Server.Domain.Entities.EntitiesBase;

public interface IEntityBase<TKey> : IEntity
{
    TKey Id { get; }
}