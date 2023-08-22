using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmpregosOnLine.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVaga : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("09c6b741-ec14-4300-bf8a-ca56c05bad33"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("3b485b8d-683a-4d3d-95ec-49b5fc9656cf"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("7496bf97-3c09-4309-834b-46141eea3cab"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("8b54e7d8-0a85-439b-ab5e-4b08851c7177"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("c0909915-3a54-4c93-8926-5c75d14a48df"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("3a3de887-e25c-41eb-975c-d1c9b614ab1d"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("9e4acace-c394-42a7-a40a-83aeb4e45abe"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("acfe43e5-8fee-43f0-9e01-f4628a06cdc9"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("ad181f29-1834-495d-ae52-9c95def8e501"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("bfbf24f8-d06d-49cb-aeff-64219430ed45"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("c8bc4505-de2f-4a5b-9eee-c6630c706598"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("e222c60a-731a-4601-9b95-013ce7077e14"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("e403e5d1-0bbb-4a95-b81f-49c9df1d2fa7"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("fb7cccfb-efa9-42d5-bbc8-196ddb0f4ba8"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Beneficios",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { new Guid("09c6b741-ec14-4300-bf8a-ca56c05bad33"), "Vale combustível" },
                    { new Guid("3b485b8d-683a-4d3d-95ec-49b5fc9656cf"), "Gympass" },
                    { new Guid("7496bf97-3c09-4309-834b-46141eea3cab"), "PLR" },
                    { new Guid("8b54e7d8-0a85-439b-ab5e-4b08851c7177"), "Vale refeição" },
                    { new Guid("c0909915-3a54-4c93-8926-5c75d14a48df"), "Vale alimentação" }
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { new Guid("3a3de887-e25c-41eb-975c-d1c9b614ab1d"), "C#" },
                    { new Guid("9e4acace-c394-42a7-a40a-83aeb4e45abe"), "HTML" },
                    { new Guid("acfe43e5-8fee-43f0-9e01-f4628a06cdc9"), "JQuery" },
                    { new Guid("ad181f29-1834-495d-ae52-9c95def8e501"), "ASP.NET Core" },
                    { new Guid("bfbf24f8-d06d-49cb-aeff-64219430ed45"), "CSS" },
                    { new Guid("c8bc4505-de2f-4a5b-9eee-c6630c706598"), "SQL Server" },
                    { new Guid("e222c60a-731a-4601-9b95-013ce7077e14"), "Bootstrap" },
                    { new Guid("e403e5d1-0bbb-4a95-b81f-49c9df1d2fa7"), "Entity Framework Core" },
                    { new Guid("fb7cccfb-efa9-42d5-bbc8-196ddb0f4ba8"), "Javascript" }
                });
        }
    }
}
