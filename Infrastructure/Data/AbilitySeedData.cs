using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Models;

namespace Infrastructure.Data;

public static class AbilitySeedData
{
    public static List<Ability> GetAbilities() => new()
    {
        new Ability { Id = 1, Name = "Static", Description = "May paralyze on contact." },
        new Ability { Id = 2, Name = "Blaze", Description = "Powers up Fire-type moves." },
        new Ability { Id = 3, Name = "Torrent", Description = "Powers up Water-type moves." },
        new Ability { Id = 4, Name = "Overgrow", Description = "Powers up Grass-type moves." },
        new Ability { Id = 5, Name = "Keen Eye", Description = "Prevents loss of accuracy." },
        new Ability { Id = 6, Name = "Cute Charm", Description = "May cause infatuation on contact." },
        new Ability { Id = 7, Name = "Sturdy", Description = "Prevents one-hit KO." },
        new Ability { Id = 8, Name = "Cloud Nine", Description = "Eliminates weather effects." },
        new Ability { Id = 9, Name = "Synchronize", Description = "Passes on status problems." },
        new Ability { Id = 10, Name = "Intimidate", Description = "Lowers the foe's Attack stat." }
    };
}

