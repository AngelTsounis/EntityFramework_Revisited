using Application.Contracts.Response;

namespace Application.Services.Interfaces;

public interface IAbilityService
{
    Task<AbilityResponse> GetAbilityByIdServiceAsync(int id);
}
