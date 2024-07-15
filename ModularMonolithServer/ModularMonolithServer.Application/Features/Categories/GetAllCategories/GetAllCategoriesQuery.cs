using MediatR;
using ModularMonolithServer.Domain.Entities;
using TS.Result;

namespace ModularMonolithServer.Application.Features.Categories.CreateCategory;
public sealed record GetAllCategoriesQuery : IRequest<Result<List<Category>>>;
