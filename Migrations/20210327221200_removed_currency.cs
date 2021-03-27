using Microsoft.EntityFrameworkCore.Migrations;

namespace MP_EF_Lavinia_Bleoca.Migrations
{
    public partial class removed_currency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Offices");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Offices",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
