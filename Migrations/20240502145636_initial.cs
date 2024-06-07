using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameForum.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tabela_Jogo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Titulo_Do_Jogo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Desenvolvedora_Do_Jogo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Data_De_Publicação = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Genero_Do_Jogo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Plataforma_Do_Jogo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Jogo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome_De_Usuario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Nick = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Hash_da_senha = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Data_do_registro = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Avalicao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    UserId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    JogoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Classificacao_Do_Jogo = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Conteudo_Da_Avaliacao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Data_Da_Postagem = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Avalicao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tabela_Avalicao_Tabela_Jogo_JogoId",
                        column: x => x.JogoId,
                        principalTable: "Tabela_Jogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tabela_Avalicao_Tabela_Usuarios_UserId",
                        column: x => x.UserId,
                        principalTable: "Tabela_Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tabela_De_Comentarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    UseId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    AvaliationId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    JogoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Texto_Do_Comentario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Data_do_Comentario = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_De_Comentarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tabela_De_Comentarios_Tabela_Avalicao_AvaliationId",
                        column: x => x.AvaliationId,
                        principalTable: "Tabela_Avalicao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tabela_De_Comentarios_Tabela_Jogo_JogoId",
                        column: x => x.JogoId,
                        principalTable: "Tabela_Jogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tabela_De_Comentarios_Tabela_Usuarios_UseId",
                        column: x => x.UseId,
                        principalTable: "Tabela_Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Avalicao_JogoId",
                table: "Tabela_Avalicao",
                column: "JogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Avalicao_UserId",
                table: "Tabela_Avalicao",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_De_Comentarios_AvaliationId",
                table: "Tabela_De_Comentarios",
                column: "AvaliationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_De_Comentarios_JogoId",
                table: "Tabela_De_Comentarios",
                column: "JogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_De_Comentarios_UseId",
                table: "Tabela_De_Comentarios",
                column: "UseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tabela_De_Comentarios");

            migrationBuilder.DropTable(
                name: "Tabela_Avalicao");

            migrationBuilder.DropTable(
                name: "Tabela_Jogo");

            migrationBuilder.DropTable(
                name: "Tabela_Usuarios");
        }
    }
}
