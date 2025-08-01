using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedExtraSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "SecondaryTypeId",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "SecondaryTypeId",
                value: null);
        }
    }
}
