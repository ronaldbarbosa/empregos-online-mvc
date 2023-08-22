using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmpregosOnLine.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVaga3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "TipoContrato",
                table: "Vagas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Beneficios",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { new Guid("11433974-5b0e-4d63-8d53-ea512bde69bc"), "PLR" },
                    { new Guid("864ecc44-fac4-433a-899b-30cc56d27dd7"), "Vale combustível" },
                    { new Guid("ab9e4511-0845-42ae-9813-faeb3f4b0634"), "Vale alimentação" },
                    { new Guid("bb37ed84-9579-4210-a47f-25f21ea226ed"), "Vale refeição" },
                    { new Guid("d7d4cab0-91fd-4c6f-bbc1-cb7a140b82a2"), "Gympass" }
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { new Guid("13477a0d-eed0-4260-b4a0-8ae054432cde"), "Entity Framework Core" },
                    { new Guid("3039d7f3-0aac-4d2f-a132-18f4b592f261"), "C#" },
                    { new Guid("34b1e80e-78bf-4aa6-9ae1-9e9ab2fb6f30"), "SQL Server" },
                    { new Guid("655c8825-6f92-47f5-9e7e-8b61330dabc2"), "HTML" },
                    { new Guid("70d4af98-f19c-4b56-bc88-7a918dd9a306"), "CSS" },
                    { new Guid("8e58a809-4472-4704-abe8-705389252b1d"), "Bootstrap" },
                    { new Guid("915e9e1b-e870-4177-937e-83d364b5c130"), "ASP.NET Core" },
                    { new Guid("c29d81f3-98e4-4538-b3b0-ab0aed10fff1"), "Javascript" },
                    { new Guid("de5046bd-6762-47cf-a761-721a96ea36c5"), "JQuery" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("11433974-5b0e-4d63-8d53-ea512bde69bc"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("864ecc44-fac4-433a-899b-30cc56d27dd7"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("ab9e4511-0845-42ae-9813-faeb3f4b0634"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("bb37ed84-9579-4210-a47f-25f21ea226ed"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("d7d4cab0-91fd-4c6f-bbc1-cb7a140b82a2"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("13477a0d-eed0-4260-b4a0-8ae054432cde"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("3039d7f3-0aac-4d2f-a132-18f4b592f261"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("34b1e80e-78bf-4aa6-9ae1-9e9ab2fb6f30"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("655c8825-6f92-47f5-9e7e-8b61330dabc2"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("70d4af98-f19c-4b56-bc88-7a918dd9a306"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("8e58a809-4472-4704-abe8-705389252b1d"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("915e9e1b-e870-4177-937e-83d364b5c130"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("c29d81f3-98e4-4538-b3b0-ab0aed10fff1"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("de5046bd-6762-47cf-a761-721a96ea36c5"));

            migrationBuilder.DropColumn(
                name: "TipoContrato",
                table: "Vagas");

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
        }
    }
}
