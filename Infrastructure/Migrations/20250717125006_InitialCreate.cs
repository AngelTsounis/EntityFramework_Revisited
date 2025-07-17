using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PokedexNumber = table.Column<int>(type: "int", nullable: false),
                    PrimaryTypeId = table.Column<int>(type: "int", nullable: false),
                    SecondaryTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemons_Types_PrimaryTypeId",
                        column: x => x.PrimaryTypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemons_Types_SecondaryTypeId",
                        column: x => x.SecondaryTypeId,
                        principalTable: "Types",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateTable(
                name: "PokemonAbilities",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    AbilityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonAbilities", x => new { x.PokemonId, x.AbilityId });
                    table.ForeignKey(
                        name: "FK_PokemonAbilities_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonAbilities_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "May paralyze on contact.", "Static" },
                    { 2, "Powers up Fire-type moves.", "Blaze" },
                    { 3, "Powers up Water-type moves.", "Torrent" },
                    { 4, "Powers up Grass-type moves.", "Overgrow" },
                    { 5, "Prevents loss of accuracy.", "Keen Eye" },
                    { 6, "May cause infatuation on contact.", "Cute Charm" },
                    { 7, "Prevents one-hit KO.", "Sturdy" },
                    { 8, "Eliminates weather effects.", "Cloud Nine" },
                    { 9, "Passes on status problems.", "Synchronize" },
                    { 10, "Lowers the foe's Attack stat.", "Intimidate" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Electric" },
                    { 2, "Fire" },
                    { 3, "Water" },
                    { 4, "Grass" },
                    { 5, "Flying" },
                    { 6, "Normal" },
                    { 7, "Poison" },
                    { 8, "Psychic" },
                    { 9, "Rock" },
                    { 10, "Ground" }
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Name", "PokedexNumber", "PrimaryTypeId", "SecondaryTypeId" },
                values: new object[,]
                {
                    { 1, "Pikachu", 25, 1, null },
                    { 2, "Charmander", 4, 2, null },
                    { 3, "Squirtle", 7, 3, null },
                    { 4, "Bulbasaur", 1, 4, 7 },
                    { 5, "Pidgey", 16, 6, 5 },
                    { 6, "Jigglypuff", 39, 6, null },
                    { 7, "Geodude", 74, 9, 10 },
                    { 8, "Psyduck", 54, 3, null },
                    { 9, "Abra", 63, 8, null },
                    { 10, "Growlithe", 58, 2, null },
                    { 11, "Ivysaur", 2, 4, 7 },
                    { 12, "Charmeleon", 5, 2, null },
                    { 13, "Wartortle", 8, 3, null }
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

            migrationBuilder.InsertData(
                table: "PokemonAbilities",
                columns: new[] { "AbilityId", "PokemonId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evolutions_FromPokemonId",
                table: "Evolutions",
                column: "FromPokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Evolutions_ToPokemonId",
                table: "Evolutions",
                column: "ToPokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonAbilities_AbilityId",
                table: "PokemonAbilities",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_PrimaryTypeId",
                table: "Pokemons",
                column: "PrimaryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_SecondaryTypeId",
                table: "Pokemons",
                column: "SecondaryTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evolutions");

            migrationBuilder.DropTable(
                name: "PokemonAbilities");

            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
