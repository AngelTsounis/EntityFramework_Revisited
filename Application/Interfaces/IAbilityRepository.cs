using Application.Contracts.Response;

namespace Application.Interfaces;

public interface IAbilityRepository
{
    Task<AbilityResponse> GetAbilityByIdAsync(int id);
}
