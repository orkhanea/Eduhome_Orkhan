using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class Added_HeaderLogo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HeaderLogo2",
                table: "Settings",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeaderLogo2",
                table: "Settings");
        }
    }
}
