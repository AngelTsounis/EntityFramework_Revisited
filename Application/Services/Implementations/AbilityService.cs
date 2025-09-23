using Application.Contracts.Response;
using Application.Interfaces;
using Application.Services.Interfaces;

namespace Application.Services.Implementations;

public class AbilityService : IAbilityService
{
    private readonly IAbilityRepository _abilityRepository;
    public AbilityService(IAbilityRepository abilityRepository)
    {
        _abilityRepository = abilityRepository;
    }
    public async Task<AbilityResponse> GetAbilityByIdServiceAsync(int id)
    {
        return await _abilityRepository.GetAbilityByIdAsync(id);
    }
}
