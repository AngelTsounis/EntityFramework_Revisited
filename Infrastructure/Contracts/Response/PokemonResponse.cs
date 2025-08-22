using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contracts.Response;

public class PokemonResponse
{
    public string? Name { get; set; }
    public int PokedexNumber { get; set; }
    public string? PrimaryType { get; set; }
    public string? SecondaryType { get; set; }
}

