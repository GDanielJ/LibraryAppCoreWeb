using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryAppCoreWeb.Data.Migrations
{
    public partial class SeedLoansAndLoanBooksTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Loans (MemberId, CheckOutDate, DueDate) VALUES (1, '2019-07-01 12:00:00', '2019-07-30 12:00:00')");
            migrationBuilder.Sql("INSERT INTO Loans (MemberId, CheckOutDate, DueDate) VALUES (2, '2019-06-01 12:00:00', '2019-06-30 12:00:00')");
            migrationBuilder.Sql("INSERT INTO LoanBook (LoanId, BookId) VALUES (1, 1)");
            migrationBuilder.Sql("INSERT INTO LoanBook (LoanId, BookId) VALUES (1, 2)");
            migrationBuilder.Sql("INSERT INTO LoanBook (LoanId, BookId) VALUES (2, 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
