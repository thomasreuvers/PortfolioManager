using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioManager.Migrations
{
    public partial class AddImageFilePathProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "ImageFilePath",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFilePath",
                table: "AspNetUsers");

        }
    }
}
