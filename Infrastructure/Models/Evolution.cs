using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models;

public class Evolution
{
    public int Id { get; set; }
    public int FromPokemonId { get; set; }
    public int ToPokemonId { get; set; }
    public Pokemon FromPokemon { get; set; } = null!;
    public Pokemon ToPokemon { get; set; } = null!;
}
