using Rest.BL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rest.API.Services
{
    public interface IUserService
    {
        ResponseAuth authenticated(Authenticate authenticate);
    }
}
