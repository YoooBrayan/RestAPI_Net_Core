using Rest.BL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rest.BL.Repositories
{
    public interface ICIIURepository : IGenericRepository<CIIU>
    {
        Task<IEnumerable<CIIU>> GetAll();
        Task<CIIU> GetById(int id);
        Task<CIIU> Insert(CIIU entity);
        Task<CIIU> Update(CIIU entity);
        Task Delete(int id);
    }
}
