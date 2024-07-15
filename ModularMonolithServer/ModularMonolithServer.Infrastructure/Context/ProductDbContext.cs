using GenericRepository;
using Microsoft.EntityFrameworkCore;
using ModularMonolithServer.Domain.Entities;
using ModularMonolithServer.Domain.Shared;

namespace ModularMonolithServer.Infrastructure.Context;
internal sealed class ProductDbContext : DbContext, IUnitOfWork
{
    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Product>(entity =>
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
