using Core.Domain.Entities;
namespace Core.Security.Jwt;

public interface ITokenHelper
{
    AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    //RefreshToken CreateRefreshToken(User user, string ipAddress);    
}
