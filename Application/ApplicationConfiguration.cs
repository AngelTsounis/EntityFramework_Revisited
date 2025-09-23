using Application.Interfaces;
using Application.Services.Implementations;
using Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ApplicationConfiguration
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IPokemonService, PokemonsService>();
        services.AddScoped<IAbilityService, AbilityService>();

        return services;
    }
}
