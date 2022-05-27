using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrtakFilmProjesi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discount = table.Column<float>(type: "real", nullable: false),
                    SessionTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryFilm",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    FilmsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryFilm", x => new { x.CategoriesId, x.FilmsId });
                    table.ForeignKey(
                        name: "FK_CategoryFilm_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryFilm_Films_FilmsId",
                        column: x => x.FilmsId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmSession",
                columns: table => new
                {
                    FilmsId = table.Column<int>(type: "int", nullable: false),
                    SessionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmSession", x => new { x.FilmsId, x.SessionsId });
                    table.ForeignKey(
                        name: "FK_FilmSession_Films_FilmsId",
                        column: x => x.FilmsId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmSession_Sessions_SessionsId",
                        column: x => x.SessionsId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Description", "Name", "PhotoPath", "Price" },
                values: new object[,]
                {
                    { 1, "Fiziksel ve ruhsal bir şifa yolculuğundayken, parlak bir beyin cerrahı mistik sanatların dünyasına çekilir.", "Dr.Strange", "Dr.Strange.png", 50.0 },
                    { 2, "Asil bir aile, galaksinin en değerli varlığı üzerinde kontrol için bir savaşa girerken, varisi karanlık bir geleceğin vizyonları tarafından rahatsız edilir.", "Dune", "Dune.png", 50.0 },
                    { 3, "Bir kaşif ekibi, insanlığın hayatta kalmasını sağlamak için uzayda bir solucan deliğinden geçer.", "Interstellar", "Interstellar.png", 50.0 },
                    { 4, "Thor, tanrıları yok etmeyi amaçlayan Tanrı Kasabı Gorr ile savaşmak için Valkyrie, Korg ve eski kız arkadaşı Jane Foster'dan yardım ister.", "Thor", "Thor.png", 50.0 },
                    { 5, "Donanmanın en iyi havacılarından biri olarak otuz yıldan fazla hizmet verdikten sonra, Pete Mitchell ait olduğu yerdedir, cesur bir test pilotu olarak sınırları zorlar ve onu yere indirecek rütbedeki ilerlemeden kaçınır.", "TopGun", "TopGun.png", 50.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Mail", "Password" },
                values: new object[,]
                {
                    { 1, "admin@hotmail.com", "12345" },
                    { 2, "user1@hotmail.com", "12345" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFilm_FilmsId",
                table: "CategoryFilm",
                column: "FilmsId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmSession_SessionsId",
                table: "FilmSession",
                column: "SessionsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryFilm");

            migrationBuilder.DropTable(
                name: "FilmSession");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Sessions");
        }
    }
}
