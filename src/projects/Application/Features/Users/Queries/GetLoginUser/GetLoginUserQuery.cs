using Application.Services.Repositories;
using Core.Security.Jwt;
using Microsoft.EntityFrameworkCore;
namespace Application.Features.Users.Queries.GetLoginUser;

public class GetLoginUserQuery : IRequest<AccessToken>
{
    public GetLoginUserQueryRequestDto User { get; set; }



    public class GetLoginUserQueryHandler : IRequestHandler<GetLoginUserQuery, AccessToken>
    {
        private readonly IUserRepository _userRepository;
        private readonly IOperationClaimRepository _operationClaimRepository;
        private readonly UserBusinessRules _rules;
        private readonly ITokenHelper _tokenHelper;

        public GetLoginUserQueryHandler(IUserRepository userRepository, UserBusinessRules rules, ITokenHelper tokenHelper, IOperationClaimRepository operationClaimRepository)
        {
            _userRepository = userRepository;
            _rules = rules;
            _tokenHelper = tokenHelper;
            _operationClaimRepository = operationClaimRepository;
        }

        public async Task<AccessToken> Handle(GetLoginUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetAsync(u => u.Email == request.User.Email && u.Status);

            _rules.NullCheck(user);
            _rules.VerifyPassword(user, request.User.Password);

            //var claims = await _userRepository.GetAsync(
            //    query: u => u.Id == user.Id,
            //    include: u => u
            //    .Include(u => u.UserOperationClaims).ThenInclude(c => c.OperationClaim));

            var claims = await _operationClaimRepository.GetListAsync(
                query: u => u.Id == user.Id,
                include: u => u
                .Include(u => u.UserOperationClaims).ThenInclude(uoc => uoc.User));

            return _tokenHelper.CreateToken(user, claims.Items.ToList());
        }
    }
}
