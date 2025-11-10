namespace Domain.Models.Pokemon;

public class Pokemon
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public IList<PokemonAbility> Abilities { get; init; } = new List<PokemonAbility>();

    public Pokemon() { }

    public Pokemon(int id, string name, IEnumerable<PokemonAbility>? abilities = null)
    {
        Id = id;
        Name = name ?? string.Empty;
        if (abilities != null)
            foreach (var a in abilities) Abilities.Add(a);
    }
}
