using Application.Contracts.Response;

namespace Application.Services.Interfaces;

public interface IPokemonService
{
    Task<List<PokemonResponse>> GetAllPokemonsServiceAsync();   
    Task<PokemonResponse?> GetPokemonByNameServiceAsync(string name);
    Task<List<PokemonResponse>> GetPokemonByTypeServiceAsync(string type);
}
