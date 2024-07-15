using GenericRepository;
using ModularMonolithServer.Domain.Entities;
using ModularMonolithServer.Domain.Repositories;
using ModularMonolithServer.Infrastructure.Context;

namespace ModularMonolithServer.Infrastructure.Repositories;

internal sealed class ProductRepository : Repository<Product, ProductDbContext>, IProductRepository
{
    public ProductRepository(ProductDbContext context) : base(context)
    {
    }
}
