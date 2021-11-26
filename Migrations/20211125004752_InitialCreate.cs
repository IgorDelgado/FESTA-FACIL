using Microsoft.EntityFrameworkCore.Migrations;

namespace FESTA_FACIL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    municipio = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    idade = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    cpf = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    Contato = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Kits",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Painel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mesa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cilindros = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kits", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Mobilias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobilias", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Temas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTema = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitsID = table.Column<int>(type: "int", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobiliaID = table.Column<int>(type: "int", nullable: true),
                    NumItens = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Temas_Kits_KitsID",
                        column: x => x.KitsID,
                        principalTable: "Kits",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Temas_Mobilias_MobiliaID",
                        column: x => x.MobiliaID,
                        principalTable: "Mobilias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Temas_KitsID",
                table: "Temas",
                column: "KitsID");

            migrationBuilder.CreateIndex(
                name: "IX_Temas_MobiliaID",
                table: "Temas",
                column: "MobiliaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Temas");

            migrationBuilder.DropTable(
                name: "Kits");

            migrationBuilder.DropTable(
                name: "Mobilias");
        }
    }
}
