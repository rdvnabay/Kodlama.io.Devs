using Application.Services.Repositories;
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
}
