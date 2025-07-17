using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models;

public class PokemonAbility
{
    public int PokemonId { get; set; }
    public Pokemon Pokemon { get; set; } = null!;
    public int AbilityId { get; set; }
    public Ability Ability { get; set; } = null!;
}
