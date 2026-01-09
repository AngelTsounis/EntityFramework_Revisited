using Infrastructure.Data;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<PokemonEntity> Pokemons => Set<PokemonEntity>();
    public DbSet<ElementTypeEntity> Types => Set<ElementTypeEntity>();
    public DbSet<AbilityEntity> Abilities => Set<AbilityEntity>();
    public DbSet<PokemonAbilityEntity> PokemonAbilities => Set<PokemonAbilityEntity>();
    public DbSet<WeaknessesEntity> Weaknesses => Set<WeaknessesEntity>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        // Seed data
        modelBuilder.Entity<PokemonEntity>().HasData(PokemonSeedData.GetPokemons());
        modelBuilder.Entity<ElementTypeEntity>().HasData(ElementTypeSeedData.GetElementTypes());
        modelBuilder.Entity<AbilityEntity>().HasData(AbilitySeedData.GetAbilities());
        modelBuilder.Entity<PokemonAbilityEntity>().HasData(PokemonAbilitySeedData.GetPokemonAbilities());
        modelBuilder.Entity<WeaknessesEntity>().HasData(WeaknessesSeedData.GetWeaknesses());

        // Configure relationships
        modelBuilder.Entity<PokemonEntity>()
            .HasOne(p => p.PrimaryType)
            .WithMany()
            .HasForeignKey(p => p.PrimaryTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<PokemonEntity>()
            .HasOne(p => p.SecondaryType)
            .WithMany()
            .HasForeignKey(p => p.SecondaryTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<PokemonAbilityEntity>()
            .HasKey(pa => new { pa.PokemonId, pa.AbilityId });

        modelBuilder.Entity<PokemonAbilityEntity>()
            .HasOne(pa => pa.Pokemon)
            .WithMany(p => p.Abilities)
            .HasForeignKey(pa => pa.PokemonId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<WeaknessesEntity>()
            .HasKey(w => new { w.PokemonId, w.ElementTypeId });

        modelBuilder.Entity<WeaknessesEntity>()
            .HasOne(w => w.Pokemon)
            .WithMany(p => p.Weaknesses)
            .HasForeignKey(w => w.PokemonId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<WeaknessesEntity>()
            .HasOne(w => w.ElementType)
            .WithMany()
            .HasForeignKey(w => w.ElementTypeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

