using eCommerce.Core.DTO;
using eCommerce.Core.ServiceContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controller
{
    [Route("api/[controller]")] //api/auth
    [ApiController]
    public class AuthController : ControllerBase
    {   //creating 2 end points Register and LoginRequest
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        //Endpoint for user registration use case
        [HttpPost("register")] //POST api/auth/register
        public async Task<IActionResult> Register(RegisterRequest registerRequest)
        {
            //check for invalid RegisterRequest
            if(registerRequest == null)
            {
                return BadRequest("Invalid registration data");
            }

            //call the users service to handle registration
            AuthenticationResponse? authenticationResponse =  await _userService.Register(registerRequest);

            if(authenticationResponse == null || authenticationResponse.Success == false)
            {
                return BadRequest(authenticationResponse);
            }
            return Ok(authenticationResponse); 
        }

        //Endpoint for user login use case
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            //check for invalid loginRequest
            if (loginRequest == null)
            {
                return BadRequest("Invalid login data");
            }

            AuthenticationResponse? authenticationResponse = await _userService.Login(loginRequest);
            if (authenticationResponse == null || authenticationResponse.Success == false)
            {
                return Unauthorized(authenticationResponse);
            }
            return Ok(authenticationResponse);
        }
    }
}
