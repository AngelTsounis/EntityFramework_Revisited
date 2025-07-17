using Infrastructure.Models;

namespace Infrastructure.Data;

public static class PokemonSeedData
{
    public static List<Pokemon> GetPokemons() => new()
    {
        new Pokemon { Id = 1, Name = "Pikachu", PokedexNumber = 25, PrimaryTypeId = 1},
        new Pokemon { Id = 2, Name = "Charmander", PokedexNumber = 4, PrimaryTypeId = 2 },
        new Pokemon { Id = 3, Name = "Squirtle", PokedexNumber = 7, PrimaryTypeId = 3 },
        new Pokemon { Id = 4, Name = "Bulbasaur", PokedexNumber = 1, PrimaryTypeId = 4, SecondaryTypeId = 7 },
        new Pokemon { Id = 5, Name = "Pidgey", PokedexNumber = 16, PrimaryTypeId = 6, SecondaryTypeId = 5 },
        new Pokemon { Id = 6, Name = "Jigglypuff", PokedexNumber = 39, PrimaryTypeId = 6 },
        new Pokemon { Id = 7, Name = "Geodude", PokedexNumber = 74, PrimaryTypeId = 9, SecondaryTypeId = 10 },
        new Pokemon { Id = 8, Name = "Psyduck", PokedexNumber = 54, PrimaryTypeId = 3 },
        new Pokemon { Id = 9, Name = "Abra", PokedexNumber = 63, PrimaryTypeId = 8 },
        new Pokemon { Id = 10, Name = "Growlithe", PokedexNumber = 58, PrimaryTypeId = 2 },
        new Pokemon { Id = 11, Name = "Ivysaur", PokedexNumber = 2, PrimaryTypeId = 4, SecondaryTypeId = 7 },
        new Pokemon { Id = 12, Name = "Charmeleon", PokedexNumber = 5, PrimaryTypeId = 2 },
        new Pokemon { Id = 13, Name = "Wartortle", PokedexNumber = 8, PrimaryTypeId = 3 }
    };
}

