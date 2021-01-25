using Microsoft.EntityFrameworkCore.Migrations;

namespace PuppyLove.Migrations
{
    public partial class SeedTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "ImgUrl", "Location", "Mood", "Name", "OwnerName", "Size" },
                values: new object[] { 1, 8, "Mixed", "https://drive.google.com/file/d/12-NJjKT1mrCuA1lDzVCF9-1nec04oydw/view?usp=sharing", "Portland, OR", "Upbeat and calm", "Helo", "Dave", "Medium" });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "ImgUrl", "Location", "Mood", "Name", "OwnerName", "Size" },
                values: new object[] { 2, 2, "Mixed", "https://photos.app.goo.gl/3sn4vdSiKDbLutba8", "Portland, OR", "Snarky", "Bartleby", "Sage", "Small" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2);
        }
    }
}
