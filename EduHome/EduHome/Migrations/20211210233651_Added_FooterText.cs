using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class Added_FooterText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FooterText",
                table: "Settings",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FooterText",
                table: "Settings");
        }
    }
}
