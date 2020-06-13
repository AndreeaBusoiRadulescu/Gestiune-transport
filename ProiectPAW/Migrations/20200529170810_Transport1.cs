using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectPAW.Migrations
{
    public partial class Transport1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Masini",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Denumire = table.Column<string>(nullable: true),
                    NumarMasina = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masini", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Soferi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeSofer = table.Column<string>(nullable: true),
                    DataAngajare = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soferi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transporturi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MasinaId = table.Column<int>(nullable: true),
                    SoferId = table.Column<int>(nullable: true),
                    DenumireIncarcatura = table.Column<string>(nullable: true),
                    Oras = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transporturi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transporturi_Masini_MasinaId",
                        column: x => x.MasinaId,
                        principalTable: "Masini",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transporturi_Soferi_SoferId",
                        column: x => x.SoferId,
                        principalTable: "Soferi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transporturi_MasinaId",
                table: "Transporturi",
                column: "MasinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transporturi_SoferId",
                table: "Transporturi",
                column: "SoferId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transporturi");

            migrationBuilder.DropTable(
                name: "Masini");

            migrationBuilder.DropTable(
                name: "Soferi");
        }
    }
}
