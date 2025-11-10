
namespace Application.Contracts.Response;

public class TrainerResponse
{
    public int Id { get; set; }
    public string Username { get; set; } = null!;

    public ICollection<TrainerPokemonResponse> OwnedPokemons { get; set; } = new List<TrainerPokemonResponse>();
}
