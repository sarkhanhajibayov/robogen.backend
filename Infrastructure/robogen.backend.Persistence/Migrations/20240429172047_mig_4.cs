using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace robogen.backend.Persistence.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DetalAmountId",
                table: "Products",
                newName: "DetalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DetalId",
                table: "Products",
                newName: "DetalAmountId");
        }
    }
}
