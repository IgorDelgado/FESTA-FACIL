using Microsoft.EntityFrameworkCore.Migrations;

namespace FESTA_FACIL.Migrations
{
    public partial class attaluguel_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Kits_descricaoID",
                table: "Alugueis");

            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Temas_DescricaoID",
                table: "Alugueis");

            migrationBuilder.DropIndex(
                name: "IX_Alugueis_DescricaoID",
                table: "Alugueis");

            migrationBuilder.DropColumn(
                name: "DescricaoID",
                table: "Alugueis");

            migrationBuilder.RenameColumn(
                name: "descricaoID",
                table: "Alugueis",
                newName: "DescricaoID");

            migrationBuilder.RenameIndex(
                name: "IX_Alugueis_descricaoID",
                table: "Alugueis",
                newName: "IX_Alugueis_DescricaoID");

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
                name: "FK_Alugueis_Temas_DescricaoID",
                table: "Alugueis");

            migrationBuilder.RenameColumn(
                name: "DescricaoID",
                table: "Alugueis",
                newName: "descricaoID");

            migrationBuilder.RenameIndex(
                name: "IX_Alugueis_DescricaoID",
                table: "Alugueis",
                newName: "IX_Alugueis_descricaoID");

            migrationBuilder.AddColumn<int>(
                name: "DescricaoID",
                table: "Alugueis",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_DescricaoID",
                table: "Alugueis",
                column: "DescricaoID");

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
    }
}
