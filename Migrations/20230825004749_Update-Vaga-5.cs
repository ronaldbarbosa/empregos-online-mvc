using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmpregosOnLine.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVaga5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "ACombinarSalario",
                table: "Vagas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Salario",
                table: "Vagas",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ACombinarSalario",
                table: "Vagas");

            migrationBuilder.DropColumn(
                name: "Salario",
                table: "Vagas");

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
    }
}
