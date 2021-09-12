using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FESTA_FACIL.Migrations
{
    public partial class clientemap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alugueis");

            migrationBuilder.AddColumn<string>(
                name: "Contato",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contato",
                table: "Clientes");

            migrationBuilder.CreateTable(
                name: "Alugueis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nomeid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alugueis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Alugueis_Clientes_Nomeid",
                        column: x => x.Nomeid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_Nomeid",
                table: "Alugueis",
                column: "Nomeid");
        }
    }
}
