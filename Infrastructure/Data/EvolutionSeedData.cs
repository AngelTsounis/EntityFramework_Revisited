using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Models;

namespace Infrastructure.Data;

public static class EvolutionSeedData
{
    public static List<Evolution> GetEvolutions() => new()
{
    new Evolution { Id = 1, FromPokemonId = 4, ToPokemonId = 11,  }, 
    new Evolution { Id = 2, FromPokemonId = 2, ToPokemonId = 12,  }, 
    new Evolution { Id = 3, FromPokemonId = 3, ToPokemonId = 13,  } 
};
}
