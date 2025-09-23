using Application.Services.Interfaces;

namespace PokemonAPI.Endpoints.Pokemons;

public static class GetPokemonByTypeEndpoint
{
    public const string Name = "GetPokemonByTypeEndpoint";

    public static IEndpointRouteBuilder MapToGetPokemonByType(this IEndpointRouteBuilder app)
    {
        app.MapGet("/pokemons/type/{type}", async (IPokemonService pokemonService, string pokemonType) =>
        {
            
            var response = await pokemonService.GetPokemonByTypeServiceAsync(pokemonType);

            if (!response.Any())
            {
                return Results.NotFound();
            }
            
            return Results.Ok(response);

        }).WithName(Name);

        return app;
    }
}
