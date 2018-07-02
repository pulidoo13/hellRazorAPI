using Microsoft.EntityFrameworkCore.Migrations;

namespace TormundAPI.Migrations
{
    public partial class DatesTableInit3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Customer_idId",
                table: "Dates",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Employee_idId",
                table: "Dates",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dates_Customer_idId",
                table: "Dates",
                column: "Customer_idId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_Employee_idId",
                table: "Dates",
                column: "Employee_idId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dates_Customers_Customer_idId",
                table: "Dates",
                column: "Customer_idId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dates_Employees_Employee_idId",
                table: "Dates",
                column: "Employee_idId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dates_Customers_Customer_idId",
                table: "Dates");

            migrationBuilder.DropForeignKey(
                name: "FK_Dates_Employees_Employee_idId",
                table: "Dates");

            migrationBuilder.DropIndex(
                name: "IX_Dates_Customer_idId",
                table: "Dates");

            migrationBuilder.DropIndex(
                name: "IX_Dates_Employee_idId",
                table: "Dates");

            migrationBuilder.DropColumn(
                name: "Customer_idId",
                table: "Dates");

            migrationBuilder.DropColumn(
                name: "Employee_idId",
                table: "Dates");
        }
    }
}
