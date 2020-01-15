using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioManager.Migrations
{
    public partial class AddPostImageFilePathsAndChangePropNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MainImagePath",
                table: "Posts",
                newName: "PostImageFilePaths");

            migrationBuilder.AddColumn<string>(
                name: "MainImageUrl",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainImageUrl",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "PostImageFilePaths",
                table: "Posts",
                newName: "MainImagePath");
        }
    }
}
