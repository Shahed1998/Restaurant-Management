using Application.Services.Authentication;
using Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("Register")]
        public IActionResult Register(RegisterRequest request)
        {
            var result = _authenticationService.Register(Guid.NewGuid(), request.FirstName, request.LastName,
                request.Email, request.Password);

            return Ok(result);
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginRequest request)
        {
            var result = _authenticationService.Login(Guid.NewGuid(), string.Empty, string.Empty,
                request.Email, request.Password);

            return Ok(result);
        }
    }
}
