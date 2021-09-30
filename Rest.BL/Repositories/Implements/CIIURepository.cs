using Microsoft.EntityFrameworkCore;
using Rest.BL.Data;
using Rest.BL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rest.BL.Repositories.Implements
{
    public class CIIURepository : GenericRepository<CIIU>,  ICIIURepository
    {
        public CIIURepository(RestContext context) : base(context) { }
        //private RestContext restContext;

        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        //public CIIURepository(RestContext restContext)
        //{
        //    this.restContext = restContext;
        //}

        //public async Task Delete(int id)
        //{
        //    var entity = await GetById(id);

        //    if (entity == null)
        //        throw new Exception("The entity is null");

        //    restContext.Set<CIIU>().Remove(entity);
        //    await restContext.SaveChangesAsync();
        //}

        //public async Task<IEnumerable<CIIU>> GetAll()
        //{
        //    return await restContext.Set<CIIU>().ToListAsync();
        //}

        //public async Task<CIIU> GetById(int id)
        //{
        //    return await restContext.Set<CIIU>().FindAsync(id);
        //}

        //public async Task<CIIU> Insert(CIIU entity)
        //{
        //    restContext.Set<CIIU>().Add(entity);
        //    await restContext.SaveChangesAsync();
        //    return entity;
        //}

        //public async Task<CIIU> Update(CIIU entity)
        //{
        //    restContext.Entry(entity).State = EntityState.Modified;
        //    //RestContext.Set<CIIU>().AddOrUpdate(entity);
        //    await restContext.SaveChangesAsync();
        //    return entity;
        //}
    }
}
