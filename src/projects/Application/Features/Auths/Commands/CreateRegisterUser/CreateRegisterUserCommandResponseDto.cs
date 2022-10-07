using Core.Security.Jwt;
namespace Application.Features.Auths.Commands.CreateRegisterUser;

public class CreateRegisterUserCommandResponseDto
{
    public AccessToken AccessToken { get; set; }
    public RefreshToken RefreshToken { get; set; }
}
