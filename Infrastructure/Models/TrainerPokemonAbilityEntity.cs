namespace Infrastructure.Models;

public class TrainerPokemonAbilityEntity
{
    public int Id { get; set; }

    public int TrainerPokemonId { get; set; }
    public TrainerPokemonEntity TrainerPokemon { get; set; } = null!;

    public int AbilityId { get; set; }
    public AbilityEntity Ability { get; set; } = null!;

}
