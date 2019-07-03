using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryAppCoreWeb.Data.Migrations
{
    public partial class SeedMembersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Members (Firstname, Lastname) VALUES ('Anders', 'Andersson')");
            migrationBuilder.Sql("INSERT INTO Members (Firstname, Lastname) VALUES ('Bert', 'Berntsson')");
            migrationBuilder.Sql("INSERT INTO Members (Firstname, Lastname) VALUES ('Carl', 'Carlsson')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
