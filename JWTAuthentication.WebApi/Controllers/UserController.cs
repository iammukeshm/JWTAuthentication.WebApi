using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTAuthentication.WebApi.Models;
using JWTAuthentication.WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthentication.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("register")]
        //[ApiExplorerSettings(IgnoreApi = true)]
        public async Task<ActionResult> RegisterAsync(RegisterModel model)
        {

            var result = await _userService.RegisterAsync(model);
            return Ok(result);
        }
        [HttpPost("token")]
        public async Task<IActionResult> GetTokenAsync(TokenRequestModel model)
        {
            var result = await _userService.GetTokenAsync(model);
            return Ok(result);
        }
    }
}