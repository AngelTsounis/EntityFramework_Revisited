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
    public DbSet<Trainer> Trainers => Set<Trainer>();
    public DbSet<TrainerPokemon> TrainerPokemons => Set<TrainerPokemon>();
    public DbSet<TrainerPokemonAbility> TrainerPokemonAbilities => Set<TrainerPokemonAbility>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        // Seed data
        modelBuilder.Entity<Pokemon>().HasData(PokemonSeedData.GetPokemons());
        modelBuilder.Entity<ElementType>().HasData(ElementTypeSeedData.GetElementTypes());
        modelBuilder.Entity<Ability>().HasData(AbilitySeedData.GetAbilities());
        modelBuilder.Entity<PokemonAbility>().HasData(PokemonAbilitySeedData.GetPokemonAbilities());

        // Configure relationships
        modelBuilder.Entity<Pokemon>()
            .HasOne(p => p.PrimaryType)
            .WithMany()
            .HasForeignKey(p => p.PrimaryTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Pokemon>()
            .HasOne(p => p.SecondaryType)
            .WithMany()
            .HasForeignKey(p => p.SecondaryTypeId)
            .OnDelete(DeleteBehavior.Restrict);


        modelBuilder.Entity<PokemonAbility>()
            .HasKey(pa => new { pa.PokemonId, pa.AbilityId });

        modelBuilder.Entity<PokemonAbility>()
            .HasOne(pa => pa.Pokemon)
            .WithMany(p => p.Abilities)
            .HasForeignKey(pa => pa.PokemonId)
            .OnDelete(DeleteBehavior.Restrict);


        modelBuilder.Entity<TrainerPokemon>()
                    .HasOne(tp => tp.Trainer)
                    .WithMany(t => t.OwnedPokemons)
                    .HasForeignKey(tp => tp.TrainerId);

        modelBuilder.Entity<TrainerPokemon>()
            .HasOne(tp => tp.Pokemon)
            .WithMany()
            .HasForeignKey(tp => tp.PokemonId);

        modelBuilder.Entity<TrainerPokemonAbility>()
            .HasOne(tpa => tpa.TrainerPokemon)
            .WithMany(tp => tp.UnlockedAbilities)
            .HasForeignKey(tpa => tpa.TrainerPokemonId);

        modelBuilder.Entity<TrainerPokemonAbility>()
            .HasOne(tpa => tpa.Ability)
            .WithMany()
            .HasForeignKey(tpa => tpa.AbilityId);

    }
}

