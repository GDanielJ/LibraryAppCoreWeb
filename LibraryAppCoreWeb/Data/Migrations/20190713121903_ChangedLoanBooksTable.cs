using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryAppCoreWeb.Data.Migrations
{
    public partial class ChangedLoanBooksTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanBook_Books_BookId",
                table: "LoanBook");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanBook_Loans_LoanId",
                table: "LoanBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoanBook",
                table: "LoanBook");

            migrationBuilder.RenameTable(
                name: "LoanBook",
                newName: "LoanBooks");

            migrationBuilder.RenameIndex(
                name: "IX_LoanBook_BookId",
                table: "LoanBooks",
                newName: "IX_LoanBooks_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoanBooks",
                table: "LoanBooks",
                columns: new[] { "LoanId", "BookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_LoanBooks_Books_BookId",
                table: "LoanBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanBooks_Loans_LoanId",
                table: "LoanBooks",
                column: "LoanId",
                principalTable: "Loans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanBooks_Books_BookId",
                table: "LoanBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanBooks_Loans_LoanId",
                table: "LoanBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoanBooks",
                table: "LoanBooks");

            migrationBuilder.RenameTable(
                name: "LoanBooks",
                newName: "LoanBook");

            migrationBuilder.RenameIndex(
                name: "IX_LoanBooks_BookId",
                table: "LoanBook",
                newName: "IX_LoanBook_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoanBook",
                table: "LoanBook",
                columns: new[] { "LoanId", "BookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_LoanBook_Books_BookId",
                table: "LoanBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanBook_Loans_LoanId",
                table: "LoanBook",
                column: "LoanId",
                principalTable: "Loans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
