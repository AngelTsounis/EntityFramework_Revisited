using Infrastructure.Models;

namespace Infrastructure.Data;

public static class ElementTypeSeedData
{
    public static List<ElementType> GetElementTypes() => new()
    {
        new ElementType { Id = 1, Name = "Electric" },
        new ElementType { Id = 2, Name = "Fire" },
        new ElementType { Id = 3, Name = "Water" },
        new ElementType { Id = 4, Name = "Grass" },
        new ElementType { Id = 5, Name = "Flying" },
        new ElementType { Id = 6, Name = "Normal" },
        new ElementType { Id = 7, Name = "Poison" },
        new ElementType { Id = 8, Name = "Psychic" },
        new ElementType { Id = 9, Name = "Rock" },
        new ElementType { Id = 10, Name = "Ground" }
    };
}
