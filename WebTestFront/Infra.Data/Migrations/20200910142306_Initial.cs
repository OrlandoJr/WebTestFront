using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Clientes",
                columns: table => new
                {
                    ClienteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 80, nullable: true),
                    Data_Nascimento = table.Column<DateTime>(nullable: false),
                    RG = table.Column<string>(maxLength: 20, nullable: true),
                    CPF = table.Column<string>(maxLength: 25, nullable: true),
                    Estado_Civil = table.Column<string>(maxLength: 20, nullable: true),
                    Nome_Parceiro = table.Column<string>(maxLength: 80, nullable: true),
                    Data_Nascimento_Parceiro = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Clientes", x => x.ClienteID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Clientes");
        }
    }
}
