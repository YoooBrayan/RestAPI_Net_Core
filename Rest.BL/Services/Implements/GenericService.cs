using Rest.BL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Rest.BL.Services.Implements
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        private IGenericRepository<TEntity> genericRepository;

        public GenericService(IGenericRepository<TEntity> genericRepository)
        {
            this.genericRepository = genericRepository;
        }

        public async Task Delete(int id)
        {
            await genericRepository.Delete(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await genericRepository.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await genericRepository.GetById(id);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            return await genericRepository.Insert(entity);
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            return await genericRepository.Update(entity);
        }

        //Task IGenericService<TEntity>.Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<IEnumerable<TEntity>> IGenericService<TEntity>.GetAll()
        //{
        //    return await genericRepository.GetAll();
        //}

        //Task<TEntity> IGenericService<TEntity>.GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<TEntity> IGenericService<TEntity>.Insert(TEntity entity)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<TEntity> IGenericService<TEntity>.Update(TEntity entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
