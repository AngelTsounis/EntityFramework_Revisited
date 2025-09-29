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

    public Task<List<AbilityResponse>> GetAllAsync()
    {
        var ability = _context.Abilities
            .Select(a => a.MapToAbilityResponse())
            .ToListAsync();

        return ability;
    }
}
