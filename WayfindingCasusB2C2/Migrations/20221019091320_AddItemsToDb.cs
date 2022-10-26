using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WayfindingCasusB2C2.Migrations
{
    public partial class AddItemsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblBedrijfDetail",
                columns: table => new
                {
                    BedrijfDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BedrijfNaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BedrijfEigenaar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BedrijfMedewerkers = table.Column<int>(type: "int", nullable: false),
                    BedrijfDoelen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BedrijfOpgerichtJaar = table.Column<int>(type: "int", nullable: false),
                    BedrijfBeschrijving = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBedrijfDetail", x => x.BedrijfDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "tblLegenda",
                columns: table => new
                {
                    LegendaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LegendaItem = table.Column<int>(type: "int", nullable: false),
                    LegendaBeschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLegenda", x => x.LegendaId);
                });

            migrationBuilder.CreateTable(
                name: "tblRoute",
                columns: table => new
                {
                    RouteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteBeschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocatieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRoute", x => x.RouteId);
                });

            migrationBuilder.CreateTable(
                name: "tblRuimte",
                columns: table => new
                {
                    RuimteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RuimteOppervlakte = table.Column<int>(type: "int", nullable: false),
                    RuimteBezet = table.Column<bool>(type: "bit", nullable: false),
                    RuimteBezoekers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRuimte", x => x.RuimteId);
                });

            migrationBuilder.CreateTable(
                name: "tblBedrijf",
                columns: table => new
                {
                    BedrijfId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BedrijfDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBedrijf", x => x.BedrijfId);
                    table.ForeignKey(
                        name: "FK_tblBedrijf_tblBedrijfDetail_BedrijfDetailId",
                        column: x => x.BedrijfDetailId,
                        principalTable: "tblBedrijfDetail",
                        principalColumn: "BedrijfDetailsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BedrijfRuimte",
                columns: table => new
                {
                    BedrijfsBedrijfId = table.Column<int>(type: "int", nullable: false),
                    RuimtesRuimteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedrijfRuimte", x => new { x.BedrijfsBedrijfId, x.RuimtesRuimteId });
                    table.ForeignKey(
                        name: "FK_BedrijfRuimte_tblBedrijf_BedrijfsBedrijfId",
                        column: x => x.BedrijfsBedrijfId,
                        principalTable: "tblBedrijf",
                        principalColumn: "BedrijfId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BedrijfRuimte_tblRuimte_RuimtesRuimteId",
                        column: x => x.RuimtesRuimteId,
                        principalTable: "tblRuimte",
                        principalColumn: "RuimteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblGebruiker",
                columns: table => new
                {
                    GebruikerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GebruikerNaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BedrijfId = table.Column<int>(type: "int", nullable: true),
                    GebruikerLeeftijd = table.Column<int>(type: "int", nullable: true),
                    GebruikerGeslacht = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GebruikerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RuimteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblGebruiker", x => x.GebruikerId);
                    table.ForeignKey(
                        name: "FK_tblGebruiker_tblBedrijf_BedrijfId",
                        column: x => x.BedrijfId,
                        principalTable: "tblBedrijf",
                        principalColumn: "BedrijfId");
                    table.ForeignKey(
                        name: "FK_tblGebruiker_tblRuimte_RuimteId",
                        column: x => x.RuimteId,
                        principalTable: "tblRuimte",
                        principalColumn: "RuimteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblPlattegrond",
                columns: table => new
                {
                    PlattegrondId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RuimteId = table.Column<int>(type: "int", nullable: false),
                    BedrijfId = table.Column<int>(type: "int", nullable: false),
                    LegendaId = table.Column<int>(type: "int", nullable: false),
                    PlattegrondVerdieping = table.Column<int>(type: "int", nullable: false),
                    RouteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPlattegrond", x => x.PlattegrondId);
                    table.ForeignKey(
                        name: "FK_tblPlattegrond_tblBedrijf_BedrijfId",
                        column: x => x.BedrijfId,
                        principalTable: "tblBedrijf",
                        principalColumn: "BedrijfId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPlattegrond_tblLegenda_LegendaId",
                        column: x => x.LegendaId,
                        principalTable: "tblLegenda",
                        principalColumn: "LegendaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPlattegrond_tblRoute_RouteId",
                        column: x => x.RouteId,
                        principalTable: "tblRoute",
                        principalColumn: "RouteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPlattegrond_tblRuimte_RuimteId",
                        column: x => x.RuimteId,
                        principalTable: "tblRuimte",
                        principalColumn: "RuimteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BedrijfRuimte_RuimtesRuimteId",
                table: "BedrijfRuimte",
                column: "RuimtesRuimteId");

            migrationBuilder.CreateIndex(
                name: "IX_tblBedrijf_BedrijfDetailId",
                table: "tblBedrijf",
                column: "BedrijfDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_tblGebruiker_BedrijfId",
                table: "tblGebruiker",
                column: "BedrijfId");

            migrationBuilder.CreateIndex(
                name: "IX_tblGebruiker_RuimteId",
                table: "tblGebruiker",
                column: "RuimteId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPlattegrond_BedrijfId",
                table: "tblPlattegrond",
                column: "BedrijfId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPlattegrond_LegendaId",
                table: "tblPlattegrond",
                column: "LegendaId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPlattegrond_RouteId",
                table: "tblPlattegrond",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPlattegrond_RuimteId",
                table: "tblPlattegrond",
                column: "RuimteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BedrijfRuimte");

            migrationBuilder.DropTable(
                name: "tblGebruiker");

            migrationBuilder.DropTable(
                name: "tblPlattegrond");

            migrationBuilder.DropTable(
                name: "tblBedrijf");

            migrationBuilder.DropTable(
                name: "tblLegenda");

            migrationBuilder.DropTable(
                name: "tblRoute");

            migrationBuilder.DropTable(
                name: "tblRuimte");

            migrationBuilder.DropTable(
                name: "tblBedrijfDetail");
        }
    }
}
