using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TormundAPI.Migrations
{
    public partial class ImageBranch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Branches",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Branches");
        }
    }
}
