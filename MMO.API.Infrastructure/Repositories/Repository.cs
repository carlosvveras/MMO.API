using Microsoft.EntityFrameworkCore;
using MMO.API.Core.Entities;
using MMO.API.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MMO.API.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly MMO_DbContext dbcontext;
        private DbSet<T> set;

        public Repository(MMO_DbContext _dbcontext)
        {
            this.dbcontext = _dbcontext;
            this.set = _dbcontext.Set<T>();

            //this.dbcontext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public async Task<T> GetById(int id)
        {
            return await set.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await set.ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await set.AddAsync(entity);
            await dbcontext.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await set.FindAsync(id);
            if (this.dbcontext.Entry(entity).State == EntityState.Detached)
                this.dbcontext.Set<T>().Attach(entity);

            this.dbcontext.Set<T>().Remove(entity);

            await dbcontext.SaveChangesAsync();

        }

        public async Task<bool> UpdateAsync(int id, T entity)
        {
            T entityToUpdate = GetById(id).Result;
            if (entityToUpdate != null)
            {
                DbSet<T> dbSet = this.dbcontext.Set<T>();
                dbSet.Attach(entity);
                this.dbcontext.Entry(entity).State = EntityState.Modified;
                await dbcontext.SaveChangesAsync();
                return true;
            }
            else
            { 
                return false; 
            }

            //DbSet<T> dbSet = this.dbcontext.Set<T>();
            //dbSet.Attach(entity);
            //this.dbcontext.Entry(entity).State = EntityState.Modified;
            //await dbcontext.SaveChangesAsync();

        }

    }
}
