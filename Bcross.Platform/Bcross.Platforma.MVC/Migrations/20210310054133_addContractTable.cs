using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bcross.Platforma.MVC.Migrations
{
    public partial class addContractTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    first_company_id = table.Column<long>(type: "bigint", nullable: false),
                    second_company_id = table.Column<long>(type: "bigint", nullable: false),
                    start_day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    finish_day = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contract");
        }
    }
}
