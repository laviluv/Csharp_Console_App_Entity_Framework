using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MP_EF_Lavinia_Bleoca.Migrations
{
    public partial class testingdiverseassets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiverseAssets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeId = table.Column<int>(type: "int", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purchased = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeprecated = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiverseAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiverseAssets_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiverseAssets_OfficeId",
                table: "DiverseAssets",
                column: "OfficeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiverseAssets");
        }
    }
}
