using Microsoft.EntityFrameworkCore.Migrations;

namespace PuppyLove.Migrations
{
    public partial class AddIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2);

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

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Dogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User",
                table: "Dogs");

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "ImgUrl", "Location", "Mood", "Name", "OwnerName", "Size" },
                values: new object[,]
                {
                    { 1, 8, "Mixed", "https://i.imgur.com/LS0jkba.jpg", "Portland, OR", "Upbeat and calm", "Helo", "Dave", "Medium" },
                    { 18, 5, "Pitbull", "https://americanbullydaily.com/wp-content/uploads/2019/10/american-bully-2.jpg", "Canby, OR", "Tough but fair", "Rex", "Dan", "Large" },
                    { 17, 2, "Sharpei", "https://www.harlingenveterinaryclinic.com/sites/default/files/styles/large/adaptive-image/public/chinese-sharpei-dog-breed-info.jpg?itok=JdtP42OT", "Seattle, WA", "Tired", "Opus", "Steve", "Medium" },
                    { 16, 9, "Malamute", "https://vetstreet-brightspot.s3.amazonaws.com/70/337d20a40111e087a80050568d634f/file/Alaskan-Malamute-2-578mk062311.jpg", "Hood River, OR", "Slightly disgruntled, but with a heart of gold", "Kiva", "Sarah", "Large" },
                    { 15, 7, "Shiba Inu", "https://i.redd.it/7ifskt9t65mz.png", "Osaka, Japan", "Felt cute, might delete later", "Charmy", "Retsuko", "Small" },
                    { 14, 4, "Boston Terrier", "https://pbs.twimg.com/media/EY-liJOXsAI30hz.jpg", "Atlanta, GA", "Tired of your crap", "Scabigal", "Elizabeth", "Small" },
                    { 13, 4, "Blue Heeler", "https://thehappypuppysite.com/wp-content/uploads/2017/12/blue-heeler-names.jpg", "Tacoma, WA", "PURE ENERGY", "Rexington", "Jim", "Medium" },
                    { 12, 7, "Labrador", "https://cms-tc.pbskids.org/global/show-icons/circle/Clifford_200x200_white.png?mtime=20191120142954", "Portland, OR", "Friendly, knowledgable about all things", "Clifford", "Emily", "Giant" },
                    { 11, 5, "Bernese Mountain Dog", "https://k9weightchallenge.com/wp-content/uploads/2015/10/get-your-overweight-dog-jumping-again.jpg", "Portland, OR", "All goofy, all the goofy", "Doug", "Julie", "Huge" },
                    { 10, 3, "German Sheppard", "https://i.imgur.com/Nh3fQoX.jpg", "Seattle, WA", "Anxious sweet boi", "Link", "Kris", "Big" },
                    { 9, 1, "Corgi", "https://s3.amazonaws.com/cdn-origin-etr.akc.org/wp-content/uploads/2017/11/14112506/Pembroke-Welsh-Corgi-standing-outdoors-in-the-fall.jpg", "Portland, OR", "High energy joy", "Opal", "Sarah", "small" },
                    { 8, 11, "Chihuaua", "https://i.imgur.com/BgUMDya.jpg", "Portland, OR", "Sassy princess", "Truvie", "Luke", "Tiny" },
                    { 7, 13, "Belgian Shepard", "https://i.pinimg.com/originals/4d/96/6e/4d966ead8837ef9d72d1f1c01fe1b53f.jpg", "Portland, OR", "Adorable old man", "Jasper", "Erin", "Large" },
                    { 6, 12, "Irish Setter", "https://i.imgur.com/Gwno8aA.jpg", "Portland, OR", "Loveable dunderhead", "Neville", "Travis", "Large" },
                    { 5, 2, "Great Pyrenees ", "https://i.imgur.com/CdRyiIR.jpg", "Portland, OR", "Sweethearted goofus", "Remy", "Marci", "Big" },
                    { 4, 2, "Mized", "https://www.northerncaliforniapomskies.com/uploads/3/0/8/6/30869529/editor/19665518-1877651202487939-8847474768448559934-n.jpg?1507766002", "Seattle, WA", "Hyper and wild", "Jeans", "Heather", "Medium" },
                    { 3, 1, "Husky", "https://i.imgur.com/Mz05tCi.jpg", "Portland, OR", "Inquisitive, playful", "Fin", "Jerrod", "Small" },
                    { 2, 2, "Mixed", "https://i.imgur.com/0rnaPDz.jpg", "Portland, OR", "Snarky", "Bartleby", "Sage", "Small" },
                    { 19, 5, "Mastiff", "https://cdn.orvis.com/images/DBS_Mastiff_1280.jpg", "Los Angeles, CA", "Slobbery", "Hercules", "Earl", "XXL" },
                    { 20, 6, "Golden Retriever", "https://images2.minutemediacdn.com/image/upload/c_fill,g_auto,h_1248,w_2220/f_auto,q_auto,w_1100/v1555378804/shape/mentalfloss/istock_000009655750_small.jpg", "Vancouver, WA", "Content with life", "Fido", "Robert", "Medium" }
                });
        }
    }
}
