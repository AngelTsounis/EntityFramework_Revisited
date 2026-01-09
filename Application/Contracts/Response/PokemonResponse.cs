namespace Application.Contracts.Response;

public class PokemonResponse
{
    public string? Name { get; set; }
    public int PokedexNumber { get; set; }
    public string? PrimaryType { get; set; }
    public string? SecondaryType { get; set; }
    public ICollection<AbilityResponse> Abilities { get; set; } = new List<AbilityResponse>();
    public ICollection<string> Weaknesses { get; set; } = new List<string>();
}

