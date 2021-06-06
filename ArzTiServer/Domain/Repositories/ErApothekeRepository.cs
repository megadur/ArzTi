using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ArzTiServer.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace ArzTiServer.Domain.Repositories
{
    public class ErApothekeRepository<T> : IAsyncRepository<T> where T : ErApotheke
    {

        #region Fields

        protected ArzDbContext Context;

        #endregion

        public ErApothekeRepository(ArzDbContext context)
        {
            Context = context;
        }

        #region Public Methods

        public Task<T> GetById(int id)
        {
            return Context.Set<T>().FindAsync(id).AsTask();
        }

        public Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate)
            => Context.Set<T>().FirstOrDefaultAsync(predicate);

        public async Task Add(T entity)
        {
            // await Context.AddAsync(entity);
            await Context.Set<T>().AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public Task Update(T entity)
        {
            // In case AsNoTracking is used
            Context.Entry(entity).State = EntityState.Modified;
            return Context.SaveChangesAsync();
        }

        public Task Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
            return Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                return await Context.Set<T>().ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);

            }
            return null;
        }

        public async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return await Context.Set<T>().Where(predicate).ToListAsync();
        }

        public Task<int> CountAll() => Context.Set<T>().CountAsync();

        public Task<int> CountWhere(Expression<Func<T, bool>> predicate)
            => Context.Set<T>().CountAsync(predicate);

        #endregion

    }
}