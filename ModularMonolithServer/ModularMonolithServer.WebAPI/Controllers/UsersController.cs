using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModularMonolithServer.Application.Features.Users.GetAllUsers;
using ModularMonolithServer.WebAPI.Abstractions;

namespace ModularMonolithServer.WebAPI.Controllers;

public sealed class UsersController : ApiController
{
    public UsersController(IMediator mediator) : base(mediator)
    {
    }

    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
