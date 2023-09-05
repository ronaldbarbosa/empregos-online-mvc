using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmpregosOnLine.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmpresa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("2fedaa00-f684-49f7-834b-0a36716f5879"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("4b3be0b2-df90-4c83-aec9-646047e1dad8"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("5d26d188-115a-4a00-adcd-5437ee955e9a"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("6971f74a-2ea9-4546-953e-c095a95b55c8"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("e5890d60-1723-4f37-97d2-e285ea27eaec"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("09e54e2d-e74b-45c6-986d-9241f9e96d66"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("34b5fe23-a463-453d-8e11-bef8348f1633"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("93a70675-9d40-4d9e-b5ba-e149c2d6dc97"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("b396bd5e-af52-42fe-a0b3-3c187957b76f"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("b5b3dfd5-aed5-415d-84b5-38299c6468ac"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("c78a4db7-12d2-40a8-9899-45042823f825"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("d482548c-ea73-4e08-ae48-dfe64ca573f6"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("fb4fb0c1-b3ac-440b-9d97-5060a898a6cb"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("fd09c445-cff7-41bd-8d04-63356c9a64ba"));

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Enderecos",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(11)");

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "Empresas",
                type: "varchar(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AddColumn<string>(
                name: "UrlImagem",
                table: "Empresas",
                type: "varchar(256)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Beneficios",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { new Guid("00ab900b-b5c9-44a0-beb8-5bc2a59e39fc"), "PLR" },
                    { new Guid("66ccf631-2f0a-4ff7-840a-23786911abd2"), "Vale combustível" },
                    { new Guid("6b5baba2-eb9b-41a2-8614-8cdacb4475bc"), "Vale refeição" },
                    { new Guid("9f510dae-1e9a-4ab1-ab2e-8ba7bfe52846"), "Vale alimentação" },
                    { new Guid("e3b8a3ca-3da6-4687-b7c3-df88b20dfce2"), "Gympass" }
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { new Guid("02c6b704-4ce6-40b6-bdb5-ce20a2c135b9"), "Entity Framework Core" },
                    { new Guid("5d32f41d-bc4f-4395-a592-e34942450967"), "JQuery" },
                    { new Guid("645e9077-9e36-48cb-a99a-8a0f4bcaeb96"), "ASP.NET Core" },
                    { new Guid("ae4237f0-093f-4bae-ba9c-82f935d60df8"), "HTML" },
                    { new Guid("bf6a880c-ed8d-408a-ac9d-7d2e1da54ffd"), "SQL Server" },
                    { new Guid("d0d9fe9e-1a9d-4768-8253-187c0871b66a"), "C#" },
                    { new Guid("d46a5eed-3641-4d7b-a101-e5d7d1ccd892"), "Bootstrap" },
                    { new Guid("e0ccf916-1ec3-4b2c-a0e5-1fb590a482b6"), "Javascript" },
                    { new Guid("edfcf480-b98b-4c90-8a4e-1fa59af2f0d0"), "CSS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("00ab900b-b5c9-44a0-beb8-5bc2a59e39fc"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("66ccf631-2f0a-4ff7-840a-23786911abd2"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("6b5baba2-eb9b-41a2-8614-8cdacb4475bc"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("9f510dae-1e9a-4ab1-ab2e-8ba7bfe52846"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("e3b8a3ca-3da6-4687-b7c3-df88b20dfce2"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("02c6b704-4ce6-40b6-bdb5-ce20a2c135b9"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("5d32f41d-bc4f-4395-a592-e34942450967"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("645e9077-9e36-48cb-a99a-8a0f4bcaeb96"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("ae4237f0-093f-4bae-ba9c-82f935d60df8"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("bf6a880c-ed8d-408a-ac9d-7d2e1da54ffd"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("d0d9fe9e-1a9d-4768-8253-187c0871b66a"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("d46a5eed-3641-4d7b-a101-e5d7d1ccd892"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("e0ccf916-1ec3-4b2c-a0e5-1fb590a482b6"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("edfcf480-b98b-4c90-8a4e-1fa59af2f0d0"));

            migrationBuilder.DropColumn(
                name: "UrlImagem",
                table: "Empresas");

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Enderecos",
                type: "varchar(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "Empresas",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(18)",
                oldMaxLength: 18);

            migrationBuilder.InsertData(
                table: "Beneficios",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { new Guid("2fedaa00-f684-49f7-834b-0a36716f5879"), "Vale alimentação" },
                    { new Guid("4b3be0b2-df90-4c83-aec9-646047e1dad8"), "Vale combustível" },
                    { new Guid("5d26d188-115a-4a00-adcd-5437ee955e9a"), "PLR" },
                    { new Guid("6971f74a-2ea9-4546-953e-c095a95b55c8"), "Vale refeição" },
                    { new Guid("e5890d60-1723-4f37-97d2-e285ea27eaec"), "Gympass" }
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { new Guid("09e54e2d-e74b-45c6-986d-9241f9e96d66"), "Javascript" },
                    { new Guid("34b5fe23-a463-453d-8e11-bef8348f1633"), "CSS" },
                    { new Guid("93a70675-9d40-4d9e-b5ba-e149c2d6dc97"), "Bootstrap" },
                    { new Guid("b396bd5e-af52-42fe-a0b3-3c187957b76f"), "HTML" },
                    { new Guid("b5b3dfd5-aed5-415d-84b5-38299c6468ac"), "JQuery" },
                    { new Guid("c78a4db7-12d2-40a8-9899-45042823f825"), "Entity Framework Core" },
                    { new Guid("d482548c-ea73-4e08-ae48-dfe64ca573f6"), "ASP.NET Core" },
                    { new Guid("fb4fb0c1-b3ac-440b-9d97-5060a898a6cb"), "SQL Server" },
                    { new Guid("fd09c445-cff7-41bd-8d04-63356c9a64ba"), "C#" }
                });
        }
    }
}
