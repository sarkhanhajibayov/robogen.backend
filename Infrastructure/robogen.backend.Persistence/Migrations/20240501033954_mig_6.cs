using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace robogen.backend.Persistence.Migrations
{
    public partial class mig_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Details_DetailId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_DetailId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DetailId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DetalId",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DetailId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DetalId",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_DetailId",
                table: "Products",
                column: "DetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Details_DetailId",
                table: "Products",
                column: "DetailId",
                principalTable: "Details",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
