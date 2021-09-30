using Microsoft.EntityFrameworkCore;
using Rest.BL.Models;

namespace Rest.BL.Data
{
    public class RestContext : DbContext
    {

        public RestContext(DbContextOptions<RestContext> options) : base(options)
        {

        }
        public DbSet<CIIU> CIIUs { get; set; }


    }
}
