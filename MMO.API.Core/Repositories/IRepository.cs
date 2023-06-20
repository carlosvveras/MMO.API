using MMO.API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MMO.API.Core.Repositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetById(int id);
        Task<T> AddAsync(T entity);
        Task DeleteAsync(int id);
        Task<bool> UpdateAsync(int id, T entity);
    }
}

