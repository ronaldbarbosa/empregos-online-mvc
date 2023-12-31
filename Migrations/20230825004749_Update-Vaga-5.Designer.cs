﻿// <auto-generated />
using System;
using EmpregosOnLine.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmpregosOnLine.Migrations
{
    [DbContext(typeof(EmpregosOnLineDbContext))]
    [Migration("20230825004749_Update-Vaga-5")]
    partial class UpdateVaga5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BeneficioVaga", b =>
                {
                    b.Property<Guid>("BeneficiosId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VagasId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BeneficiosId", "VagasId");

                    b.HasIndex("VagasId");

                    b.ToTable("VagaBeneficio", (string)null);
                });

            modelBuilder.Entity("EmpregosOnLine.Models.Beneficio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Beneficios");

                    b.HasData(
                        new
                        {
                            Id = new Guid("11067085-6d6e-4d00-8dde-2b756ab325df"),
                            Titulo = "Vale alimentação"
                        },
                        new
                        {
                            Id = new Guid("30d814a7-4eb7-47f2-89fb-9945cd9705c7"),
                            Titulo = "Vale refeição"
                        },
                        new
                        {
                            Id = new Guid("07438d7f-b9cb-47ca-85e0-4905829955c1"),
                            Titulo = "Gympass"
                        },
                        new
                        {
                            Id = new Guid("bfdc2399-075b-4cf1-84f9-0da8f7bf06d1"),
                            Titulo = "PLR"
                        },
                        new
                        {
                            Id = new Guid("877588f3-1139-4449-a600-f69296764518"),
                            Titulo = "Vale combustível"
                        });
                });

            modelBuilder.Entity("EmpregosOnLine.Models.Empresa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<Guid>("EnderecoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("EmpregosOnLine.Models.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("EmpregosOnLine.Models.Habilidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Habilidades");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ba33add8-2546-4a0f-a55a-924504d77da8"),
                            Titulo = "C#"
                        },
                        new
                        {
                            Id = new Guid("088ebcad-1c7d-4e42-89c8-1023ca2b1d6f"),
                            Titulo = "HTML"
                        },
                        new
                        {
                            Id = new Guid("fea2e35d-e557-44d9-ae2e-bd0532ce528c"),
                            Titulo = "CSS"
                        },
                        new
                        {
                            Id = new Guid("be86ce07-aab4-4035-9bcf-b78e6fc3b28e"),
                            Titulo = "Javascript"
                        },
                        new
                        {
                            Id = new Guid("0d53a4c4-2249-4f11-bc30-9d057a7a4425"),
                            Titulo = "JQuery"
                        },
                        new
                        {
                            Id = new Guid("a470c23f-f362-49e7-b2b7-f15d04324837"),
                            Titulo = "Bootstrap"
                        },
                        new
                        {
                            Id = new Guid("dcf98a76-07c5-4b80-83d0-7acf6b9d35f6"),
                            Titulo = "ASP.NET Core"
                        },
                        new
                        {
                            Id = new Guid("4ccddc93-c642-41e7-882a-40b1baa6c79b"),
                            Titulo = "Entity Framework Core"
                        },
                        new
                        {
                            Id = new Guid("6a86f41d-2c87-44a1-b9ce-21ab545dddf6"),
                            Titulo = "SQL Server"
                        });
                });

            modelBuilder.Entity("EmpregosOnLine.Models.Vaga", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ACombinarSalario")
                        .HasColumnType("bit");

                    b.Property<bool>("Ativa")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<Guid>("EmpresaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("TipoContrato")
                        .HasColumnType("int");

                    b.Property<int>("TipoPerfil")
                        .HasColumnType("int");

                    b.Property<int>("TipoVaga")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Vagas");
                });

            modelBuilder.Entity("HabilidadeVaga", b =>
                {
                    b.Property<Guid>("HabilidadesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VagasId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("HabilidadesId", "VagasId");

                    b.HasIndex("VagasId");

                    b.ToTable("VagaHabilidade", (string)null);
                });

            modelBuilder.Entity("BeneficioVaga", b =>
                {
                    b.HasOne("EmpregosOnLine.Models.Beneficio", null)
                        .WithMany()
                        .HasForeignKey("BeneficiosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmpregosOnLine.Models.Vaga", null)
                        .WithMany()
                        .HasForeignKey("VagasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmpregosOnLine.Models.Empresa", b =>
                {
                    b.HasOne("EmpregosOnLine.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("EmpregosOnLine.Models.Vaga", b =>
                {
                    b.HasOne("EmpregosOnLine.Models.Empresa", "Empresa")
                        .WithMany("Vagas")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("HabilidadeVaga", b =>
                {
                    b.HasOne("EmpregosOnLine.Models.Habilidade", null)
                        .WithMany()
                        .HasForeignKey("HabilidadesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmpregosOnLine.Models.Vaga", null)
                        .WithMany()
                        .HasForeignKey("VagasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmpregosOnLine.Models.Empresa", b =>
                {
                    b.Navigation("Vagas");
                });
#pragma warning restore 612, 618
        }
    }
}
