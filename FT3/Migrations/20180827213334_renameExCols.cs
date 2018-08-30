using Microsoft.EntityFrameworkCore.Migrations;

namespace FT3.Migrations
{
    public partial class renameExCols : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Exercise",
                newName: "exerciseType");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Exercise",
                newName: "exerciseName");

            migrationBuilder.RenameColumn(
                name: "Max",
                table: "Exercise",
                newName: "exerciseMax");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Exercise",
                newName: "exerciseID");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "exerciseID",
                keyValue: 357,
                column: "exerciseType",
                value: "Strength");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "exerciseID",
                keyValue: 358,
                column: "exerciseType",
                value: "Strength");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "exerciseID",
                keyValue: 359,
                column: "exerciseType",
                value: "Strength");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "exerciseType",
                table: "Exercise",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "exerciseName",
                table: "Exercise",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "exerciseMax",
                table: "Exercise",
                newName: "Max");

            migrationBuilder.RenameColumn(
                name: "exerciseID",
                table: "Exercise",
                newName: "ID");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 357,
                column: "Type",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 358,
                column: "Type",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 359,
                column: "Type",
                value: null);
        }
    }
}
