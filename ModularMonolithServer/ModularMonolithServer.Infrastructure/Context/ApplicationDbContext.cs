using GenericRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ModularMonolithServer.Domain.Entities;

namespace ModularMonolithServer.Infrastructure.Context;
internal sealed class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, Guid>, IUnitOfWork
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<AppUser>(entity =>
        {
            entity.Property(e => e.FirstName).HasColumnType("varchar(50)");
            entity.Property(e => e.LastName).HasColumnType("varchar(50)");
        });

        builder.Entity<AppUserRole>(entity =>
        {
            entity.HasKey(k => new { k.UserId, k.RoleId });
        });

        builder.Ignore<IdentityUserLogin<Guid>>();
        builder.Ignore<IdentityRoleClaim<Guid>>();
        builder.Ignore<IdentityUserToken<Guid>>();
        builder.Ignore<IdentityUserRole<Guid>>();
        builder.Ignore<IdentityUserClaim<Guid>>();
    }
}
