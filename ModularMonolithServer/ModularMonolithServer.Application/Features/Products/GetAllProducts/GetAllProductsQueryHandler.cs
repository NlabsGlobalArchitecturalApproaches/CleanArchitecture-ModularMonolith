using MediatR;
using Microsoft.EntityFrameworkCore;
using ModularMonolithServer.Domain.Entities;
using ModularMonolithServer.Domain.Repositories;
using TS.Result;

namespace ModularMonolithServer.Application.Features.Products.GetAllProducts;

internal sealed class GetAllProductsQueryHandler
    (
        IProductRepository productRepository
    ) : IRequestHandler<GetAllProductsQuery, Result<List<Product>>>
{
    public async Task<Result<List<Product>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await productRepository.GetAll().ToListAsync(cancellationToken);

        return products;
    }
}