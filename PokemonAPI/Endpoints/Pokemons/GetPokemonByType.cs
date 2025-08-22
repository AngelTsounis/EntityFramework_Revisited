using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace PokemonAPI.Endpoints.Pokemons;

public static class GetPokemonByType
{
    public const string Name = "GetPokemonByTypeEndpoint";

    public static IEndpointRouteBuilder MapToGetPokemonByType (this IEndpointRouteBuilder app)
    {
        app.MapGet("/pokemons/{type}", async (string type, AppDbContext context) =>
        {
            var pokemon = await context.Pokemons
            .Include(p => p.PrimaryType)
            .Include(p => p.SecondaryType)
            //.Where(p => string.Equals(p.PrimaryType?.Name, type, StringComparison.OrdinalIgnoreCase))
            .Where(p => p.PrimaryType?.Name.ToLower() == type.ToLower() || p.SecondaryType?.Name.ToLower() == type.ToLower())
            .ToListAsync();

            if (pokemon == null)
            {
                return Results.NotFound();
            }
            var response = pokemon.MapToPokemonResponse();
            return Results.Ok(response);
        }).WithName(Name);
    });

        return app;
    }

}
