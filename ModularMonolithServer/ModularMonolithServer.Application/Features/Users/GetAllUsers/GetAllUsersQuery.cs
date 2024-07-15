using MediatR;
using ModularMonolithServer.Domain.Entities;
using TS.Result;

namespace ModularMonolithServer.Application.Features.Users.GetAllUsers;
public sealed record GetAllUsersQuery : IRequest<Result<List<AppUser>>>;
