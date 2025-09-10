using ProvaCsharp.UseCases.Users;
using Microsoft.AspNetCore.Mvc;
using ProvaCsharp.UseCases.Users.CreateAccount;

namespace ProvaCsharp.Endpoints.Produto;

public static class ProdutoCreateEndpoint
{
    public static void MapProdutoCreate(this WebApplication app)
    {
        app.MapPost("/produtos", async (
            [FromServices] CreateAccountUseCase useCase,
            [FromBody] CreateAccountRequest request) =>
        {
        });
    }
}