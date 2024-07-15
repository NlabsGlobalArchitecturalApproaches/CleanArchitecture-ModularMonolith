using MediatR;
using ModularMonolithServer.Domain.Entities;
using TS.Result;

namespace ModularMonolithServer.Application.Features.Products.GetAllProducts;
public sealed record GetAllProductsQuery : IRequest<Result<List<Product>>>;
