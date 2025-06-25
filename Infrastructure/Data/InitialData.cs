using Infrastructure.Models;

namespace Infrastructure.Data;

public static class InitialData 
{
    public static List<Pokemon> GetPokemons() => new()
    {
        new Pokemon { Id = 1, Name = "Pikachu", Type = "Electric" },
        new Pokemon { Id = 2, Name = "Charmander", Type = "Fire" },
        new Pokemon { Id = 3, Name = "Squirtle", Type = "Water" },
        new Pokemon { Id = 4, Name = "Bulbasaur", Type = "Grass" }
    };
}
