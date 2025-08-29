using Application.Interfaces;
using PokemonAPI.Endpoints.Pokemons;

namespace PokemonAPI.Endpoints;

public static class EndpointsExtensions
{
    public static IEndpointRouteBuilder MapApiEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGetPokemons();
        app.MapGetPokemonByName();
        app.MapToGetPokemonByType();
        return app;
    }
}
