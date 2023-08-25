using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmpregosOnLine.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVaga6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("07438d7f-b9cb-47ca-85e0-4905829955c1"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("11067085-6d6e-4d00-8dde-2b756ab325df"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("30d814a7-4eb7-47f2-89fb-9945cd9705c7"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("877588f3-1139-4449-a600-f69296764518"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("bfdc2399-075b-4cf1-84f9-0da8f7bf06d1"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("088ebcad-1c7d-4e42-89c8-1023ca2b1d6f"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("0d53a4c4-2249-4f11-bc30-9d057a7a4425"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("4ccddc93-c642-41e7-882a-40b1baa6c79b"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("6a86f41d-2c87-44a1-b9ce-21ab545dddf6"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("a470c23f-f362-49e7-b2b7-f15d04324837"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("ba33add8-2546-4a0f-a55a-924504d77da8"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("be86ce07-aab4-4035-9bcf-b78e6fc3b28e"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("dcf98a76-07c5-4b80-83d0-7acf6b9d35f6"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("fea2e35d-e557-44d9-ae2e-bd0532ce528c"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("07438d7f-b9cb-47ca-85e0-4905829955c1"), "Gympass" },
                    { new Guid("11067085-6d6e-4d00-8dde-2b756ab325df"), "Vale alimentação" },
                    { new Guid("30d814a7-4eb7-47f2-89fb-9945cd9705c7"), "Vale refeição" },
                    { new Guid("877588f3-1139-4449-a600-f69296764518"), "Vale combustível" },
                    { new Guid("bfdc2399-075b-4cf1-84f9-0da8f7bf06d1"), "PLR" }
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { new Guid("088ebcad-1c7d-4e42-89c8-1023ca2b1d6f"), "HTML" },
                    { new Guid("0d53a4c4-2249-4f11-bc30-9d057a7a4425"), "JQuery" },
                    { new Guid("4ccddc93-c642-41e7-882a-40b1baa6c79b"), "Entity Framework Core" },
                    { new Guid("6a86f41d-2c87-44a1-b9ce-21ab545dddf6"), "SQL Server" },
                    { new Guid("a470c23f-f362-49e7-b2b7-f15d04324837"), "Bootstrap" },
                    { new Guid("ba33add8-2546-4a0f-a55a-924504d77da8"), "C#" },
                    { new Guid("be86ce07-aab4-4035-9bcf-b78e6fc3b28e"), "Javascript" },
                    { new Guid("dcf98a76-07c5-4b80-83d0-7acf6b9d35f6"), "ASP.NET Core" },
                    { new Guid("fea2e35d-e557-44d9-ae2e-bd0532ce528c"), "CSS" }
                });
        }
    }
}
