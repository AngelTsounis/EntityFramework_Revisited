using Application.Contracts.Response;
using Application.Interfaces;
using Infrastructure.Mappers;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
public class AbilityRepository : IAbilityRepository
{
    private readonly AppDbContext _context;

    public AbilityRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<AbilityResponse> GetAbilityByIdAsync(int id)
    {
        var ability = await _context.Abilities.FirstOrDefaultAsync(a => a.Id == id);

        if ( ability is null)

        {
            throw new KeyNotFoundException($"Ability with ID {id} not found.");
        }

        return ability.MapToAbilityResponse();
    }
}
