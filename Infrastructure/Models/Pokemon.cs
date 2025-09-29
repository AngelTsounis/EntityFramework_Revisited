namespace Infrastructure.Models;

public class Pokemon
{ 
    public int Id { get; set; }
    public string? Name { get; set; }
    public int PokedexNumber { get; set; }
    public int PrimaryTypeId { get; set; }
    public int? SecondaryTypeId { get; set; }
    public ElementType PrimaryType { get; set; } = null!;
    public ElementType SecondaryType { get; set; }
    public ICollection<PokemonAbility> Abilities { get; set; } = new List<PokemonAbility>();

}
