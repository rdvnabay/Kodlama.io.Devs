namespace Core.Domain.Entities.Base;

public class Entity : Entity<int> { }
public class Entity<T> : IEntity
{
    public T Id { get; set; }
}
