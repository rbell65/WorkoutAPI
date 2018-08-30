using Microsoft.EntityFrameworkCore.Migrations;

namespace FT3.Migrations
{
    public partial class exerciseType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Exercise",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Exercise");
        }
    }
}
