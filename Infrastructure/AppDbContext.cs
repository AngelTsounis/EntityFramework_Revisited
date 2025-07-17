using Infrastructure.Data;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Pokemon> Pokemons => Set<Pokemon>();
    public DbSet<ElementType> Types => Set<ElementType>();
    public DbSet<Ability> Abilities => Set<Ability>();
    public DbSet<PokemonAbility> PokemonAbilities => Set<PokemonAbility>();
    public DbSet<Evolution> Evolutions => Set<Evolution>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        modelBuilder.Entity<Pokemon>().HasData(PokemonSeedData.GetPokemons());
        modelBuilder.Entity<ElementType>().HasData(ElementTypeSeedData.GetElementTypes());
        modelBuilder.Entity<Ability>().HasData(AbilitySeedData.GetAbilities());
        modelBuilder.Entity<PokemonAbility>().HasData(PokemonAbilitySeedData.GetPokemonAbilities());
        modelBuilder.Entity<Evolution>().HasData(EvolutionSeedData.GetEvolutions());

        modelBuilder.Entity<PokemonAbility>()
            .HasKey(pa => new { pa.PokemonId, pa.AbilityId });

        modelBuilder.Entity<PokemonAbility>()
            .HasOne(pa => pa.Pokemon)
            .WithMany(p => p.Abilities)
            .HasForeignKey(pa => pa.PokemonId)
            .OnDelete(DeleteBehavior.Restrict);  // change from Cascade to Restrict

        modelBuilder.Entity<Evolution>()
            .HasOne(e => e.FromPokemon)
            .WithMany(p => p.Evolutions)
            .HasForeignKey(e => e.FromPokemonId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

