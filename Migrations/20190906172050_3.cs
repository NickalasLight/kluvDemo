using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace klovecore2.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_ContactInformation_ContactInformationID",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "ContactInformation");

            migrationBuilder.DropIndex(
                name: "IX_Employee_ContactInformationID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ContactInformationID",
                table: "Employee");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Employee",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "ContactInformationID",
                table: "Employee",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContactInformation",
                columns: table => new
                {
                    ContactInformationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInformation", x => x.ContactInformationID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ContactInformationID",
                table: "Employee",
                column: "ContactInformationID",
                unique: true,
                filter: "[ContactInformationID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_ContactInformation_ContactInformationID",
                table: "Employee",
                column: "ContactInformationID",
                principalTable: "ContactInformation",
                principalColumn: "ContactInformationID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
