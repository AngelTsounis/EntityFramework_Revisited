using Infrastructure.Mappers;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Application.Services.Interfaces;


namespace PokemonAPI.Endpoints.Pokemons;

public static class GetPokmonByNameEndpoint
{
    public const string Name = "GetPokmonByNameEndpoint";

    public static IEndpointRouteBuilder MapGetPokemonByName(this IEndpointRouteBuilder app)
    {
        app.MapGet("/pokemons/name/{name}", async (IPokemonService pokemonService, string name) =>
        {
            var response = await pokemonService.GetPokemonByNameServiceAsync(name);

            if (response == null)
            {
                return Results.NotFound();
            }

            return Results.Ok(response);

        }).WithName(Name);

        return app;
    }
}
