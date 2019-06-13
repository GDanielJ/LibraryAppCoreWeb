using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryAppCoreWeb.Data.Migrations
{
    public partial class SeedAuthorsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Authors (Firstname, Lastname) VALUES ('John R.R.', 'Tolkien')");
            migrationBuilder.Sql("INSERT INTO Authors (Firstname, Lastname) VALUES ('George R.R.', 'Martin')");
            migrationBuilder.Sql("INSERT INTO Authors (Firstname, Lastname) VALUES ('Suzanne', 'Collins')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
