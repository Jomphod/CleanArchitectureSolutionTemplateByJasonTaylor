using _9Devster.WebUI.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace _9Devster.WebUI.Controllers;
[ApiController]
[ApiExceptionFilter]
[Route("api/[controller]")]
public abstract class ApiControllerBase : ControllerBase
{
    private ISender? _mediator;

    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}
