using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class Removed_BgImageFromChooseEduHome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Background",
                table: "ChooseEduHomes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Background",
                table: "ChooseEduHomes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }
    }
}
