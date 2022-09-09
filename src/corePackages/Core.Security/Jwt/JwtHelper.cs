using Core.CrossCuttingConcers.Extensions;
using Core.Domain.Entities;
using Core.Security.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
namespace Core.Security.Jwt;

public class JwtHelper : ITokenHelper
{
    public IConfiguration Configuration { get; }
    private readonly TokenOptions _tokenOptions;
    private DateTime _accessTokenExpiration;

    public JwtHelper(IConfiguration configuration)
    {
        Configuration = configuration;
        _tokenOptions = Configuration.GetSection(nameof(TokenOptions)).Get<TokenOptions>();
    }

    public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
    {
        _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
        SecurityKey securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
        SigningCredentials signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
        JwtSecurityToken jwt = CreateJwtSecurityToken(user, operationClaims, signingCredentials, _tokenOptions);
        JwtSecurityTokenHandler jwtSecurityTokenHandler = new();
        string? token = jwtSecurityTokenHandler.WriteToken(jwt);

        return new AccessToken
        {
            Token = token,
            Expiration = _accessTokenExpiration
        };
    }

    //public RefreshToken CreateRefreshToken(User user, string ipAddress)
    //{
    //    return new()
    //    {
    //        UserId = user.Id,
    //        TokenContext = Convert.ToBase64String(RandomNumberGenerator.GetBytes((64)),
    //        Expires = DateTime.UtcNow.AddDays(7),
    //        Created = DateTime.UtcNow,
    //        CreatedByIp = ipAddress
    //   };
    //}

    public JwtSecurityToken CreateJwtSecurityToken(User user, List<OperationClaim> operationClaims, SigningCredentials signingCredentials, TokenOptions tokenOptions)
    {
        return new(
            issuer: tokenOptions.Issuer,
            audience: tokenOptions.Audience,
            expires: _accessTokenExpiration,
            notBefore: DateTime.Now,
            claims: SetClaims(user, operationClaims),
            signingCredentials: signingCredentials
            );
    }

    private List<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
    {
        List<Claim> claims = new();

        claims.AddNameIdentifier(user.Id.ToString());
        claims.AddEmail(user.Email);
        claims.AddName($"{user.FirstName} {user.LastName}");
        claims.AddRoles(operationClaims.Select(o => o.Name).ToArray());

        return claims;
    }
}
