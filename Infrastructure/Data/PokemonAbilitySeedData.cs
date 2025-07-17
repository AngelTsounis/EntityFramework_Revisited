using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Models;

namespace Infrastructure.Data;

public static class PokemonAbilitySeedData
{
    public static List<PokemonAbility> GetPokemonAbilities() => new()
    {
        new PokemonAbility { PokemonId = 1, AbilityId = 1 },
        new PokemonAbility { PokemonId = 2, AbilityId = 2 },
        new PokemonAbility { PokemonId = 3, AbilityId = 3 },
        new PokemonAbility { PokemonId = 4, AbilityId = 4 },
        new PokemonAbility { PokemonId = 5, AbilityId = 5 },
        new PokemonAbility { PokemonId = 6, AbilityId = 6 },
        new PokemonAbility { PokemonId = 7, AbilityId = 7 },
        new PokemonAbility { PokemonId = 8, AbilityId = 8 },
        new PokemonAbility { PokemonId = 9, AbilityId = 9 },
        new PokemonAbility { PokemonId = 10, AbilityId = 10 }
    };
}

