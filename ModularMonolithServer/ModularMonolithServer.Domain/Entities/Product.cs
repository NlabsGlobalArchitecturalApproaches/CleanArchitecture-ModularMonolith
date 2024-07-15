using ModularMonolithServer.Domain.Abstractions;
using ModularMonolithServer.Domain.Shared;

namespace ModularMonolithServer.Domain.Entities;
public sealed class Product : Entity
{
    public Name Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public Guid CategoryId { get; set; }
}
