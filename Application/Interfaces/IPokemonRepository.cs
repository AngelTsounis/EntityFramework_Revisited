using Application.Contracts.Response;

namespace Application.Interfaces;

public interface IPokemonRepository
{
    Task<List<PokemonResponse>> GetAllPokemonsAsync();
    Task<PokemonResponse?> GetPokemonByNameAsync(string name);
    Task<List<PokemonResponse>?> GetPokemonByTypeAsync(string type);
}
