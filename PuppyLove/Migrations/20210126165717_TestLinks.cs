using Microsoft.EntityFrameworkCore.Migrations;

namespace PuppyLove.Migrations
{
    public partial class TestLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1,
                column: "ImgUrl",
                value: "https://i.imgur.com/LS0jkba");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2,
                column: "ImgUrl",
                value: "https://i.imgur.com/0rnaPDz");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3,
                column: "ImgUrl",
                value: "https://imgur.com/Mz05tCi");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4,
                column: "ImgUrl",
                value: "https://www.northerncaliforniapomskies.com/uploads/3/0/8/6/30869529/editor/19665518-1877651202487939-8847474768448559934-n.jpg?1507766002");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 5,
                column: "ImgUrl",
                value: "https://i.imgur.com/CdRyiIR.jpg");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 6,
                column: "ImgUrl",
                value: "https://i.imgur.com/Gwno8aA.jpg");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 8,
                column: "ImgUrl",
                value: "https://i.imgur.com/BgUMDya.jpg");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 10,
                columns: new[] { "ImgUrl", "Location" },
                values: new object[] { "https://i.imgur.com/Nh3fQoX.jpg", "Seattle, WA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1,
                column: "ImgUrl",
                value: "https://drive.google.com/file/d/12-NJjKT1mrCuA1lDzVCF9-1nec04oydw/view?usp=sharing");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2,
                column: "ImgUrl",
                value: "https://photos.app.goo.gl/3sn4vdSiKDbLutba8");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3,
                column: "ImgUrl",
                value: "https://share.icloud.com/photos/0mxrEdflh8fSsVDXz6QaL5X-A#Oak_Hills");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4,
                column: "ImgUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 5,
                column: "ImgUrl",
                value: "https://photos.app.goo.gl/H8VkzPHeg1M6oWa38");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 6,
                column: "ImgUrl",
                value: "https://photos.app.goo.gl/AqDXPTwJBJTzQP2s7");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 8,
                column: "ImgUrl",
                value: "https://photos.app.goo.gl/iBdKw2wsPtGdJjSL7");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 10,
                columns: new[] { "ImgUrl", "Location" },
                values: new object[] { "https://photos.google.com/share/AF1QipO5bGGUBOQx4txM8mzBV6CmO3XkdENz9JqiT9dcojGbZfvNm5EMeg72xS4xp9WVsQ/photo/AF1QipPr5iK36GruNOlXCycwJGYEO4_PglYjIDSj6kaQ?key=bzBjOTQ4dDdQMHhkREhJamRUcktNMXBDM213bFB3", "Seaettle, WA" });
        }
    }
}
