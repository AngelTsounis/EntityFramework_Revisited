namespace Infrastructure.Models;

public class TrainerEntity
{
    public int Id { get; set; }
    public string Username { get; set; } = null!;

    public ICollection<TrainerPokemonEntity> OwnedPokemons { get; set; } = new List<TrainerPokemonEntity>();
}
