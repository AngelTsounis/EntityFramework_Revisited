namespace Domain.Models.Trainer;

using Domain.Models.Pokemon;

public class TrainerPokemon
{
    private const int BaseXpPerLevel = 100;
    public int Id { get; set; } 
    public int TrainerId { get; set; }
    public int PokemonId { get; init; }
    public Pokemon Pokemon { get; init; } = null!;

    public int Level { get; private set; } = 1;
    public int Experience { get; private set; } = 0;

    public IList<TrainerPokemonAbility> UnlockedAbilities { get; private set; } = new List<TrainerPokemonAbility>();

    public TrainerPokemon() { }

    public TrainerPokemon(Pokemon pokemon, int initialLevel = 1)
    {
        Pokemon = pokemon ?? throw new ArgumentNullException(nameof(pokemon));
        PokemonId = pokemon.Id;
        Level = Math.Max(1, initialLevel);
    }

    private int ExperienceToNextLevel() => BaseXpPerLevel * Level;

    // Apply XP, perform level-ups and unlock abilities when required
    // Returns newly unlocked abilities
    public IEnumerable<Ability> GainExperience(int xp)
    {
        if (xp <= 0) return Array.Empty<Ability>();

        Experience += xp;
        var newlyUnlocked = new List<Ability>();

        while (Experience >= ExperienceToNextLevel())
        {
            Experience -= ExperienceToNextLevel();
            Level++;

            var abilitiesNowAvailable = Pokemon.Abilities
                .Where(pa => pa.RequiredLevel <= Level)
                .Select(pa => pa.Ability)
                .Where(a => UnlockedAbilities.All(u => u.AbilityId != a.Id));

            foreach (var ability in abilitiesNowAvailable)
            {
                UnlockedAbilities.Add(new TrainerPokemonAbility(ability));
                newlyUnlocked.Add(ability);
            }
        }

        return newlyUnlocked;
    }
}
