using Infrastructure.Mappers;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;

namespace PokemonAPI.Endpoints.Pokemons;

public static class GetPokemonEndpoint
{
    public const string Name = "GetPokemonEndpoint";

    public static IEndpointRouteBuilder MapGetPokemons(this IEndpointRouteBuilder app)
    {
        app.MapGet("/pokemons", async (IPokemonRepository repository) =>
        {
            var response = await repository.GetAllPokemonsAsync();
            return Results.Ok(response);
        }).WithName(Name);

        return app;
    }
}
