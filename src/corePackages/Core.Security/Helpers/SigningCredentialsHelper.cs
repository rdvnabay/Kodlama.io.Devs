using Microsoft.IdentityModel.Tokens;
namespace Core.Security.Helpers;

public class SigningCredentialsHelper
{
    public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey) 
        => new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
}