using GenericRepository;
using ModularMonolithServer.Domain.Entities;
using ModularMonolithServer.Domain.Repositories;
using ModularMonolithServer.Infrastructure.Context;

namespace ModularMonolithServer.Infrastructure.Repositories;
internal sealed class UserRepository : Repository<AppUser, ApplicationDbContext>, IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context)
    {
    }
}
