using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Open = table.Column<double>(type: "float", nullable: false),
                    Close = table.Column<double>(type: "float", nullable: false),
                    High = table.Column<double>(type: "float", nullable: false),
                    Low = table.Column<double>(type: "float", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeFrame = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pivots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeFrame = table.Column<int>(type: "int", nullable: false),
                    HasTP = table.Column<bool>(type: "bit", nullable: true),
                    OriginCandleId = table.Column<int>(type: "int", nullable: false),
                    CoverCandleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pivots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pivots_Candles_CoverCandleId",
                        column: x => x.CoverCandleId,
                        principalTable: "Candles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pivots_Candles_OriginCandleId",
                        column: x => x.OriginCandleId,
                        principalTable: "Candles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pivots_CoverCandleId",
                table: "Pivots",
                column: "CoverCandleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pivots_OriginCandleId",
                table: "Pivots",
                column: "OriginCandleId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pivots");

            migrationBuilder.DropTable(
                name: "Candles");
        }
    }
}
