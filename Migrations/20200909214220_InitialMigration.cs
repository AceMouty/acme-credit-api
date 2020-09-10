using Microsoft.EntityFrameworkCore.Migrations;

namespace AcmeApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    applicantName = table.Column<string>(maxLength: 250, nullable: false),
                    applicantPhoneNumber = table.Column<string>(maxLength: 250, nullable: false),
                    applicantEmail = table.Column<string>(maxLength: 250, nullable: false),
                    loanAmount = table.Column<string>(maxLength: 250, nullable: false),
                    loanId = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");
        }
    }
}
