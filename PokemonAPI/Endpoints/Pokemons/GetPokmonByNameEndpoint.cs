using Infrastructure.Mappers;
using Infrastructure;
using Microsoft.EntityFrameworkCore;


namespace PokemonAPI.Endpoints.Pokemons;

public static class GetPokmonByNameEndpoint
{
    public const string Name = "GetPokmonByNameEndpoint";

    public static IEndpointRouteBuilder MapGetPokemonByName(this IEndpointRouteBuilder app)
    {
        app.MapGet("/pokemons/{name}", async (string name, AppDbContext context) =>
        {
            var pokemon = await context.Pokemons
            .Include(p => p.PrimaryType)
            .Include(p => p.SecondaryType)
            .FirstOrDefaultAsync(p => p.Name!.ToLower() == name.ToLower());

            if (pokemon == null)
            {
                return Results.NotFound();
            }
            var response = pokemon.MapToPokemonResponse();
            return Results.Ok(response);
        }).WithName(Name);
        return app;
    }
}
