using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SocialMediaPlanner.Application.Auth.Commands.Register;
using SocialMediaPlanner.Application.Auth.Queries.Login;
using SocialMediaPlanner.Shared.Auth.Commands.Login;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SocialMediaPlanner.Server.Controllers
{
    [Route("api/auth")]
    [AllowAnonymous]
    public class AuthController : BaseController
    {
        private readonly IConfiguration configuration;

        public AuthController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(Shared.Auth.Commands.Register.UserDto userDto)
        {
            try
            {
                await Mediator.Send(new RegisterCommand() { UserDto = userDto });
                return Accepted();
            }
            catch (Exception ex)
            {
                return Problem($"Something Went Wrong in the {nameof(Register)}", statusCode: 500);
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<AuthResponse>> Login(LoginUserDto userDto)
        {
            try
            {
                var response = await Mediator.Send(new LoginQuery() { UserDto=userDto });

                return response;
            }
            catch (Exception ex)
            {
                return Problem($"Something Went Wrong in the {nameof(Login)}", statusCode: 500);
            }
        }

        
    }
}
