
namespace Infrastructure.Models;

public class Pokemon
{ 
    public int Id { get; set; }
    public string? Name { get; set; }
    public int PokedexNumber { get; set; } 
    public Type? PrimaryType { get; set; }
    public Type? SecondaryType { get; set; }
    public ICollection<PokemonAbility> Abilities { get; set; } = new List<PokemonAbility>();
    public ICollection<Evolution> Evolutions { get; set; } = new List<Evolution>();

}
