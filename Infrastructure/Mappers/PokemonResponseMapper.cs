using Application.Contracts.Response;
using Infrastructure.Models;

namespace Infrastructure.Mappers;

public static class PokemonResponseMapper
{
    public static PokemonResponse MapToPokemonResponse(this PokemonEntity pokemon)
    {
        var pokemonResponse = new PokemonResponse
        {
            Name = pokemon.Name,
            PokedexNumber = pokemon.PokedexNumber,
            PrimaryType = pokemon.PrimaryType?.Name,
            SecondaryType = pokemon.SecondaryType?.Name,
            Abilities = pokemon.Abilities.Select(pa => new AbilityResponse
            {
                Name = pa.Ability.Name,
                Description = pa.Ability.Description
            }).ToList(),
            Weaknesses = pokemon.Weaknesses.Select(w => w.ElementType.Name).ToList()
        };

        return pokemonResponse;
    }
}

