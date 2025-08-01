using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPokemonTypeRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Types_PrimaryTypeId",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Types_SecondaryTypeId",
                table: "Pokemons");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Types_PrimaryTypeId",
                table: "Pokemons",
                column: "PrimaryTypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Types_SecondaryTypeId",
                table: "Pokemons",
                column: "SecondaryTypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Types_PrimaryTypeId",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Types_SecondaryTypeId",
                table: "Pokemons");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Types_PrimaryTypeId",
                table: "Pokemons",
                column: "PrimaryTypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Types_SecondaryTypeId",
                table: "Pokemons",
                column: "SecondaryTypeId",
                principalTable: "Types",
                principalColumn: "Id");
        }
    }
}
