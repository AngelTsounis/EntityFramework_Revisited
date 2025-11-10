using Application.Contracts.Response;
using Infrastructure.Models;

namespace Infrastructure.Mappers;

public static class AbilityResponseMapper
{
    public static AbilityResponse MapToAbilityResponse (this AbilityEntity entity)
    {
        var abilityResponse = new AbilityResponse
        {
            Name = entity.Name,
            Description = entity.Description
        };

        return abilityResponse;
    }
}
