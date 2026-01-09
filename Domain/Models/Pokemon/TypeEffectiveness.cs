using Domain.Models.Enums;

namespace Domain.Models.Pokemon;

public static class TypeEffectiveness
{
    private static Dictionary<(string AttackingType, string DefendingType), Effectiveness> _effectiveness = new()
    {
        // Fire matchups
        [("Fire", "Grass")] = Effectiveness.SuperEffective,
        [("Fire", "Water")] = Effectiveness.NotVeryEffective,
        [("Fire", "Fire")] = Effectiveness.NotVeryEffective,
        [("Fire", "Rock")] = Effectiveness.NotVeryEffective,
        [("Fire", "Ground")] = Effectiveness.NotVeryEffective,          
        // Water matchups
        [("Water", "Fire")] = Effectiveness.SuperEffective,
        [("Water", "Grass")] = Effectiveness.NotVeryEffective,
        [("Water", "Water")] = Effectiveness.NotVeryEffective,
        [("Water", "Rock")] = Effectiveness.SuperEffective,
        [("Water", "Ground")] = Effectiveness.SuperEffective,
        // Grass matchups
        [("Grass", "Water")] = Effectiveness.SuperEffective,
        [("Grass", "Fire")] = Effectiveness.NotVeryEffective,
        [("Grass", "Grass")] = Effectiveness.NotVeryEffective,
        [("Grass", "Poison")] = Effectiveness.NotVeryEffective,
        [("Grass", "Ground")] = Effectiveness.SuperEffective,
        [("Grass", "Rock")] = Effectiveness.SuperEffective,
        [("Grass", "Flying")] = Effectiveness.NotVeryEffective,

        // Electric matchups
        [("Electric", "Water")] = Effectiveness.SuperEffective,
        [("Electric", "Flying")] = Effectiveness.SuperEffective,
        [("Electric", "Ground")] = Effectiveness.NoEffect,
        [("Electric", "Grass")] = Effectiveness.NotVeryEffective,
        [("Electric", "Electric")] = Effectiveness.NotVeryEffective,

        // Ground matchups
        [("Ground", "Electric")] = Effectiveness.SuperEffective,
        [("Ground", "Fire")] = Effectiveness.SuperEffective,
        [("Ground", "Poison")] = Effectiveness.SuperEffective,
        [("Ground", "Rock")] = Effectiveness.SuperEffective,
        [("Ground", "Grass")] = Effectiveness.NotVeryEffective,
        [("Ground", "Flying")] = Effectiveness.NoEffect,
        // Rock matchups
        [("Rock", "Fire")] = Effectiveness.SuperEffective,
        [("Rock", "Flying")] = Effectiveness.SuperEffective,
        [("Rock", "Ground")] = Effectiveness.NotVeryEffective,
        // Flying matchups
        [("Flying", "Grass")] = Effectiveness.SuperEffective,
        [("Flying", "Electric")] = Effectiveness.NotVeryEffective,
        [("Flying", "Rock")] = Effectiveness.NotVeryEffective,
        // Poison matchups
        [("Poison", "Grass")] = Effectiveness.SuperEffective,
        [("Poison", "Poison")] = Effectiveness.NotVeryEffective,
        [("Poison", "Ground")] = Effectiveness.NotVeryEffective,
        [("Poison", "Rock")] = Effectiveness.NotVeryEffective,

        // Psychic matchups
        [("Psychic", "Poison")] = Effectiveness.SuperEffective,
        [("Psychic", "Psychic")] = Effectiveness.NotVeryEffective,
        // Normal matchups
        [("Normal", "Rock")] = Effectiveness.NotVeryEffective,
    };


    public static Effectiveness GetEffectiveness(string attackingType, string defendingType)
    {
        var key = (attackingType, defendingType);

        return _effectiveness.TryGetValue(key, out var effectiveness)
            ? effectiveness
            : Effectiveness.NormalEffect;
    }

    //For dual-type Pokemons
    public static Effectiveness GetDualTypeEffectiveness(string attackingType, string primaryType, string? secondaryType)
    {
        var primaryEffect = GetEffectiveness(attackingType, primaryType);

        if (string.IsNullOrEmpty(secondaryType))
            return primaryEffect;

        var secondaryEffect = GetEffectiveness(attackingType, secondaryType);

        if (primaryEffect == Effectiveness.NoEffect || secondaryEffect == Effectiveness.NoEffect)
            return Effectiveness.NoEffect;

        if (primaryEffect == Effectiveness.SuperEffective || secondaryEffect == Effectiveness.SuperEffective)
            return Effectiveness.SuperEffective;

        if (primaryEffect == Effectiveness.NotVeryEffective || secondaryEffect == Effectiveness.NotVeryEffective)
            return Effectiveness.NotVeryEffective;

        return Effectiveness.NormalEffect;
    }
}
