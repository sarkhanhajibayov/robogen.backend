using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace robogen.backend.Persistence.Migrations
{
    public partial class mig_7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Key",
                table: "Products");
        }
    }
}
