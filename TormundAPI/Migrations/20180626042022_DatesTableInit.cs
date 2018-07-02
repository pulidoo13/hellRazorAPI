using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TormundAPI.Migrations
{
    public partial class DatesTableInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    BranchId = table.Column<int>(nullable: true),
                    ServiceId = table.Column<int>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true),
                    AppointmentDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<int>(nullable: true),
                    ModifiedById = table.Column<int>(nullable: true),
                    Photo = table.Column<byte[]>(nullable: true),
                    FromApp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dates_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dates_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dates_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dates_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dates_Users_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dates_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dates_BranchId",
                table: "Dates",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_CreatedById",
                table: "Dates",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_CustomerId",
                table: "Dates",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_EmployeeId",
                table: "Dates",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_ModifiedById",
                table: "Dates",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_ServiceId",
                table: "Dates",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dates");
        }
    }
}
