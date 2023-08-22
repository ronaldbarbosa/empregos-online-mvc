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
    [Migration("20230822000310_Update-Vaga")]
    partial class UpdateVaga
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmpregosOnLine.Models.Beneficio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<Guid?>("VagaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VagaId");

                    b.ToTable("Beneficios");

                    b.HasData(
                        new
                        {
                            Id = new Guid("361e96af-7b01-40f1-81c5-3ba77ea9e2a3"),
                            Titulo = "Vale alimentação"
                        },
                        new
                        {
                            Id = new Guid("6c5164ba-7d80-48fd-ad84-c397ded87d43"),
                            Titulo = "Vale refeição"
                        },
                        new
                        {
                            Id = new Guid("0a961325-0d30-4a72-b80e-7fd746def17d"),
                            Titulo = "Gympass"
                        },
                        new
                        {
                            Id = new Guid("fd07bde8-2233-4f93-96b4-d5d79edcadfe"),
                            Titulo = "PLR"
                        },
                        new
                        {
                            Id = new Guid("b699014f-0e90-4fe7-be1b-78f629899861"),
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

                    b.Property<Guid?>("VagaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VagaId");

                    b.ToTable("Habilidades");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c7581993-0a2e-45c0-b22d-a31339d91f3f"),
                            Titulo = "C#"
                        },
                        new
                        {
                            Id = new Guid("23483a88-8f96-4a92-95cc-4340e76b74c7"),
                            Titulo = "HTML"
                        },
                        new
                        {
                            Id = new Guid("e12151a0-2d42-4f20-b864-cfb2c6075cf6"),
                            Titulo = "CSS"
                        },
                        new
                        {
                            Id = new Guid("a82b7c60-3962-4969-a956-f4616b16cf18"),
                            Titulo = "Javascript"
                        },
                        new
                        {
                            Id = new Guid("67264dd3-b5d3-4c9d-8dfb-037a877c9790"),
                            Titulo = "JQuery"
                        },
                        new
                        {
                            Id = new Guid("7edd7bee-317d-4dad-802a-745760cf74c4"),
                            Titulo = "Bootstrap"
                        },
                        new
                        {
                            Id = new Guid("569efbed-3243-40c5-9d47-a5f0ae7f8d35"),
                            Titulo = "ASP.NET Core"
                        },
                        new
                        {
                            Id = new Guid("56aa90b4-6c2d-48ce-99a5-369dfc310403"),
                            Titulo = "Entity Framework Core"
                        },
                        new
                        {
                            Id = new Guid("5a0ec37d-cd4b-4a5c-9d32-67f50e824c41"),
                            Titulo = "SQL Server"
                        });
                });

            modelBuilder.Entity("EmpregosOnLine.Models.Vaga", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativa")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<Guid>("EmpresaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TipoVaga")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Vagas");
                });

            modelBuilder.Entity("EmpregosOnLine.Models.Beneficio", b =>
                {
                    b.HasOne("EmpregosOnLine.Models.Vaga", null)
                        .WithMany("Beneficios")
                        .HasForeignKey("VagaId");
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

            modelBuilder.Entity("EmpregosOnLine.Models.Habilidade", b =>
                {
                    b.HasOne("EmpregosOnLine.Models.Vaga", null)
                        .WithMany("Habilidades")
                        .HasForeignKey("VagaId");
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

            modelBuilder.Entity("EmpregosOnLine.Models.Empresa", b =>
                {
                    b.Navigation("Vagas");
                });

            modelBuilder.Entity("EmpregosOnLine.Models.Vaga", b =>
                {
                    b.Navigation("Beneficios");

                    b.Navigation("Habilidades");
                });
#pragma warning restore 612, 618
        }
    }
}
