using Microsoft.EntityFrameworkCore.Migrations;

namespace PuppyLove.Migrations
{
    public partial class MoreDogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "ImgUrl", "Location", "Mood", "Name", "OwnerName", "Size" },
                values: new object[,]
                {
                    { 3, 1, "Husky", "https://share.icloud.com/photos/0mxrEdflh8fSsVDXz6QaL5X-A#Oak_Hills", "Portland, OR", "Inquisitive, playful", "Fin", "Jerrod", "Small" },
                    { 4, 2, "Mized", "", "Seattle, WA", "Hyper and wild", "Jeans", "Heather", "Medium" },
                    { 5, 2, "Great Pyrenees ", "https://photos.app.goo.gl/H8VkzPHeg1M6oWa38", "Portland, OR", "Sweethearted goofus", "Remy", "Marci", "Big" },
                    { 6, 12, "Irish Setter", "https://photos.app.goo.gl/AqDXPTwJBJTzQP2s7", "Portland, OR", "Loveable dunderhead", "Neville", "Travis", "Large" },
                    { 7, 13, "Belgian Shepard", "https://drive.google.com/file/d/1k-XzE-I0BPJK7RCZw0pfzIx0EO30IAEp/view?usp=sharing", "Portland, OR", "Adorable old man", "Jasper", "Erin", "Large" },
                    { 8, 11, "Chihuaua", "https://photos.app.goo.gl/iBdKw2wsPtGdJjSL7", "Portland, OR", "Sassy princess", "Truvie", "Luke", "Tiny" },
                    { 9, 1, "Corgi", "https://drive.google.com/file/d/1k-XzE-I0BPJK7RCZw0pfzIx0EO30IAEp/view?usp=sharing", "Portland, OR", "High energy joy", "Opal", "Sarah", "small" },
                    { 10, 3, "German Sheppard", "https://photos.app.goo.gl/FbVEStTT3a198rua6", "Seaettle, WA", "Anxious sweet boi", "Link", "Kris", "Big" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 10);
        }
    }
}
