using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmpregosOnLine.Migrations
{
    /// <inheritdoc />
    public partial class AddUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "UsuariosCandidato",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosCandidato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosEmpresa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosEmpresa", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Beneficios",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { new Guid("1bab1aa6-a9a4-4bec-8ec2-5ed4f9bf51e4"), "Vale alimentação" },
                    { new Guid("26d16f54-51c6-4f39-b1c5-fae956db0c18"), "Vale refeição" },
                    { new Guid("9c66ed7c-ae96-45a6-8eae-251fc6ad2ae0"), "Gympass" },
                    { new Guid("a256889e-ddd6-4d00-a00c-5d3951b3f0ab"), "Vale combustível" },
                    { new Guid("fcb168b1-e8ac-466b-85a5-e692f76159a1"), "PLR" }
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { new Guid("03b4c41d-6366-4feb-abb5-bc07c3c7917a"), "HTML" },
                    { new Guid("0e2ff059-d41e-47bf-b6f2-50d5de14dcb1"), "C#" },
                    { new Guid("0f50b683-b541-40a5-be78-7686a771ca7e"), "Javascript" },
                    { new Guid("4051bbe1-dacf-4926-a65b-5aed375d3d30"), "Entity Framework Core" },
                    { new Guid("8d79ce37-c896-4dcd-9323-853ff3496b6e"), "JQuery" },
                    { new Guid("a4add980-7edd-4569-bc05-bd0da54ae807"), "CSS" },
                    { new Guid("ba095a28-db35-4a52-ab81-cf3df7bf6caf"), "Bootstrap" },
                    { new Guid("e15f947e-d85f-4d0b-8468-3788f1d2e77e"), "SQL Server" },
                    { new Guid("f2e2b598-0ebd-4bce-86ac-6a519ada4403"), "ASP.NET Core" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuariosCandidato");

            migrationBuilder.DropTable(
                name: "UsuariosEmpresa");

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("1bab1aa6-a9a4-4bec-8ec2-5ed4f9bf51e4"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("26d16f54-51c6-4f39-b1c5-fae956db0c18"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("9c66ed7c-ae96-45a6-8eae-251fc6ad2ae0"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("a256889e-ddd6-4d00-a00c-5d3951b3f0ab"));

            migrationBuilder.DeleteData(
                table: "Beneficios",
                keyColumn: "Id",
                keyValue: new Guid("fcb168b1-e8ac-466b-85a5-e692f76159a1"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("03b4c41d-6366-4feb-abb5-bc07c3c7917a"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("0e2ff059-d41e-47bf-b6f2-50d5de14dcb1"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("0f50b683-b541-40a5-be78-7686a771ca7e"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("4051bbe1-dacf-4926-a65b-5aed375d3d30"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("8d79ce37-c896-4dcd-9323-853ff3496b6e"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("a4add980-7edd-4569-bc05-bd0da54ae807"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("ba095a28-db35-4a52-ab81-cf3df7bf6caf"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("e15f947e-d85f-4d0b-8468-3788f1d2e77e"));

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: new Guid("f2e2b598-0ebd-4bce-86ac-6a519ada4403"));

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
    }
}
