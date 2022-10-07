using Application.Services.Repositories;
using Core.Application.BusinessRules;
using Core.Security.Helpers;
namespace Application.Features.Users;

public class AuthBusinessRules:GlobalBusinessRules
{
    private readonly IUserRepository _userRepository;

    public AuthBusinessRules(IUserRepository userRepository)
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
            throw new BusinessException("Password Error");
    }
}
