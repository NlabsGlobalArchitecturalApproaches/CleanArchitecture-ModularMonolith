using GenericRepository;
using ModularMonolithServer.Domain.Entities;
using ModularMonolithServer.Domain.Repositories;
using ModularMonolithServer.Infrastructure.Context;

namespace ModularMonolithServer.Infrastructure.Repositories;

internal sealed class CategoryRepository : Repository<Category, CategoryDbContext>, ICategoryRepository
{
    public CategoryRepository(CategoryDbContext context) : base(context)
    {
    }
}
