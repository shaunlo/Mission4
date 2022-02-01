using Microsoft.EntityFrameworkCore.Migrations;
//Create a SQLite database using the Model First method that stores the information entered on
//the form.
namespace Mission4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieName = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edit = table.Column<string>(nullable: true),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Edit", "LentTo", "MovieName", "Notes", "Rating" },
                values: new object[] { 1, "Yes", "Shaun", "Wall Street", "This Movie is the best.", "G" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Edit", "LentTo", "MovieName", "Notes", "Rating" },
                values: new object[] { 2, "Yes", "Shaun", "Spriderman: No way home", "This Movie is good.", "PG" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Edit", "LentTo", "MovieName", "Notes", "Rating" },
                values: new object[] { 3, "Yes", "Shaun", "Fat Albert", "This Movie is fine.", "PG" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
