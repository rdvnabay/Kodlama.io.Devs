using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Core.CrossCuttingConcers.Exceptions;
public class BusinessProblemDetails:ProblemDetails
{
    public override string ToString() => JsonSerializer.Serialize(this);
}
