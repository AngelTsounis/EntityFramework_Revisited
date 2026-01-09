using Application.Contracts.Response;
using Application.Interfaces;
using Infrastructure.Mappers;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class PokemonRepository : IPokemonRepository
{
    private readonly AppDbContext _context;
    public PokemonRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<List<PokemonResponse>> GetAllAsync()
    {

        var pokemonsToFind = await _context.Pokemons
                .Include(p => p.PrimaryType)
                .Include(p => p.SecondaryType)
                .Include(p => p.Abilities)
                    .ThenInclude(pa => pa.Ability)
                .Include(p => p.Weaknesses)
                    .ThenInclude(w => w.ElementType)
                .ToListAsync();

        var pokemons = pokemonsToFind.Select(p => p.MapToPokemonResponse()).ToList();

        return pokemons;
    }
    public async Task<PokemonResponse?> GetPokemonByNameAsync(string name)
    {
        var pokemonToFind = await _context.Pokemons
               .Include(p => p.PrimaryType)
               .Include(p => p.SecondaryType)
               .Include(p => p.Abilities)
                    .ThenInclude(pa => pa.Ability)
               .Include(p => p.Weaknesses)
                    .ThenInclude(w => w.ElementType)
               .SingleOrDefaultAsync(p => p.Name!.ToLower() == name.ToLower());

        var pokemon = pokemonToFind?.MapToPokemonResponse();

        return pokemon;
    }

    public async Task<List<PokemonResponse>> GetPokemonByTypeAsync(string type)
    {
        // Normalize the type to lower case for case-insensitive comparison, in order to prevent performance issues in the query.
        var normalizedType = type.ToLower();

        var pokemons = await _context.Pokemons
            .Include(p => p.PrimaryType)
            .Include(p => p.SecondaryType)
            .Where(p =>
                p.PrimaryType.Name.ToLower() == normalizedType ||
                p.SecondaryType.Name.ToLower() == normalizedType)
            .Include(p => p.Abilities)
                    .ThenInclude(pa => pa.Ability)
            .Include(p => p.Weaknesses)
                    .ThenInclude(w => w.ElementType)
            .ToListAsync();

        var response = pokemons.Select(p => p.MapToPokemonResponse()).ToList();

        return response;

    }
}
