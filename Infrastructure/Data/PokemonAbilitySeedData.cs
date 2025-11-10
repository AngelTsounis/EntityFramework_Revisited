using Infrastructure.Models;

namespace Infrastructure.Data;

public static class PokemonAbilitySeedData
{
    public static List<PokemonAbilityEntity> GetPokemonAbilities() => new()
    {    
        // These dataSeed describe which abilities each Pokemon can learn and at what level they learn them.
        new PokemonAbilityEntity { PokemonId = 1, AbilityId = 1, RequiredLevel = 15 },
        new PokemonAbilityEntity { PokemonId = 2, AbilityId = 2 },
        new PokemonAbilityEntity { PokemonId = 3, AbilityId = 3 },
        new PokemonAbilityEntity { PokemonId = 4, AbilityId = 4 },
        new PokemonAbilityEntity { PokemonId = 5, AbilityId = 5 },
        new PokemonAbilityEntity { PokemonId = 6, AbilityId = 6 },
        new PokemonAbilityEntity { PokemonId = 7, AbilityId = 7 },
        new PokemonAbilityEntity { PokemonId = 8, AbilityId = 8 },
        new PokemonAbilityEntity { PokemonId = 9, AbilityId = 9 },
        new PokemonAbilityEntity { PokemonId = 10, AbilityId = 10 },
        new PokemonAbilityEntity { PokemonId = 1, AbilityId = 11, RequiredLevel = 1 },   // Scratch
        new PokemonAbilityEntity { PokemonId = 1, AbilityId = 12, RequiredLevel = 7 },   // Ember
        new PokemonAbilityEntity { PokemonId = 1, AbilityId = 13, RequiredLevel = 15 },  // Flamethrower
    };
}

