using Core.Domain.Entities;
using Core.Persistence.Paging;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.Persistence.Repositories;
public class EfRepositoryBase<TContext, TEntity> : IAsyncRepository<TEntity>
    where TContext : DbContext
    where TEntity : class, IEntity
{
    protected TContext Context { get; }
    public EfRepositoryBase(TContext context)
    {
        Context = context;
    }

    public async Task<IPaginate<TEntity>> GetListAsync(int index = 0, int size = 10, CancellationToken cancellationToken = default)
    {
        IQueryable<TEntity> queryable = Context.Set<TEntity>();
        return await queryable.ToPaginateAsync(index, size, 0, cancellationToken);
    }

    public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> query)
        => await Context.Set<TEntity>().FirstOrDefaultAsync(query);

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        Context.Entry(entity).State = EntityState.Added;
        await Context.SaveChangesAsync();
        return entity;
    }
    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        Context.Entry(entity).State = EntityState.Modified;
        await Context.SaveChangesAsync();
        return entity;
    }

    public async Task<TEntity> DeleteAsync(TEntity entity)
    {
        Context.Entry(entity).State = EntityState.Deleted;
        await Context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> query)
        => await Context.Set<TEntity>().AnyAsync(query);
}
