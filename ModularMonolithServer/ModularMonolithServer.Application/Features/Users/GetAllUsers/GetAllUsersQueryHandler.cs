using MediatR;
using Microsoft.EntityFrameworkCore;
using ModularMonolithServer.Domain.Entities;
using ModularMonolithServer.Domain.Repositories;
using TS.Result;

namespace ModularMonolithServer.Application.Features.Users.GetAllUsers;

internal sealed class GetAllUsersQueryHandler
    (
        IUserRepository userRepository
    ) : IRequestHandler<GetAllUsersQuery, Result<List<AppUser>>>
{
    public async Task<Result<List<AppUser>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        var users = await userRepository.GetAll().ToListAsync(cancellationToken);

        return users;
    }
}
