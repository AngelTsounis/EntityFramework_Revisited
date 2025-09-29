using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PokemonAbilityOptimize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RequiredLevel",
                table: "PokemonAbilities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 11, "Inflicts regular damage.", "Scratch" },
                    { 12, "May inflict a burn.", "Ember" },
                    { 13, "May inflict a burn.", "Flamethrower" }
                });

            migrationBuilder.UpdateData(
                table: "PokemonAbilities",
                keyColumns: new[] { "AbilityId", "PokemonId" },
                keyValues: new object[] { 1, 1 },
                column: "RequiredLevel",
                value: 15);

            migrationBuilder.UpdateData(
                table: "PokemonAbilities",
                keyColumns: new[] { "AbilityId", "PokemonId" },
                keyValues: new object[] { 2, 2 },
                column: "RequiredLevel",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PokemonAbilities",
                keyColumns: new[] { "AbilityId", "PokemonId" },
                keyValues: new object[] { 3, 3 },
                column: "RequiredLevel",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PokemonAbilities",
                keyColumns: new[] { "AbilityId", "PokemonId" },
                keyValues: new object[] { 4, 4 },
                column: "RequiredLevel",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PokemonAbilities",
                keyColumns: new[] { "AbilityId", "PokemonId" },
                keyValues: new object[] { 5, 5 },
                column: "RequiredLevel",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PokemonAbilities",
                keyColumns: new[] { "AbilityId", "PokemonId" },
                keyValues: new object[] { 6, 6 },
                column: "RequiredLevel",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PokemonAbilities",
                keyColumns: new[] { "AbilityId", "PokemonId" },
                keyValues: new object[] { 7, 7 },
                column: "RequiredLevel",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PokemonAbilities",
                keyColumns: new[] { "AbilityId", "PokemonId" },
                keyValues: new object[] { 8, 8 },
                column: "RequiredLevel",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PokemonAbilities",
                keyColumns: new[] { "AbilityId", "PokemonId" },
                keyValues: new object[] { 9, 9 },
                column: "RequiredLevel",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PokemonAbilities",
                keyColumns: new[] { "AbilityId", "PokemonId" },
                keyValues: new object[] { 10, 10 },
                column: "RequiredLevel",
                value: 0);

            migrationBuilder.InsertData(
                table: "PokemonAbilities",
                columns: new[] { "AbilityId", "PokemonId", "RequiredLevel" },
                values: new object[,]
                {
                    { 11, 1, 1 },
                    { 12, 1, 7 },
                    { 13, 1, 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonAbilities",
                keyColumns: new[] { "AbilityId", "PokemonId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "PokemonAbilities",
                keyColumns: new[] { "AbilityId", "PokemonId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "PokemonAbilities",
                keyColumns: new[] { "AbilityId", "PokemonId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DropColumn(
                name: "RequiredLevel",
                table: "PokemonAbilities");
        }
    }
}
