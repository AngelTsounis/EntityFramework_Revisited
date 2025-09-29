using Infrastructure.Models;

namespace Infrastructure.Data;

public static class PokemonAbilitySeedData
{
    public static List<PokemonAbility> GetPokemonAbilities() => new()
    {    
        // These dataSeed describe which abilities each Pokemon can learn and at what level they learn them.
        new PokemonAbility { PokemonId = 1, AbilityId = 1, RequiredLevel = 15 },
        new PokemonAbility { PokemonId = 2, AbilityId = 2 },
        new PokemonAbility { PokemonId = 3, AbilityId = 3 },
        new PokemonAbility { PokemonId = 4, AbilityId = 4 },
        new PokemonAbility { PokemonId = 5, AbilityId = 5 },
        new PokemonAbility { PokemonId = 6, AbilityId = 6 },
        new PokemonAbility { PokemonId = 7, AbilityId = 7 },
        new PokemonAbility { PokemonId = 8, AbilityId = 8 },
        new PokemonAbility { PokemonId = 9, AbilityId = 9 },
        new PokemonAbility { PokemonId = 10, AbilityId = 10 },
        new PokemonAbility { PokemonId = 1, AbilityId = 11, RequiredLevel = 1 },   // Scratch
        new PokemonAbility { PokemonId = 1, AbilityId = 12, RequiredLevel = 7 },   // Ember
        new PokemonAbility { PokemonId = 1, AbilityId = 13, RequiredLevel = 15 },  // Flamethrower
    };
}

