using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmpregosOnLine.Migrations
{
    /// <inheritdoc />
    public partial class Teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("140b1bf7-8580-4060-94ac-702bc54f0ff4"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("258ad810-8ae3-4697-baa2-65681f2bf798"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("7d194687-f44b-451c-8cc6-714ab6abc0fd"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("99d6cfb3-2f23-4447-9e62-5f100b5ab6a7"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("ed3abce8-5904-4e57-9ce9-c3d78cfa0688"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("1aaadb63-d5ea-424b-b542-63f4eff64153"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("30595fad-7531-40f1-9542-ec80a57672df"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("3920ec75-7a43-4d41-aee1-858e37d5ca2c"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("b42694af-53c7-4464-9692-29695702480a"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("b689091b-2021-4bc1-8f42-bae29e047388"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("ba7e468e-2fb0-4eaf-829d-6042a0ed83f7"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("cca7023c-f34d-43cc-b86f-0f96b7ffa074"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("d0e8d437-3bc7-4cef-b3d0-380a12abea3b"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("f5144710-e41f-445a-bd78-b6b1957d100e"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Beneficios",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { new Guid("140b1bf7-8580-4060-94ac-702bc54f0ff4"), "Vale combustível" },
                    { new Guid("258ad810-8ae3-4697-baa2-65681f2bf798"), "Vale alimentação" },
                    { new Guid("7d194687-f44b-451c-8cc6-714ab6abc0fd"), "Vale refeição" },
                    { new Guid("99d6cfb3-2f23-4447-9e62-5f100b5ab6a7"), "PLR" },
                    { new Guid("ed3abce8-5904-4e57-9ce9-c3d78cfa0688"), "Gympass" }
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { new Guid("1aaadb63-d5ea-424b-b542-63f4eff64153"), "C#" },
                    { new Guid("30595fad-7531-40f1-9542-ec80a57672df"), "Javascript" },
                    { new Guid("3920ec75-7a43-4d41-aee1-858e37d5ca2c"), "ASP.NET Core" },
                    { new Guid("b42694af-53c7-4464-9692-29695702480a"), "SQL Server" },
                    { new Guid("b689091b-2021-4bc1-8f42-bae29e047388"), "CSS" },
                    { new Guid("ba7e468e-2fb0-4eaf-829d-6042a0ed83f7"), "JQuery" },
                    { new Guid("cca7023c-f34d-43cc-b86f-0f96b7ffa074"), "HTML" },
                    { new Guid("d0e8d437-3bc7-4cef-b3d0-380a12abea3b"), "Bootstrap" },
                    { new Guid("f5144710-e41f-445a-bd78-b6b1957d100e"), "Entity Framework Core" }
                });
        }
    }
}
