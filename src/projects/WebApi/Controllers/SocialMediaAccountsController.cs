using Application.Features.SocialMediaAccounts.Commands.CreateSocialMediaAccount;
using Application.Features.SocialMediaAccounts.Commands.DeleteSocialMediaAccount;
using Application.Features.SocialMediaAccounts.Commands.UpdateSocialMediaAccount;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SocialMediaAccountsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateSocialMediaAccountCommand socialMediaAccount)
        => Ok(await Mediator.Send(socialMediaAccount));

    [HttpPut]
    public async Task<IActionResult> UpdateAsync([FromBody] UpdateSocialMediaAccountCommand programmingLanguage)
        => Ok(await Mediator.Send(programmingLanguage));

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
        => Ok(await Mediator.Send(new DeleteSocialMediaAccountCommand { Id = id }));
}
