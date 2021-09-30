using Rest.BL.Models;
using Rest.BL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rest.BL.Services.Implements
{
    public class CIIUService : GenericService<CIIU>, ICIIUService
    {
        public CIIUService(ICIIURepository repository) : base(repository) { }      
    }
}
