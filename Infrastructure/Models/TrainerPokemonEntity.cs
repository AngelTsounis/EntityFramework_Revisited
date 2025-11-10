namespace Infrastructure.Models;

public class TrainerPokemonEntity
{

    public int Id { get; set; }
    public int TrainerId { get; set; }
    public TrainerEntity Trainer { get; set; } = null!;

    public int PokemonId { get; set; }
    public PokemonEntity Pokemon { get; set; } = null!;

    public int Level { get; set; }
    public int Experience { get; set; }

    public ICollection<TrainerPokemonAbilityEntity> UnlockedAbilities { get; set; } = new List<TrainerPokemonAbilityEntity>();
}

