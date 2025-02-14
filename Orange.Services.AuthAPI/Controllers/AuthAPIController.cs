using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Orange.Services.AuthAPI.Service.IService;
using Orange.Services.AuthAPI.Models.Dto;
using Microsoft.IdentityModel.Tokens;

namespace Orange.Services.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        private readonly IAuthService _authService;

        protected ResponseDto _response;

        public AuthAPIController(IAuthService authService)
        {
            _authService = authService;
            _response = new();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterationRequestDto model)
        {
            

            var errorMessage = await _authService.Register(model);
            if (!string.IsNullOrEmpty(errorMessage)) 
            {
                _response.IsSuccess = false;
                _response.Message = errorMessage;
                return BadRequest(_response);
            }
            return Ok(_response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }
    }
}
