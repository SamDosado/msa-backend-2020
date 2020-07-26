using Microsoft.EntityFrameworkCore.Migrations;

namespace Phase_1_Backend.Migrations
{
    public partial class UpdatedAddresses2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "addressType",
                table: "Address",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "addressType",
                table: "Address");
        }
    }
}
