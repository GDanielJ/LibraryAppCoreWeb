using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryAppCoreWeb.Data.Migrations
{
    public partial class SeedBooksTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Books (Name, ReleaseDate) VALUES ('The Fellowship of the Ring', '1954-07-29 12:00:00')");
            migrationBuilder.Sql("INSERT INTO Books (Name, ReleaseDate) VALUES ('A Game of Thrones', '1996-08-01 12:00:00')");
            migrationBuilder.Sql("INSERT INTO Books (Name, ReleaseDate) VALUES ('The Hunger Games', '2008-09-14 12:00:00')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
