using GenericRepository;
using Microsoft.EntityFrameworkCore;
using ModularMonolithServer.Domain.Entities;
using ModularMonolithServer.Domain.Shared;

namespace ModularMonolithServer.Infrastructure.Context;
internal sealed class CategoryDbContext : DbContext, IUnitOfWork
{
    public CategoryDbContext(DbContextOptions<CategoryDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Category>(entity =>
        {
            entity.HasKey(p => p.Id);

            entity
            .OwnsOne(p => p.Name, name =>
            {
                name.Property(n => n.Value)
                .HasColumnName("Name")
                .HasColumnType("varchar(50)");
            });
        });

        builder.Ignore<Name>();
    }
}