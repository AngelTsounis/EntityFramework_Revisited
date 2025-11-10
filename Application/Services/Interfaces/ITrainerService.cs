using Application.Contracts.Response;
using Domain.Models.Trainer;

namespace Application.Services.Interfaces;

public interface ITrainerService
{
    Task<List<AbilityResponse>> GiveExperienceAsync(int trainerId, int trainerPokemonId, int xp);
    Task AddPokemonToTrainerAsync(int trainerId, int pokemonId, int initialLevel = 1);
    Task<Trainer?> GetTrainerAsync(int trainerId);
}
