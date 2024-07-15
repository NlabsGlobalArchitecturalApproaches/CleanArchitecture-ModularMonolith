using ModularMonolithServer.Domain.Abstractions;
using ModularMonolithServer.Domain.Shared;

namespace ModularMonolithServer.Domain.Entities;
public sealed class Category : Entity
{
    public Name Name { get; set; } = default!;
}
