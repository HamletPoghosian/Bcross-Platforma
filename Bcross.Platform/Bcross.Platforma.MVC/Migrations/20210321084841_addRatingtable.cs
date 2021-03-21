using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bcross.Platforma.MVC.Migrations
{
    public partial class addRatingtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rating",
                table: "Company");

            migrationBuilder.AddColumn<long>(
                name: "rating_id",
                table: "Company",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    rating_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VotingCount = table.Column<long>(type: "bigint", nullable: false),
                    VotingValue = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.rating_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company_rating_id",
                table: "Company",
                column: "rating_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Rating_rating_id",
                table: "Company",
                column: "rating_id",
                principalTable: "Rating",
                principalColumn: "rating_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Rating_rating_id",
                table: "Company");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_Company_rating_id",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "rating_id",
                table: "Company");

            migrationBuilder.AddColumn<int>(
                name: "rating",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
