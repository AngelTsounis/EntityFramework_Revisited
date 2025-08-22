 
using Infrastructure.Contracts.Request;
using Infrastructure.Contracts.Response;
using Infrastructure.Models;

namespace Infrastructure.Mappers;

public static class PokemonResponseMapper
{
    public static PokemonResponse MapToPokemonResponse(this Pokemon pokemon)
    {
        var pokemonResponse = new PokemonResponse
        {
            Name = pokemon.Name,
            PokedexNumber = pokemon.PokedexNumber,
            PrimaryType = pokemon.PrimaryType?.Name,
            SecondaryType = pokemon.SecondaryType?.Name,
        };

        return pokemonResponse;
    }
}

