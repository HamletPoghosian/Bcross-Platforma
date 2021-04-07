using Microsoft.EntityFrameworkCore.Migrations;

namespace Bcross.Platforma.MVC.Migrations
{
    public partial class addContracCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "contract_code",
                table: "Contract",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "contract_code",
                table: "Contract");
        }
    }
}
