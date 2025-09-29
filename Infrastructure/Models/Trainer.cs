namespace Infrastructure.Models;

public class Trainer
{
    public int Id { get; set; }
    public string Username { get; set; } = null!;

    public ICollection<TrainerPokemon> OwnedPokemons { get; set; } = new List<TrainerPokemon>();
}
