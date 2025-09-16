using Application.Interfaces;
using Application.Services.Interfaces;

namespace PokemonAPI.Endpoints.Pokemons;

public static class GetPokemonEndpoint
{
    public const string Name = "GetPokemonEndpoint";

    public static IEndpointRouteBuilder MapGetPokemons(this IEndpointRouteBuilder app)
    {
        app.MapGet("/pokemons", async (IPokemonService pokemonService) =>
        {
            var response = await pokemonService.GetAllPokemonsServiceAsync();

            if (response == null || !response.Any())
            {
                return Results.NotFound();
            }

            return Results.Ok(response);

        }).WithName(Name);

        return app;
    }
}
