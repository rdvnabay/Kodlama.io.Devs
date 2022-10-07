namespace Application.Features.Users.Commands.CreateRegisterUser;

public class CreateRegisterUserCommandRequestDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string RePassword { get; set; }
}
