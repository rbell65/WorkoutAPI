using Microsoft.EntityFrameworkCore.Migrations;

namespace FT3.Migrations
{
    public partial class seedExercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "ID", "Max", "Type", "Name" },
                values: new object[] { 357, 205, "Strength", "Bench Press" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "ID", "Max", "Type", "Name" },
                values: new object[] { 358, 305, "Strength", "Squat" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "ID", "Max", "Type", "Name" },
                values: new object[] { 359, 325, "Strength", "Deadlift" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 359);
        }
    }
}
