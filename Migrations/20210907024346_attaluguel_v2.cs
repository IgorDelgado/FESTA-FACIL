using Microsoft.EntityFrameworkCore.Migrations;

namespace FESTA_FACIL.Migrations
{
    public partial class attaluguel_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Temas_DescricaoID",
                table: "Alugueis");

            migrationBuilder.DropIndex(
                name: "IX_Alugueis_DescricaoID",
                table: "Alugueis");

            migrationBuilder.DropColumn(
                name: "DescricaoID",
                table: "Alugueis");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "FK_Alugueis_Temas_DescricaoID",
                table: "Alugueis",
                column: "DescricaoID",
                principalTable: "Temas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
