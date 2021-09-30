using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Rest.API.Commons;
using Rest.BL.DTOs;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Rest.API.Services.Implements
{
    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public ResponseAuth authenticated(Authenticate authenticate)
        {
            ResponseAuth responseAuth = new ResponseAuth();

            if (authenticate.Email.Equals("brayan") && authenticate.Password.Equals("123"))
            {
                responseAuth.Rta = true;
                responseAuth.Jwt = getToken();

            }

            return responseAuth;
        }

        private string getToken()
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var llave = Encoding.ASCII.GetBytes(_appSettings.Secreto);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                        new Claim[]
                        {
                            new Claim(ClaimTypes.NameIdentifier, "1000"),
                            new Claim(ClaimTypes.Email, "brayan657767@gmail.com")
                        }
                    ),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(llave), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
