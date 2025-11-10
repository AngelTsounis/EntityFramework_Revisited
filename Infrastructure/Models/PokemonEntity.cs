namespace Infrastructure.Models;

public class PokemonEntity
{ 
    public int Id { get; set; }
    public string? Name { get; set; }
    public int PokedexNumber { get; set; }
    public int PrimaryTypeId { get; set; }
    public int? SecondaryTypeId { get; set; }
    public ElementTypeEntity PrimaryType { get; set; } = null!;
    public ElementTypeEntity SecondaryType { get; set; }
    public ICollection<PokemonAbilityEntity> Abilities { get; set; } = new List<PokemonAbilityEntity>();

}
