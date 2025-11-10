namespace Domain.Models.Trainer;

public class Trainer
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public IList<TrainerPokemon> OwnedPokemons { get; init; } = new List<TrainerPokemon>();

    public void AddPokemon(TrainerPokemon tp) => OwnedPokemons.Add(tp);

    public TrainerPokemon? GetPokemonById(int id) => OwnedPokemons.FirstOrDefault(p => p.Id == id);
}
