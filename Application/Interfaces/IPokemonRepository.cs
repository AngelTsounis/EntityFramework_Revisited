using Application.Contracts.Response;

namespace Application.Interfaces
{
    public interface IPokemonRepository
    {
        Task<List<PokemonResponse>> GetAllPokemonsAsync();
    }
}
