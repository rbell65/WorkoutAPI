using Microsoft.EntityFrameworkCore.Migrations;

namespace FT3.Migrations
{
    public partial class seedexerciseType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
            table: "Exercise",
            keyColumn: "ID",
            keyValue: 357,
            column: "Type",
            value: "Strength");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 358,
                column: "Type",
                value: "Strength");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 359,
                column: "Type",
                value: "Strength");
        
    }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
