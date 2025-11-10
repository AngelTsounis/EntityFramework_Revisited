namespace Application.Contracts.Response;

public class TrainerPokemonAbilityResponse
{
    public int AbilityId { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
}