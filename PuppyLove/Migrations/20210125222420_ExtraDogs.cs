using Microsoft.EntityFrameworkCore.Migrations;

namespace PuppyLove.Migrations
{
    public partial class ExtraDogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 10,
                column: "ImgUrl",
                value: "https://photos.google.com/share/AF1QipO5bGGUBOQx4txM8mzBV6CmO3XkdENz9JqiT9dcojGbZfvNm5EMeg72xS4xp9WVsQ/photo/AF1QipPr5iK36GruNOlXCycwJGYEO4_PglYjIDSj6kaQ?key=bzBjOTQ4dDdQMHhkREhJamRUcktNMXBDM213bFB3");

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "ImgUrl", "Location", "Mood", "Name", "OwnerName", "Size" },
                values: new object[,]
                {
                    { 11, 5, "Bernese Mountain Dog", "https://drive.google.com/file/d/1tXvfrTFQKgbPZNR8j3pM775CkVYYGs0a/view?usp=sharing", "Portland, OR", "All goofy, all the goofy", "Doug", "Julie", "Huge" },
                    { 12, 7, "Labrador", "https://cms-tc.pbskids.org/global/show-icons/circle/Clifford_200x200_white.png?mtime=20191120142954", "Portland, OR", "Friendly, knowledgable about all things", "Clifford", "Emily", "Giant" },
                    { 13, 4, "Blue Heeler", "https://drive.google.com/file/d/1tXvfrTFQKgbPZNR8j3pM775CkVYYGs0a/view?usp=sharing", "Tacoma, WA", "PURE ENERGY", "Rexington", "Jim", "Medium" },
                    { 14, 4, "Boston Terrier", "https://pbs.twimg.com/media/EY-liJOXsAI30hz.jpg", "Atlanta, GA", "Tired of your crap", "Scabigal", "Elizabeth", "Small" },
                    { 15, 7, "Shiba Inu", "https://i.redd.it/7ifskt9t65mz.png", "Osaka, Japan", "Felt cute, might delete later", "Charmy", "Retsuko", "Small" },
                    { 16, 9, "Malamute", "https://drive.google.com/file/d/1tXvfrTFQKgbPZNR8j3pM775CkVYYGs0a/view?usp=sharing", "Hood River, OR", "Slightly disgruntled, but with a heart of gold", "Kiva", "Sarah", "Large" },
                    { 17, 2, "Sharpei", "https://www.harlingenveterinaryclinic.com/sites/default/files/styles/large/adaptive-image/public/chinese-sharpei-dog-breed-info.jpg?itok=JdtP42OT", "Seattle, WA", "Tired", "Opus", "Steve", "Medium" },
                    { 18, 5, "Pitbull", "https://drive.google.com/file/d/19tErfDf63pWKfjU3uNoMLP5MC9kmduEh/view?usp=sharing", "Canby, OR", "Tough but fair", "Rex", "Dan", "Large" },
                    { 19, 5, "Mastiff", "https://static.wikia.nocookie.net/thesandlot/images/0/04/Index.jpeg/revision/latest/smart/width/200/height/200?cb=20140112221255", "Los Angeles, CA", "Slobbery", "Hercules", "Earl", "XXL" },
                    { 20, 6, "Golden Retriever", "https://drive.google.com/file/d/1Wm16DrFK58w2Tdm0zKFbNPl7uxbqILu7/view?usp=sharing", "Vancouver, WA", "Content with life", "Fido", "Robert", "Medium" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 10,
                column: "ImgUrl",
                value: "https://photos.app.goo.gl/FbVEStTT3a198rua6");
        }
    }
}
