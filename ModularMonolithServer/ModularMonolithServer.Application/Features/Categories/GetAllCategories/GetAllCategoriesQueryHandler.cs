using MediatR;
using Microsoft.EntityFrameworkCore;
using ModularMonolithServer.Domain.Entities;
using ModularMonolithServer.Domain.Repositories;
using TS.Result;

namespace ModularMonolithServer.Application.Features.Categories.CreateCategory;

internal sealed class GetAllCategoriesQueryHandler
    (
        ICategoryRepository categoryRepository
    ) : IRequestHandler<GetAllCategoriesQuery, Result<List<Category>>>
{
    public async Task<Result<List<Category>>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
    {
        var categories = await categoryRepository.GetAll().ToListAsync(cancellationToken);

        return categories;
    }
}
