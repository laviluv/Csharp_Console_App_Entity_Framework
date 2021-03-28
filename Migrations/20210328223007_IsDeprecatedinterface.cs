using Microsoft.EntityFrameworkCore.Migrations;

namespace MP_EF_Lavinia_Bleoca.Migrations
{
    public partial class IsDeprecatedinterface : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeprecated",
                table: "DiverseAssets");

            migrationBuilder.DropColumn(
                name: "IsDeprecated",
                table: "Computers");

            migrationBuilder.DropColumn(
                name: "IsDeprecated",
                table: "CellPhones");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeprecated",
                table: "DiverseAssets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeprecated",
                table: "Computers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeprecated",
                table: "CellPhones",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
