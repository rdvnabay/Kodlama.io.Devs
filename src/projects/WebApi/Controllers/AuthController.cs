using Application.Features.Users.Commands.CreateRegisterUser;
using Application.Features.Users.Queries.GetLoginUser;
using Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : BaseController
{
    [HttpPost("register")]
    public async Task<IActionResult> RegisterAsync([FromBody] CreateRegisterUserCommand registerUser)
    {
        registerUser.IpAddress = GetIpAddress();
        return Ok(await Mediator.Send(registerUser));
    }


    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync([FromBody] GetLoginUserQuery loginUser)
       => Ok(await Mediator.Send(loginUser));

    private void SetRefreshTokenToCookie(RefreshToken refreshToken)
    {
        CookieOptions cookieOptions = new() { HttpOnly = true, Expires = DateTime.Now.AddDays(7) };
        Response.Cookies.Append("refreshToken", refreshToken.Token, cookieOptions);
    }
}
