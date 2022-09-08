﻿using Core.Persistence.Paging;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
namespace Core.Persistence.Repositories;

public interface IAsyncRepository<TEntity>
{
    Task<IPaginate<TEntity>> GetListAsync(
        int index = 0, int size = 10,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        CancellationToken cancellationToken = default);

    Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> query);
    Task<TEntity> AddAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task<TEntity> DeleteAsync(TEntity entity);
    Task<bool> AnyAsync(Expression<Func<TEntity, bool>> query);
}
