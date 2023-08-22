using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmpregosOnLine.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVaga2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beneficios_Vagas_VagaId",
                table: "Beneficios");

            migrationBuilder.DropForeignKey(
                name: "FK_Habilidades_Vagas_VagaId",
                table: "Habilidades");

            migrationBuilder.DropIndex(
                name: "IX_Habilidades_VagaId",
                table: "Habilidades");

            migrationBuilder.DropIndex(
                name: "IX_Beneficios_VagaId",
                table: "Beneficios");

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("0a961325-0d30-4a72-b80e-7fd746def17d"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("361e96af-7b01-40f1-81c5-3ba77ea9e2a3"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("6c5164ba-7d80-48fd-ad84-c397ded87d43"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("b699014f-0e90-4fe7-be1b-78f629899861"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("fd07bde8-2233-4f93-96b4-d5d79edcadfe"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("23483a88-8f96-4a92-95cc-4340e76b74c7"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("569efbed-3243-40c5-9d47-a5f0ae7f8d35"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("56aa90b4-6c2d-48ce-99a5-369dfc310403"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("5a0ec37d-cd4b-4a5c-9d32-67f50e824c41"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("67264dd3-b5d3-4c9d-8dfb-037a877c9790"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("7edd7bee-317d-4dad-802a-745760cf74c4"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("a82b7c60-3962-4969-a956-f4616b16cf18"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("c7581993-0a2e-45c0-b22d-a31339d91f3f"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("e12151a0-2d42-4f20-b864-cfb2c6075cf6"));

            migrationBuilder.DropColumn(
                name: "VagaId",
                table: "Habilidades");

            migrationBuilder.DropColumn(
                name: "VagaId",
                table: "Beneficios");

            migrationBuilder.CreateTable(
                name: "VagaBeneficio",
                columns: table => new
                {
                    BeneficiosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VagasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VagaBeneficio", x => new { x.BeneficiosId, x.VagasId });
                    table.ForeignKey(
                        name: "FK_VagaBeneficio_Beneficios_BeneficiosId",
                        column: x => x.BeneficiosId,
                        principalTable: "Beneficios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VagaBeneficio_Vagas_VagasId",
                        column: x => x.VagasId,
                        principalTable: "Vagas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VagaHabilidade",
                columns: table => new
                {
                    HabilidadesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VagasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VagaHabilidade", x => new { x.HabilidadesId, x.VagasId });
                    table.ForeignKey(
                        name: "FK_VagaHabilidade_Habilidades_HabilidadesId",
                        column: x => x.HabilidadesId,
                        principalTable: "Habilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VagaHabilidade_Vagas_VagasId",
                        column: x => x.VagasId,
                        principalTable: "Vagas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Beneficios",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { new Guid("11261f3d-2359-4f79-97f3-cb4480e3b65f"), "PLR" },
                    { new Guid("2bb69d8e-4b67-4a60-8de9-a87e47d2fdd8"), "Vale alimentação" },
                    { new Guid("85dd64fd-b5f5-46e2-816a-4e0dfeaaee75"), "Vale combustível" },
                    { new Guid("bb18fc12-a597-447e-8bd3-a06f678c2d6e"), "Gympass" },
                    { new Guid("d57b1067-e36b-4726-9857-c0e3b38fa175"), "Vale refeição" }
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { new Guid("2d9bd290-e5d3-4c4f-967e-dc177539fc95"), "SQL Server" },
                    { new Guid("63bf0858-873a-4714-92f2-14a623bbc468"), "C#" },
                    { new Guid("85c53f7d-fda6-4e15-a6f7-bea08df715c9"), "HTML" },
                    { new Guid("98b1621e-5262-46de-9d7f-b65b0a6590ce"), "Javascript" },
                    { new Guid("aea28668-3dd7-4472-87bd-50f9223078c0"), "ASP.NET Core" },
                    { new Guid("c826968f-e5f5-48e7-a187-8b4f06fa4ce7"), "JQuery" },
                    { new Guid("e7ba1bf8-33f9-4714-9778-759106df3fd5"), "Bootstrap" },
                    { new Guid("e916718e-5f38-4e13-8589-acb43c9b80e9"), "Entity Framework Core" },
                    { new Guid("f3de2c30-2200-4ce2-b16a-484d173a1128"), "CSS" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VagaBeneficio_VagasId",
                table: "VagaBeneficio",
                column: "VagasId");

            migrationBuilder.CreateIndex(
                name: "IX_VagaHabilidade_VagasId",
                table: "VagaHabilidade",
                column: "VagasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VagaBeneficio");

            migrationBuilder.DropTable(
                name: "VagaHabilidade");

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("11261f3d-2359-4f79-97f3-cb4480e3b65f"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("2bb69d8e-4b67-4a60-8de9-a87e47d2fdd8"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("85dd64fd-b5f5-46e2-816a-4e0dfeaaee75"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("bb18fc12-a597-447e-8bd3-a06f678c2d6e"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("d57b1067-e36b-4726-9857-c0e3b38fa175"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("2d9bd290-e5d3-4c4f-967e-dc177539fc95"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("63bf0858-873a-4714-92f2-14a623bbc468"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("85c53f7d-fda6-4e15-a6f7-bea08df715c9"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("98b1621e-5262-46de-9d7f-b65b0a6590ce"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("aea28668-3dd7-4472-87bd-50f9223078c0"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("c826968f-e5f5-48e7-a187-8b4f06fa4ce7"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("e7ba1bf8-33f9-4714-9778-759106df3fd5"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("e916718e-5f38-4e13-8589-acb43c9b80e9"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("f3de2c30-2200-4ce2-b16a-484d173a1128"));

            migrationBuilder.AddColumn<Guid>(
                name: "VagaId",
                table: "Habilidades",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "VagaId",
                table: "Beneficios",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Beneficios",
                columns: new[] { "Id", "Titulo", "VagaId" },
                values: new object[,]
                {
                    { new Guid("0a961325-0d30-4a72-b80e-7fd746def17d"), "Gympass", null },
                    { new Guid("361e96af-7b01-40f1-81c5-3ba77ea9e2a3"), "Vale alimentação", null },
                    { new Guid("6c5164ba-7d80-48fd-ad84-c397ded87d43"), "Vale refeição", null },
                    { new Guid("b699014f-0e90-4fe7-be1b-78f629899861"), "Vale combustível", null },
                    { new Guid("fd07bde8-2233-4f93-96b4-d5d79edcadfe"), "PLR", null }
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Titulo", "VagaId" },
                values: new object[,]
                {
                    { new Guid("23483a88-8f96-4a92-95cc-4340e76b74c7"), "HTML", null },
                    { new Guid("569efbed-3243-40c5-9d47-a5f0ae7f8d35"), "ASP.NET Core", null },
                    { new Guid("56aa90b4-6c2d-48ce-99a5-369dfc310403"), "Entity Framework Core", null },
                    { new Guid("5a0ec37d-cd4b-4a5c-9d32-67f50e824c41"), "SQL Server", null },
                    { new Guid("67264dd3-b5d3-4c9d-8dfb-037a877c9790"), "JQuery", null },
                    { new Guid("7edd7bee-317d-4dad-802a-745760cf74c4"), "Bootstrap", null },
                    { new Guid("a82b7c60-3962-4969-a956-f4616b16cf18"), "Javascript", null },
                    { new Guid("c7581993-0a2e-45c0-b22d-a31339d91f3f"), "C#", null },
                    { new Guid("e12151a0-2d42-4f20-b864-cfb2c6075cf6"), "CSS", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Habilidades_VagaId",
                table: "Habilidades",
                column: "VagaId");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficios_VagaId",
                table: "Beneficios",
                column: "VagaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beneficios_Vagas_VagaId",
                table: "Beneficios",
                column: "VagaId",
                principalTable: "Vagas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Habilidades_Vagas_VagaId",
                table: "Habilidades",
                column: "VagaId",
                principalTable: "Vagas",
                principalColumn: "Id");
        }
    }
}
