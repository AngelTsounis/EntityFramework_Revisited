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
    public DbSet<TrainerEntity> Trainers => Set<TrainerEntity>();
    public DbSet<TrainerPokemonEntity> TrainerPokemons => Set<TrainerPokemonEntity>();
    public DbSet<TrainerPokemonAbilityEntity> TrainerPokemonAbilities => Set<TrainerPokemonAbilityEntity>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        // Seed data
        modelBuilder.Entity<PokemonEntity>().HasData(PokemonSeedData.GetPokemons());
        modelBuilder.Entity<ElementTypeEntity>().HasData(ElementTypeSeedData.GetElementTypes());
        modelBuilder.Entity<AbilityEntity>().HasData(AbilitySeedData.GetAbilities());
        modelBuilder.Entity<PokemonAbilityEntity>().HasData(PokemonAbilitySeedData.GetPokemonAbilities());

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


        modelBuilder.Entity<TrainerPokemonEntity>()
                    .HasOne(tp => tp.Trainer)
                    .WithMany(t => t.OwnedPokemons)
                    .HasForeignKey(tp => tp.TrainerId);

        modelBuilder.Entity<TrainerPokemonEntity>()
            .HasOne(tp => tp.Pokemon)
            .WithMany()
            .HasForeignKey(tp => tp.PokemonId);

        modelBuilder.Entity<TrainerPokemonAbilityEntity>()
            .HasOne(tpa => tpa.TrainerPokemon)
            .WithMany(tp => tp.UnlockedAbilities)
            .HasForeignKey(tpa => tpa.TrainerPokemonId);

        modelBuilder.Entity<TrainerPokemonAbilityEntity>()
            .HasOne(tpa => tpa.Ability)
            .WithMany()
            .HasForeignKey(tpa => tpa.AbilityId);

    }
}

