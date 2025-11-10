namespace Infrastructure.Models;

public class PokemonAbilityEntity
{
    public int PokemonId { get; set; }
    public PokemonEntity Pokemon { get; set; } = null!;

    public int AbilityId { get; set; }
    public AbilityEntity Ability { get; set; } = null!;

    public int RequiredLevel { get; set; }
}
