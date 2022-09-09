using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
namespace Core.CrossCuttingConcers.Exceptions;

public class AuthorizationException : Exception
{
    public AuthorizationException(string message) : base(message) { }
}

public class AuthorizationProblemDetails : ProblemDetails
{
    public override string ToString() => JsonSerializer.Serialize(this);
}