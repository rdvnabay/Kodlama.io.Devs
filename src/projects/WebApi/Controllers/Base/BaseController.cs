﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace WebApi.Controllers.Base;

public class BaseController : ControllerBase
{
    private IMediator _mediator;

    protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();

    protected string? GetIpAddress()
    {
        if (Request.Headers.ContainsKey("X-Forwarded-For")) return Request.Headers["X-Forwarded-For"];
        return HttpContext.Connection.RemoteIpAddress?.MapToIPv4().ToString();
    }
}
