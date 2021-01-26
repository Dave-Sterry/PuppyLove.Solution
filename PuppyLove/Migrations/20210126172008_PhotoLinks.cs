using Microsoft.EntityFrameworkCore.Migrations;

namespace PuppyLove.Migrations
{
    public partial class PhotoLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1,
                column: "ImgUrl",
                value: "https://i.imgur.com/LS0jkba.jpg");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2,
                column: "ImgUrl",
                value: "https://i.imgur.com/0rnaPDz.jpg");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3,
                column: "ImgUrl",
                value: "https://i.imgur.com/Mz05tCi.jpg");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 7,
                column: "ImgUrl",
                value: "https://i.pinimg.com/originals/4d/96/6e/4d966ead8837ef9d72d1f1c01fe1b53f.jpg");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 9,
                column: "ImgUrl",
                value: "https://s3.amazonaws.com/cdn-origin-etr.akc.org/wp-content/uploads/2017/11/14112506/Pembroke-Welsh-Corgi-standing-outdoors-in-the-fall.jpg");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 11,
                column: "ImgUrl",
                value: "https://k9weightchallenge.com/wp-content/uploads/2015/10/get-your-overweight-dog-jumping-again.jpg");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 13,
                column: "ImgUrl",
                value: "https://thehappypuppysite.com/wp-content/uploads/2017/12/blue-heeler-names.jpg");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 16,
                column: "ImgUrl",
                value: "https://vetstreet-brightspot.s3.amazonaws.com/70/337d20a40111e087a80050568d634f/file/Alaskan-Malamute-2-578mk062311.jpg");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 18,
                column: "ImgUrl",
                value: "https://americanbullydaily.com/wp-content/uploads/2019/10/american-bully-2.jpg");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 19,
                column: "ImgUrl",
                value: "https://cdn.orvis.com/images/DBS_Mastiff_1280.jpg");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 20,
                column: "ImgUrl",
                value: "https://images2.minutemediacdn.com/image/upload/c_fill,g_auto,h_1248,w_2220/f_auto,q_auto,w_1100/v1555378804/shape/mentalfloss/istock_000009655750_small.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 7,
                column: "ImgUrl",
                value: "https://drive.google.com/file/d/1k-XzE-I0BPJK7RCZw0pfzIx0EO30IAEp/view?usp=sharing");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 9,
                column: "ImgUrl",
                value: "https://drive.google.com/file/d/1k-XzE-I0BPJK7RCZw0pfzIx0EO30IAEp/view?usp=sharing");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 11,
                column: "ImgUrl",
                value: "https://drive.google.com/file/d/1tXvfrTFQKgbPZNR8j3pM775CkVYYGs0a/view?usp=sharing");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 13,
                column: "ImgUrl",
                value: "https://drive.google.com/file/d/1tXvfrTFQKgbPZNR8j3pM775CkVYYGs0a/view?usp=sharing");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 16,
                column: "ImgUrl",
                value: "https://drive.google.com/file/d/1tXvfrTFQKgbPZNR8j3pM775CkVYYGs0a/view?usp=sharing");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 18,
                column: "ImgUrl",
                value: "https://drive.google.com/file/d/19tErfDf63pWKfjU3uNoMLP5MC9kmduEh/view?usp=sharing");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 19,
                column: "ImgUrl",
                value: "https://static.wikia.nocookie.net/thesandlot/images/0/04/Index.jpeg/revision/latest/smart/width/200/height/200?cb=20140112221255");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 20,
                column: "ImgUrl",
                value: "https://drive.google.com/file/d/1Wm16DrFK58w2Tdm0zKFbNPl7uxbqILu7/view?usp=sharing");
        }
    }
}
