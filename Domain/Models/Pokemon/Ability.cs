namespace Domain.Models.Pokemon;

public class Ability
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }

    public Ability() { }

    public Ability(int id, string name, string? description = null)
    {
        Id = id;
        Name = name ?? string.Empty;
        Description = description;
    }
}
