using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEB_API_In_Dot_Net_Mac.Dtos.User;

namespace WEB_API_In_Dot_Net_Mac.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;
        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Register(
                new User { Username = request.UserName}, request.Password
            );

            if(response.Success){
                return Ok(response);
            } 
            else
            {
                return BadRequest(response);
            }
        }

        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<int>>> Login(UserLoginDto request)
        {
            var response = await _authRepo.Login(request.UserName, request.Password);

            if(response.Success){
                return Ok(response);
            } 
            else
            {
                return BadRequest(response);
            }
        }
    }
}