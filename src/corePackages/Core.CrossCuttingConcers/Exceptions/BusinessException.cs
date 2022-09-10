using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace Core.CrossCuttingConcers.Exceptions;

public class BusinessException : Exception
{
    public BusinessException(string message) : base(message) { }
}


public class BusinessProblemDetails : ProblemDetails
{
    public override string ToString() => JsonConvert.SerializeObject(this);
}
