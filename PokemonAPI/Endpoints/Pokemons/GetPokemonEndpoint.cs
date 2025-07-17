using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace PokemonAPI.Endpoints.Pokemons;

public static class GetPokemonEndpoint
{
    public const string Name = "GetPokemonEndpoint";

    public static IEndpointRouteBuilder MapGetPokemon(this IEndpointRouteBuilder app)
    {
        app.MapGet("/controller", async (AppDbContext context) =>
        {
            var retrieveAllPokemons = await context.Pokemons.ToListAsync();
            return Results.Ok(retrieveAllPokemons);
        }).WithName(Name);
        return app;
    }
}
