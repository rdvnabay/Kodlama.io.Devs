using Application.Features.Users.Commands.CreateRegisterUser;
using Application.Features.Users.Queries.GetLoginUser;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : BaseController
{
    [HttpPost("register")]
    public async Task<IActionResult> RegisterAsync([FromBody] CreateRegisterUserCommand registerUser)
        => Ok(await Mediator.Send(registerUser));

    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync([FromBody] GetLoginUserQuery loginUser)
       => Ok(await Mediator.Send(loginUser));
}
