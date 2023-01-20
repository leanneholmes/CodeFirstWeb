using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamPlayers.Data.Migrations
{
    /// <inheritdoc />
    public partial class Salary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Salary",
                table: "Player",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 2,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 3,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 4,
                column: "Salary",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Player");
        }
    }
}
