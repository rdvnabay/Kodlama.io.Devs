using Application.Features.Auths.Commands.CreateRegisterUser;
using Application.Services.AuthService;
using Application.Services.Repositories;
using Core.Security.Helpers;
using Core.Security.Jwt;
namespace Application.Features.Users.Commands.CreateRegisterUser;

public class CreateRegisterUserCommand : IRequest<CreateRegisterUserCommandResponseDto>
{
    public CreateRegisterUserCommandRequestDto User { get; set; }
    public string IpAddress { get; set; }
}

public class CreateRegisterUserCommandHandler : IRequestHandler<CreateRegisterUserCommand, CreateRegisterUserCommandResponseDto>
{
    private readonly IUserRepository _userRepository;
    private readonly AuthBusinessRules _businessRules;
    private readonly IAuthService _authService;

    public CreateRegisterUserCommandHandler(IUserRepository userRepository, AuthBusinessRules businessRules, IAuthService authService)
    {
        _userRepository = userRepository;
        _businessRules = businessRules;
        _authService = authService;
    }

    public async Task<CreateRegisterUserCommandResponseDto> Handle(CreateRegisterUserCommand request, CancellationToken cancellationToken)
    {
        await _businessRules.UserEmailCanNotBeDuplicated(request.User.Email);

        HashingHelper.CreatePasswordHash(request.User.Password, out var passwordSalt, out var passwordHash);

        User user = new()
        {
            FirstName = request.User.FirstName,
            LastName = request.User.LastName,
            Email = request.User.Email,
            PasswordHash = passwordHash,
            PasswordSalt = passwordSalt,
            Status = true
        };

        User createdUser = await _userRepository.AddAsync(user);

        AccessToken accessToken = await _authService.CreateAccessToken(createdUser);
        RefreshToken refreshToken = await _authService.CreateRefreshToken(createdUser, request.IpAddress);
        RefreshToken addedRefreshToken = await _authService.AddRefreshToken(refreshToken);

        return new CreateRegisterUserCommandResponseDto()
        {
            AccessToken = accessToken,
            RefreshToken = refreshToken,    
        };
    }
}
