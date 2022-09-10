using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace Core.CrossCuttingConcers.Exceptions;

public class AuthorizationException : Exception
{
    public AuthorizationException(string message) : base(message) { }
}

public class AuthorizationProblemDetails : ProblemDetails
{
    public override string ToString() => JsonConvert.SerializeObject(this);
}