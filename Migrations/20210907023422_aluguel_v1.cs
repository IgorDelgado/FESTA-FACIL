using Microsoft.EntityFrameworkCore.Migrations;

namespace FESTA_FACIL.Migrations
{
    public partial class aluguel_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DescricaoID",
                table: "Alugueis",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Nomeid",
                table: "Alugueis",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "descricaoID",
                table: "Alugueis",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_descricaoID",
                table: "Alugueis",
                column: "descricaoID");

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_DescricaoID",
                table: "Alugueis",
                column: "DescricaoID");

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_Nomeid",
                table: "Alugueis",
                column: "Nomeid");

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Clientes_Nomeid",
                table: "Alugueis",
                column: "Nomeid",
                principalTable: "Clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Kits_descricaoID",
                table: "Alugueis",
                column: "descricaoID",
                principalTable: "Kits",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Temas_DescricaoID",
                table: "Alugueis",
                column: "DescricaoID",
                principalTable: "Temas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Clientes_Nomeid",
                table: "Alugueis");

            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Kits_descricaoID",
                table: "Alugueis");

            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Temas_DescricaoID",
                table: "Alugueis");

            migrationBuilder.DropIndex(
                name: "IX_Alugueis_descricaoID",
                table: "Alugueis");

            migrationBuilder.DropIndex(
                name: "IX_Alugueis_DescricaoID",
                table: "Alugueis");

            migrationBuilder.DropIndex(
                name: "IX_Alugueis_Nomeid",
                table: "Alugueis");

            migrationBuilder.DropColumn(
                name: "DescricaoID",
                table: "Alugueis");

            migrationBuilder.DropColumn(
                name: "Nomeid",
                table: "Alugueis");

            migrationBuilder.DropColumn(
                name: "descricaoID",
                table: "Alugueis");
        }
    }
}
