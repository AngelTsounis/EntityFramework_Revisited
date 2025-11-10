using Application.Contracts.Response;
using Application.Services.Interfaces;
using Domain.Models.Trainer;

namespace Application.Services.Implementations;

public class TrainerService : ITrainerService
{
    public Task AddPokemonToTrainerAsync(int trainerId, int pokemonId, int initialLevel = 1)
    {
        throw new NotImplementedException();
    }

    public Task<Trainer?> GetTrainerAsync(int trainerId)
    {
        throw new NotImplementedException();
    }

    public Task<List<AbilityResponse>> GiveExperienceAsync(int trainerId, int trainerPokemonId, int xp)
    {
        throw new NotImplementedException();
    }
}
