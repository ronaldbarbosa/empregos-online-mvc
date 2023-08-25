using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmpregosOnLine.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVaga4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "TipoPerfil",
                table: "Vagas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Beneficios",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { new Guid("15053a95-b2f3-4768-8cb7-db110959a965"), "Vale combustível" },
                    { new Guid("774a58a9-ccb3-4c9e-be16-6af085a7aaa2"), "PLR" },
                    { new Guid("8773ac1e-65ec-4d66-bc1f-2cf33285b37f"), "Vale alimentação" },
                    { new Guid("8ed2a442-c478-4d51-9e27-1a7b9215f001"), "Vale refeição" },
                    { new Guid("de6a2d3c-4e13-4887-8949-96a3b574d734"), "Gympass" }
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { new Guid("1027dc18-2117-4080-b76a-52029db1cea7"), "Bootstrap" },
                    { new Guid("17eafd6e-59b1-4ad0-9405-d95dcd12ac55"), "ASP.NET Core" },
                    { new Guid("26b0a193-756a-4c68-bb3f-bf624e61d05d"), "JQuery" },
                    { new Guid("52e3fd06-590c-46d2-9456-5707b4ac1330"), "Entity Framework Core" },
                    { new Guid("54d2a8e0-d84b-4ae2-83ef-7953c474baeb"), "HTML" },
                    { new Guid("5dc5ae2b-4554-4f34-b56e-e49491237025"), "C#" },
                    { new Guid("97ff8a8a-8896-41b3-85bb-55c48a515908"), "SQL Server" },
                    { new Guid("bebdacee-9051-4b99-8b9e-cbef420cef23"), "CSS" },
                    { new Guid("e6ace917-0586-4c8d-8c3b-7ee9739663ee"), "Javascript" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("15053a95-b2f3-4768-8cb7-db110959a965"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("774a58a9-ccb3-4c9e-be16-6af085a7aaa2"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("8773ac1e-65ec-4d66-bc1f-2cf33285b37f"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("8ed2a442-c478-4d51-9e27-1a7b9215f001"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("de6a2d3c-4e13-4887-8949-96a3b574d734"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("1027dc18-2117-4080-b76a-52029db1cea7"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("17eafd6e-59b1-4ad0-9405-d95dcd12ac55"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("26b0a193-756a-4c68-bb3f-bf624e61d05d"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("52e3fd06-590c-46d2-9456-5707b4ac1330"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("54d2a8e0-d84b-4ae2-83ef-7953c474baeb"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("5dc5ae2b-4554-4f34-b56e-e49491237025"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("97ff8a8a-8896-41b3-85bb-55c48a515908"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("bebdacee-9051-4b99-8b9e-cbef420cef23"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("e6ace917-0586-4c8d-8c3b-7ee9739663ee"));

            migrationBuilder.DropColumn(
                name: "TipoPerfil",
                table: "Vagas");

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
    }
}
