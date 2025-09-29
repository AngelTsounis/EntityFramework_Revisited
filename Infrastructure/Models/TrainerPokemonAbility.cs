namespace Infrastructure.Models;

public class TrainerPokemonAbility
{
    public int Id { get; set; }

    public int TrainerPokemonId { get; set; }
    public TrainerPokemon TrainerPokemon { get; set; } = null!;

    public int AbilityId { get; set; }
    public Ability Ability { get; set; } = null!;

}
