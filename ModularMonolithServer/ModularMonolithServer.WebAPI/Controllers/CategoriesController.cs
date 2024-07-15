using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModularMonolithServer.Application.Features.Categories.CreateCategory;
using ModularMonolithServer.WebAPI.Abstractions;

namespace ModularMonolithServer.WebAPI.Controllers;

public sealed class CategoriesController : ApiController
{
    public CategoriesController(IMediator mediator) : base(mediator)
    {
    }

    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllCategoriesQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
