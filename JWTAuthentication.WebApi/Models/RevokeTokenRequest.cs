using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication.WebApi.Models
{
    public class RevokeTokenRequest
    {
        public string Token { get; set; }
    }
}
