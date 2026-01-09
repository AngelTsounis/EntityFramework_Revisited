using Infrastructure.Models;

namespace Infrastructure.Data;

public static class WeaknessesSeedData
{
    public static List<WeaknessesEntity> GetWeaknesses()
    {
        var weaknesses = new List<WeaknessesEntity>();

        void AddWeaknesses(int pokemonId, params int[] elementTypeIds)
        {
            foreach (var typeId in elementTypeIds)
            {
                weaknesses.Add(new WeaknessesEntity
                {
                    PokemonId = pokemonId,
                    ElementTypeId = typeId
                });
            }
        }

        // Pikachu (Electric) - Weak to Ground
        AddWeaknesses(1, 10);

        // Charmander (Fire) - Weak to Water, Ground, Rock
        AddWeaknesses(2, 3, 10, 9);

        // Squirtle (Water) - Weak to Electric, Grass
        AddWeaknesses(3, 1, 4);

        // Bulbasaur (Grass/Poison) - Weak to Fire, Flying, Psychic
        AddWeaknesses(4, 2, 5, 8);

        // Pidgey (Normal/Flying) - Weak to Electric, Rock
        AddWeaknesses(5, 1, 9);

        // Geodude (Rock/Ground) - Weak to Water, Grass
        AddWeaknesses(7, 3, 4);

        // Psyduck (Water) - Weak to Electric, Grass
        AddWeaknesses(8, 1, 4);

        // Growlithe (Fire) - Weak to Water, Ground, Rock
        AddWeaknesses(10, 3, 10, 9);

        // Ivysaur (Grass/Poison) - Weak to Fire, Flying, Psychic
        AddWeaknesses(11, 2, 5, 8);

        // Charmeleon (Fire) - Weak to Water, Ground, Rock
        AddWeaknesses(12, 3, 10, 9);

        // Wartortle (Water) - Weak to Electric, Grass
        AddWeaknesses(13, 1, 4);

        return weaknesses;
    }
}