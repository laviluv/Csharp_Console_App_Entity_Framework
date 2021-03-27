using Microsoft.EntityFrameworkCore.Migrations;

namespace MP_EF_Lavinia_Bleoca.Migrations
{
    public partial class resourcetype_def_not_random : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "OtherAssets",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "OtherAssets");
        }
    }
}
