using Infrastructure.Mappers;
using Infrastructure;
using Infrastructure.Contracts.Response;
using Microsoft.EntityFrameworkCore;

namespace PokemonAPI.Endpoints.Pokemons;

public static class GetPokemonEndpoint
{
    public const string Name = "GetPokemonEndpoint";

    public static IEndpointRouteBuilder MapGetPokemons(this IEndpointRouteBuilder app)
    {
        app.MapGet("/controller", async (AppDbContext context) =>
        {
            var pokemons = await context.Pokemons
                .Include(p => p.PrimaryType)
                .Include(p => p.SecondaryType)
                .ToListAsync();

            var response = pokemons.Select(p => p.MapToPokemonResponse()).ToList();
            return Results.Ok(response);
        }).WithName(Name);

        return app;
    }
}
