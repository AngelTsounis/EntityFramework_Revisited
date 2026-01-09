using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedPokemonWeakness : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weaknesses",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    ElementTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weaknesses", x => new { x.PokemonId, x.ElementTypeId });
                    table.ForeignKey(
                        name: "FK_Weaknesses_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Weaknesses_Types_ElementTypeId",
                        column: x => x.ElementTypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Weaknesses",
                columns: new[] { "ElementTypeId", "PokemonId" },
                values: new object[,]
                {
                    { 10, 1 },
                    { 3, 2 },
                    { 9, 2 },
                    { 10, 2 },
                    { 1, 3 },
                    { 4, 3 },
                    { 2, 4 },
                    { 5, 4 },
                    { 8, 4 },
                    { 1, 5 },
                    { 9, 5 },
                    { 3, 7 },
                    { 4, 7 },
                    { 1, 8 },
                    { 4, 8 },
                    { 3, 10 },
                    { 9, 10 },
                    { 10, 10 },
                    { 2, 11 },
                    { 5, 11 },
                    { 8, 11 },
                    { 3, 12 },
                    { 9, 12 },
                    { 10, 12 },
                    { 1, 13 },
                    { 4, 13 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Weaknesses_ElementTypeId",
                table: "Weaknesses",
                column: "ElementTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weaknesses");

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
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false)
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
                    AbilityId = table.Column<int>(type: "int", nullable: false),
                    TrainerPokemonId = table.Column<int>(type: "int", nullable: false)
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
    }
}
