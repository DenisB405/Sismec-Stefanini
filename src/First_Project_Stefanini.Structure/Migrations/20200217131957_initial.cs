using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace First_Project_Stefanini.Structure.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_instituicao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    DataLog = table.Column<DateTime>(nullable: false),
                    Usuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_instituicao", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_instituicao");
        }
    }
}
