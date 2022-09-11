namespace Core.Application.BusinessRules;

public abstract class GlobalBusinessRules
{
    public void NullCheck<T>(T entity) => ArgumentNullException.ThrowIfNull(entity);
}
