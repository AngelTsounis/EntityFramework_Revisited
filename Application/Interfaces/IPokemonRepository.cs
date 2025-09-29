using Application.Contracts.Response;
using Application.Interfaces;

public interface IPokemonRepository : IBaseRepository<PokemonResponse>
{
    Task<PokemonResponse?> GetPokemonByNameAsync(string name);
    Task<List<PokemonResponse>> GetPokemonByTypeAsync(string type);
}
