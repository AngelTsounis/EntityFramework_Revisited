using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PokemonTrainers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evolutions");

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainerPokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerPokemons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainerPokemons_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainerPokemons_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainerPokemonAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainerPokemonId = table.Column<int>(type: "int", nullable: false),
                    AbilityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerPokemonAbilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainerPokemonAbilities_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainerPokemonAbilities_TrainerPokemons_TrainerPokemonId",
                        column: x => x.TrainerPokemonId,
                        principalTable: "TrainerPokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "SecondaryTypeId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_TrainerPokemonAbilities_AbilityId",
                table: "TrainerPokemonAbilities",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerPokemonAbilities_TrainerPokemonId",
                table: "TrainerPokemonAbilities",
                column: "TrainerPokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerPokemons_PokemonId",
                table: "TrainerPokemons",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerPokemons_TrainerId",
                table: "TrainerPokemons",
                column: "TrainerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainerPokemonAbilities");

            migrationBuilder.DropTable(
                name: "TrainerPokemons");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.CreateTable(
                name: "Evolutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromPokemonId = table.Column<int>(type: "int", nullable: false),
                    ToPokemonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evolutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evolutions_Pokemons_FromPokemonId",
                        column: x => x.FromPokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evolutions_Pokemons_ToPokemonId",
                        column: x => x.ToPokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Evolutions",
                columns: new[] { "Id", "FromPokemonId", "ToPokemonId" },
                values: new object[,]
                {
                    { 1, 4, 11 },
                    { 2, 2, 12 },
                    { 3, 3, 13 }
                });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "SecondaryTypeId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Evolutions_FromPokemonId",
                table: "Evolutions",
                column: "FromPokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Evolutions_ToPokemonId",
                table: "Evolutions",
                column: "ToPokemonId");
        }
    }
}
