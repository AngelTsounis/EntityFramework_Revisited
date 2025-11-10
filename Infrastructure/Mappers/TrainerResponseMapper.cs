using Application.Contracts.Response;
using Infrastructure.Models;

namespace Infrastructure.Mappers;

public static class TrainerMapper
{
    public static TrainerResponse MapToTrainerResponse(this TrainerEntity trainer)
    {
        if (trainer == null) throw new ArgumentNullException(nameof(trainer));

        return new TrainerResponse
        {
            Id = trainer.Id,
            Username = trainer.Username,
            OwnedPokemons = trainer.OwnedPokemons?
                .Select(tp => tp.MapToTrainerPokemonResponse())
                .ToList() ?? new List<TrainerPokemonResponse>()
        };
    }

    public static TrainerPokemonResponse MapToTrainerPokemonResponse(this TrainerPokemonEntity trainerPokemon)
    {
        if (trainerPokemon == null) throw new ArgumentNullException(nameof(trainerPokemon));

        return new TrainerPokemonResponse
        {
            Id = trainerPokemon.Id,
            TrainerId = trainerPokemon.TrainerId,
            Trainer = trainerPokemon.Trainer?.Username ?? string.Empty,
            PokemonId = trainerPokemon.PokemonId,
            Pokemon = trainerPokemon.Pokemon?.Name ?? string.Empty,
            Level = trainerPokemon.Level,
            Experience = trainerPokemon.Experience,
            UnlockedAbilities = trainerPokemon.UnlockedAbilities?
                .Select(u => u.MapToTrainerPokemonAbilityResponse())
                .ToList() ?? new List<TrainerPokemonAbilityResponse>()
        };
    }

    public static TrainerPokemonAbilityResponse MapToTrainerPokemonAbilityResponse(this TrainerPokemonAbilityEntity entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));

        return new TrainerPokemonAbilityResponse
        {
            AbilityId = entity.AbilityId,
            Name = entity.Ability?.Name ?? string.Empty,
            Description = entity.Ability?.Description ?? string.Empty,
        };
    }
}
