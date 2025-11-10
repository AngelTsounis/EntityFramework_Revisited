namespace Domain.Models.Pokemon;

public class PokemonAbility
{
    public int AbilityId { get; init; }
    public Ability Ability { get; init; } = null!;
    public int RequiredLevel { get; init; }

    public PokemonAbility() { }

    public PokemonAbility(Ability ability, int requiredLevel)
    {
        Ability = ability ?? throw new ArgumentNullException(nameof(ability));
        AbilityId = ability.Id;
        RequiredLevel = requiredLevel;
    }
}
