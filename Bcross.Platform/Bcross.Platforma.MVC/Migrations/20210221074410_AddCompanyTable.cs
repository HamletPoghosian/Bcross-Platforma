using Microsoft.EntityFrameworkCore.Migrations;

namespace Bcross.Platforma.MVC.Migrations
{
    public partial class AddCompanyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address_line = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    registration_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    logo_url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
