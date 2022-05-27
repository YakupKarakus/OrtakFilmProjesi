using Microsoft.EntityFrameworkCore.Migrations;

namespace OrtakFilmProjesi.Migrations
{
    public partial class film_photo_notMapped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "Films");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
