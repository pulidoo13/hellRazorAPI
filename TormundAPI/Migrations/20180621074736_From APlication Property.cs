using Microsoft.EntityFrameworkCore.Migrations;

namespace TormundAPI.Migrations
{
    public partial class FromAPlicationProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FromApplication",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromApplication",
                table: "Users");
        }
    }
}
