
namespace Application.Contracts.Response;

public class TrainerPokemonResponse
{
    public int Id { get; set; }
    public int TrainerId { get; set; }
    public string Trainer { get; set; } = null!;

    public int PokemonId { get; set; }
    public string Pokemon { get; set; } = null!;

    public int Level { get; set; }
    public int Experience { get; set; }

    public ICollection<TrainerPokemonAbilityResponse> UnlockedAbilities { get; set; } = new List<TrainerPokemonAbilityResponse>();
}
