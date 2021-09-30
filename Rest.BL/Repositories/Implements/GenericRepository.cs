using Microsoft.EntityFrameworkCore;
using Rest.BL.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rest.BL.Repositories.Implements
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private RestContext restContext;

        public GenericRepository(RestContext restContext)
        {
            this.restContext = restContext;
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);

            if (entity == null)
                throw new Exception("The entity is null");

            restContext.Set<TEntity>().Remove(entity);
            await restContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await restContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await restContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            restContext.Set<TEntity>().Add(entity);
            await restContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            restContext.Entry(entity).State = EntityState.Modified;
            //RestContext.Set<TEntity>().AddOrUpdate(entity);
            await restContext.SaveChangesAsync();
            return entity;
        }
    }
}
