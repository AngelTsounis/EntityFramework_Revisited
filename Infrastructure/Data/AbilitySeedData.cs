using Infrastructure.Models;

namespace Infrastructure.Data;

public static class AbilitySeedData
{
    public static List<AbilityEntity> GetAbilities() => new()
    {
        new AbilityEntity { Id = 1, Name = "Static", Description = "May paralyze on contact." },
        new AbilityEntity { Id = 2, Name = "Blaze", Description = "Powers up Fire-type moves." },
        new AbilityEntity { Id = 3, Name = "Torrent", Description = "Powers up Water-type moves." },
        new AbilityEntity { Id = 4, Name = "Overgrow", Description = "Powers up Grass-type moves." },
        new AbilityEntity { Id = 5, Name = "Keen Eye", Description = "Prevents loss of accuracy." },
        new AbilityEntity { Id = 6, Name = "Cute Charm", Description = "May cause infatuation on contact." },
        new AbilityEntity { Id = 7, Name = "Sturdy", Description = "Prevents one-hit KO." },
        new AbilityEntity { Id = 8, Name = "Cloud Nine", Description = "Eliminates weather effects." },
        new AbilityEntity { Id = 9, Name = "Synchronize", Description = "Passes on status problems." },
        new AbilityEntity { Id = 10, Name = "Intimidate", Description = "Lowers the foe's Attack stat." },
        new AbilityEntity { Id = 11, Name = "Scratch", Description = "Inflicts regular damage." },
        new AbilityEntity { Id = 12, Name = "Ember", Description = "May inflict a burn." },
        new AbilityEntity { Id = 13, Name = "Flamethrower", Description = "May inflict a burn."}
    };
}

