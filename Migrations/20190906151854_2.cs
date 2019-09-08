using Microsoft.EntityFrameworkCore.Migrations;

namespace klovecore2.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employee_ContactInformationID",
                table: "Employee");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ContactInformationID",
                table: "Employee",
                column: "ContactInformationID",
                unique: true,
                filter: "[ContactInformationID] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employee_ContactInformationID",
                table: "Employee");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ContactInformationID",
                table: "Employee",
                column: "ContactInformationID");
        }
    }
}
