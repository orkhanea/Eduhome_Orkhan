using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class Updated_PropertyNameOnChooseEduHomes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "ChooseEduHomes",
                newName: "Background");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Background",
                table: "ChooseEduHomes",
                newName: "Image");
        }
    }
}
