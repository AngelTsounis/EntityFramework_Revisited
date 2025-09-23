using Application.Interfaces;
using PokemonAPI.Endpoints.Pokemons;
using PokemonAPI.Endpoints.Abilities;

namespace PokemonAPI.Endpoints;

public static class EndpointsExtensions
{
    public static IEndpointRouteBuilder MapApiEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGetPokemons();
        app.MapGetPokemonByName();
        app.MapToGetPokemonByType();
        app.MapToGetAbilityById();
        return app;
    }
}
