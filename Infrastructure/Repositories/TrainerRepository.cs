using Application.Contracts.Response;
using Application.Interfaces;
using Infrastructure.Mappers;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class TrainerRepository : ITrainerRepository
{
    private readonly AppDbContext _context;
    public TrainerRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<TrainerResponse?> GetTrainerWithDetailsAsync(int trainerId)
    {
        var trainer = await _context.Trainers
            .Include(t => t.OwnedPokemons)
                .ThenInclude(tp => tp.Pokemon)
                    .ThenInclude(p => p.Abilities)
                        .ThenInclude(pa => pa.Ability)
            .Include(t => t.OwnedPokemons)
                .ThenInclude(tp => tp.UnlockedAbilities)
                    .ThenInclude(ua => ua.Ability)
            .SingleOrDefaultAsync(t => t.Id == trainerId);

        if (trainer is null) return null;

        return trainer.MapToTrainerResponse();
    }
}