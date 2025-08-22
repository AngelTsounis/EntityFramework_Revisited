using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Mappers;

namespace PokemonAPI.Endpoints.Pokemons;

public static class GetPokemonByType
{
    public const string Name = "GetPokemonByTypeEndpoint";

    public static IEndpointRouteBuilder MapToGetPokemonByType(this IEndpointRouteBuilder app)
    {
        app.MapGet("/pokemons/by-type/{type}", async (string type, AppDbContext context) =>
        {
            // Normalize the type to lower case for case-insensitive comparison, in order to prevent performance issues in the query.
            var normalizedType = type.ToLower();

            var pokemons = await context.Pokemons
                .Include(p => p.PrimaryType)
                .Include(p => p.SecondaryType)
                .Where(p =>
                    p.PrimaryType.Name.ToLower() == normalizedType ||
                    p.SecondaryType.Name.ToLower() == normalizedType)
                .ToListAsync();


            if (!pokemons.Any())
            {
                return Results.NotFound();
            }

            var response = pokemons.Select(p => p.MapToPokemonResponse()).ToList();

            return Results.Ok(response);
        }).WithName(Name);

        return app;
    }
}
