using Microsoft.EntityFrameworkCore.Migrations;

namespace AcmeApi.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "applicantEmail", "applicantName", "applicantPhoneNumber", "loanAmount", "loanId" },
                values: new object[] { 1, "JohnDoe@gmail.com", "John Doe", "000-867-5309", "34,000.00", "924e075f-4058-49fb-98f4-11283a1c2ad2" });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "applicantEmail", "applicantName", "applicantPhoneNumber", "loanAmount", "loanId" },
                values: new object[] { 2, "JaneDoe@gmail.com", "Jane Doe", "000-867-5310", "80,000.00", "0d7f34f6-f9ef-4077-b1f1-925a7a0bc884" });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "applicantEmail", "applicantName", "applicantPhoneNumber", "loanAmount", "loanId" },
                values: new object[] { 3, "JimmyDoe@gmail.com", "Jimmy Doe", "000-867-5311", "200.00", "71da68a7-c1e4-4497-9fb4-29b2bd8acfca" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
