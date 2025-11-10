using Application.Services.Interfaces;

namespace PokemonAPI.Endpoints.Abilities;

public static class GetAbilityByIdEndpoint 
{
    public const string Name = "GetAbilityByIdEndpoint";

    public static IEndpointRouteBuilder MapToGetAbilityById(this IEndpointRouteBuilder app)
    {
        app.MapGet("/abilities/{id.int}", async (IAbilityService service) =>
        {
            var response = await service.GetAllAbilitiesServiceAsync();

            return Results.Ok(response);

        }).WithName(Name)
        .WithTags("Abilities");

        return app;
    }
}
