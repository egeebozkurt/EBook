﻿using System.Linq.Expressions;

namespace Repositories.Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        Task CreateAsync (T entity); 
        Task UpdateAsync(T entity); 
        Task DeleteAsync(T entity); 
        Task SaveAsync(); 
    }

}
