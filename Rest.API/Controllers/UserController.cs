using Microsoft.AspNetCore.Mvc;
using Rest.API.Services;
using Rest.API.Services.Implements;
using Rest.BL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ubiety.Dns.Core;

namespace Rest.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private IUserService _IUserService;

        public UserController(IUserService userService)
        {
            this._IUserService = userService;
        }

        [HttpPost]
        public ResponseAuth auth(Authenticate authenticate)
        {
            return _IUserService.authenticated(authenticate);
        }
    }
}
