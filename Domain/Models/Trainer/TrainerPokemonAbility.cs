namespace Domain.Models.Trainer;

using Domain.Models.Pokemon;

public class TrainerPokemonAbility
{
    public int Id { get; set; } // persistence id (in infra model)
    public int AbilityId { get; init; }
    public Ability Ability { get; init; } = null!;
    public DateTime UnlockedAt { get; init; } = DateTime.UtcNow;

    public TrainerPokemonAbility() { }

    public TrainerPokemonAbility(Ability ability)
    {
        Ability = ability ?? throw new ArgumentNullException(nameof(ability));
        AbilityId = ability.Id;
    }
}
