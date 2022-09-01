namespace Core.Domain.Entities;

public class Entity<TIdentity> : IEntity
{
    public TIdentity Id { get; set; }
}
