using Microsoft.EntityFrameworkCore.Migrations;

namespace OrtakFilmProjesi.Migrations
{
    public partial class AddFilm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Description", "Name", "PhotoPath", "Price" },
                values: new object[] { 3, "Bir kaşif ekibi, insanlığın hayatta kalmasını sağlamak için uzayda bir solucan deliğinden geçer.", "Interstellar", "Interstellar.png", 50.0 });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Description", "Name", "PhotoPath", "Price" },
                values: new object[] { 4, "Thor, tanrıları yok etmeyi amaçlayan Tanrı Kasabı Gorr ile savaşmak için Valkyrie, Korg ve eski kız arkadaşı Jane Foster'dan yardım ister.", "Thor", "Thor.png", 50.0 });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Description", "Name", "PhotoPath", "Price" },
                values: new object[] { 5, "Donanmanın en iyi havacılarından biri olarak otuz yıldan fazla hizmet verdikten sonra, Pete Mitchell ait olduğu yerdedir, cesur bir test pilotu olarak sınırları zorlar ve onu yere indirecek rütbedeki ilerlemeden kaçınır.", "TopGun", "TopGun.png", 50.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
