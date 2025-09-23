using Application.Services.Interfaces;

namespace PokemonAPI.Endpoints.Abilities;

public static class GetAbilityByIdEndpoint 
{
    public const string Name = "GetAbilityByIdEndpoint";

    public static IEndpointRouteBuilder MapToGetAbilityById(this IEndpointRouteBuilder app)
    {
        app.MapGet("/abilities/{id.int}", async (IAbilityService service, int id) =>
        {
            var response = await service.GetAbilityByIdServiceAsync(id);

            return Results.Ok(response);

        }).WithName(Name);

        return app;
    }
}
