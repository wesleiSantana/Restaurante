using Microsoft.EntityFrameworkCore.Migrations;

namespace GarcomAnotacoes.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Copas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Copas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cozinhas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cozinhas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(nullable: false),
                    Mesa = table.Column<int>(type: "INT", nullable: false),
                    Prato = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Bebida = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Cliente = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    QtdBebidas = table.Column<int>(name: "Qtd Bebidas", type: "INT", nullable: false),
                    QtdPratos = table.Column<int>(name: "Qtd Pratos", type: "INT", nullable: false),
                    CopaId = table.Column<long>(nullable: false),
                    CozinhaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Copas_CopaId",
                        column: x => x.CopaId,
                        principalTable: "Copas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Cozinhas_CozinhaId",
                        column: x => x.CozinhaId,
                        principalTable: "Cozinhas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_CopaId",
                table: "Pedidos",
                column: "CopaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_CozinhaId",
                table: "Pedidos",
                column: "CozinhaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Copas");

            migrationBuilder.DropTable(
                name: "Cozinhas");
        }
    }
}
