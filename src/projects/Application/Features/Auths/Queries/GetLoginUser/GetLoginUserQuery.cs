using Application.Services.Repositories;
using Core.Security.Jwt;
using Microsoft.EntityFrameworkCore;
namespace Application.Features.Users.Queries.GetLoginUser;

public class GetLoginUserQuery : IRequest<AccessToken>
{
    public GetLoginUserQueryRequestDto User { get; set; }
}

public class GetLoginUserQueryHandler : IRequestHandler<GetLoginUserQuery, AccessToken>
{
    private readonly IUserRepository _userRepository;
    private readonly IOperationClaimRepository _operationClaimRepository;
    private readonly AuthBusinessRules _businessRules;
    private readonly ITokenHelper _tokenHelper;

    public GetLoginUserQueryHandler(IUserRepository userRepository, AuthBusinessRules businessRules, ITokenHelper tokenHelper, IOperationClaimRepository operationClaimRepository)
    {
        _userRepository = userRepository;
        _businessRules = businessRules;
        _tokenHelper = tokenHelper;
        _operationClaimRepository = operationClaimRepository;
    }

    public async Task<AccessToken> Handle(GetLoginUserQuery request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetAsync(u => u.Email == request.User.Email && u.Status);

        _businessRules.NullCheck(user);
        _businessRules.VerifyPassword(user, request.User.Password);

        var claims = await _operationClaimRepository.GetListAsync(
            query: u => u.Id == user.Id,
            include: u => u
            .Include(u => u.UserOperationClaims).ThenInclude(uoc => uoc.User));

        return _tokenHelper.CreateToken(user, claims.Items.ToList());
    }
}
