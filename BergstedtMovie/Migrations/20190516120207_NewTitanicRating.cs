using Microsoft.EntityFrameworkCore.Migrations;

namespace BergstedtMovie.Migrations
{
    public partial class NewTitanicRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                column: "Rating",
                value: 3f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                column: "Rating",
                value: 5f);
        }
    }
}
