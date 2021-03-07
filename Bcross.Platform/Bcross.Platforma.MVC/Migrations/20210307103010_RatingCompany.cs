using Microsoft.EntityFrameworkCore.Migrations;

namespace Bcross.Platforma.MVC.Migrations
{
    public partial class RatingCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "rating",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rating",
                table: "Company");
        }
    }
}
