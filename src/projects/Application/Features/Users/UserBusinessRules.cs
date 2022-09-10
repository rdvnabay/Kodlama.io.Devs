using Application.Services.Repositories;
using Core.Security.Helpers;
namespace Application.Features.Users;

public class UserBusinessRules
{
    private readonly IUserRepository _userRepository;

    public UserBusinessRules(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task UserEmailCanNotBeDuplicated(string email)
    {
        if (await _userRepository.AnyAsync(u => u.Email == email))
            throw new BusinessException("User email exists");
    }

    public void VerifyPassword(User user, string password)
    {
        if (!HashingHelper.VerifyPasswordHash(password, user.PasswordSalt, user.PasswordHash))
            throw new AuthorizationException("Password Error");
    }


    public void NullCheck(User user) => ArgumentNullException.ThrowIfNull(user);
}
