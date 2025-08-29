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

    public async Task<List<PokemonResponse>> GetAllPokemonsAsync()
    {

        var pokemonsToFind = await _context.Pokemons
                .Include(p => p.PrimaryType)
                .Include(p => p.SecondaryType)
                .ToListAsync();

        var pokemons = pokemonsToFind.Select(p => p.MapToPokemonResponse()).ToList();

        return pokemons;
    }
}
