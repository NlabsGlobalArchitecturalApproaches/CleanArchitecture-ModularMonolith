using ModularMonolithServer.Application.Features.Auth.Login;
using ModularMonolithServer.Domain.Entities;

namespace ModularMonolithServer.Application.Services;
public interface IJwtProvider
{
    Task<LoginCommandResponse> CreateToken(AppUser user);
}
