using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRatingSystem.Migrations
{
    public partial class DescriptionAddedToMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Movie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Movie");
        }
    }
}
