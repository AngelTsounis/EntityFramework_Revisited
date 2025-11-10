using Infrastructure.Models;

namespace Infrastructure.Data;

public static class ElementTypeSeedData
{
    public static List<ElementTypeEntity> GetElementTypes() => new()
    {
        new ElementTypeEntity { Id = 1, Name = "Electric" },
        new ElementTypeEntity { Id = 2, Name = "Fire" },
        new ElementTypeEntity { Id = 3, Name = "Water" },
        new ElementTypeEntity { Id = 4, Name = "Grass" },
        new ElementTypeEntity { Id = 5, Name = "Flying" },
        new ElementTypeEntity { Id = 6, Name = "Normal" },
        new ElementTypeEntity { Id = 7, Name = "Poison" },
        new ElementTypeEntity { Id = 8, Name = "Psychic" },
        new ElementTypeEntity { Id = 9, Name = "Rock" },
        new ElementTypeEntity { Id = 10, Name = "Ground" }
    };
}
