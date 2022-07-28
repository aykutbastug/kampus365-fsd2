using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    public partial class CreateHarcamaTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Harcamalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubeId = table.Column<int>(type: "int", nullable: true),
                    PersonelId = table.Column<int>(type: "int", nullable: true),
                    FisNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HarcamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harcamalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Harcamalar_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Harcamalar_Subeler_SubeId",
                        column: x => x.SubeId,
                        principalTable: "Subeler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HarcamaDetaylari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HarcamaId = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HarcamaDetaylari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HarcamaDetaylari_Harcamalar_HarcamaId",
                        column: x => x.HarcamaId,
                        principalTable: "Harcamalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HarcamaDetaylari_HarcamaId",
                table: "HarcamaDetaylari",
                column: "HarcamaId");

            migrationBuilder.CreateIndex(
                name: "IX_Harcamalar_PersonelId",
                table: "Harcamalar",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Harcamalar_SubeId",
                table: "Harcamalar",
                column: "SubeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HarcamaDetaylari");

            migrationBuilder.DropTable(
                name: "Harcamalar");
        }
    }
}
