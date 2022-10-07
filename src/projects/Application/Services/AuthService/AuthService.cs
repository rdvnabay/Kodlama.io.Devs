using Application.Services.Repositories;
using Core.Persistence.Paging;
using Core.Security.Jwt;
using Microsoft.EntityFrameworkCore;
namespace Application.Services.AuthService;

public class AuthService : IAuthService
{
    private readonly IUserOperationClaimRepository _userOperationClaimRepository;
    private readonly IRefreshTokenRepository _refreshTokenRepository;
    private readonly ITokenHelper _tokenHelper;

    public AuthService(IUserOperationClaimRepository userOperationClaimRepository, IRefreshTokenRepository refreshTokenRepository, ITokenHelper tokenHelper)
    {
        _userOperationClaimRepository = userOperationClaimRepository;
        _refreshTokenRepository = refreshTokenRepository;
        _tokenHelper = tokenHelper;
    }

    public async Task<RefreshToken> AddRefreshToken(RefreshToken refreshToken)
        => await _refreshTokenRepository.AddAsync(refreshToken);

    public async Task<RefreshToken> CreateRefreshToken(User user, string ipAddress)
    => _tokenHelper.CreateRefreshToken(user, ipAddress);

    public async Task<AccessToken> CreateAccessToken(User user)
    {
        IPaginate<UserOperationClaim> userOperationClaims = await _userOperationClaimRepository.GetListAsync(
            query: u => u.UserId == user.Id,
            include: u => u.Include(u => u.OperationClaim));

        List<OperationClaim> operationClaims = userOperationClaims.Items.Select(u =>
        new OperationClaim()
        {
            Id = u.OperationClaim.Id,
            Name = u.OperationClaim.Name
        }).ToList();

        return _tokenHelper.CreateToken(user, operationClaims);
    }
}
