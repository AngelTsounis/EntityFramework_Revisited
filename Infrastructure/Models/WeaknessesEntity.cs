namespace Infrastructure.Models;

public class WeaknessesEntity
{ 
    //Foreign Keys
    public int PokemonId { get; set; }
    public int ElementTypeId { get; set; }

    //Navigation Properties
    public PokemonEntity Pokemon { get; set; } = null!;
    public ElementTypeEntity ElementType { get; set; } = null!;
}