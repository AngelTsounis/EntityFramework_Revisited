using Application.Contracts.Response;
using Application.Interfaces;
using Application.Services.Interfaces;

namespace Application.Services.Implementations;

public class PokemonsService : IPokemonService
{
    private readonly IPokemonRepository _repository;

    public PokemonsService(IPokemonRepository repository)
    {
        _repository = repository;
    }
    public async Task<List<PokemonResponse>> GetAllPokemonsServiceAsync()
    {
        return await _repository.GetAllPokemonsAsync();
    }

    public async Task<PokemonResponse?> GetPokemonByNameServiceAsync(string name)
    {
       return await _repository.GetPokemonByNameAsync(name);
    }

    public async Task<List<PokemonResponse>> GetPokemonByTypeServiceAsync(string type)
    {
       return await _repository.GetPokemonByTypeAsync(type);
    }
}
