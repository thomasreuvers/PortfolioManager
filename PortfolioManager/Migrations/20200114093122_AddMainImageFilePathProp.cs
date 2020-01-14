using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioManager.Migrations
{
    public partial class AddMainImageFilePathProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MainImageFilePath",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainImageFilePath",
                table: "Posts");
        }
    }
}
