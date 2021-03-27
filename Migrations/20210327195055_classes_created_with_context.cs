using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MP_EF_Lavinia_Bleoca.Migrations
{
    public partial class classes_created_with_context : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CellPhones",
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
                    table.PrimaryKey("PK_CellPhones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CellPhones_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Computers",
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
                    table.PrimaryKey("PK_Computers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Computers_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OtherAssets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeId = table.Column<int>(type: "int", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purchased = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeprecated = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherAssets_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CellPhones_OfficeId",
                table: "CellPhones",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_OfficeId",
                table: "Computers",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherAssets_OfficeId",
                table: "OtherAssets",
                column: "OfficeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CellPhones");

            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "OtherAssets");

            migrationBuilder.DropTable(
                name: "Offices");
        }
    }
}
