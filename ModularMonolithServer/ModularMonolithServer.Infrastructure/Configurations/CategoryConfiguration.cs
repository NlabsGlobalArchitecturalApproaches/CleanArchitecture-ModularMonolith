using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModularMonolithServer.Domain.Entities;

namespace ModularMonolithServer.Infrastructure.Configurations;

internal sealed class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder
            .Property(p => p.Name)
            .HasConversion(p => p.Value, v => new(v))
            .HasColumnType("varchar(50)");
    }
}

