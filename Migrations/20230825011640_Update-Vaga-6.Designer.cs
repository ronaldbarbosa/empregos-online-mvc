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
    [Migration("20230825011640_Update-Vaga-6")]
    partial class UpdateVaga6
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
                            Id = new Guid("258ad810-8ae3-4697-baa2-65681f2bf798"),
                            Titulo = "Vale alimentação"
                        },
                        new
                        {
                            Id = new Guid("7d194687-f44b-451c-8cc6-714ab6abc0fd"),
                            Titulo = "Vale refeição"
                        },
                        new
                        {
                            Id = new Guid("ed3abce8-5904-4e57-9ce9-c3d78cfa0688"),
                            Titulo = "Gympass"
                        },
                        new
                        {
                            Id = new Guid("99d6cfb3-2f23-4447-9e62-5f100b5ab6a7"),
                            Titulo = "PLR"
                        },
                        new
                        {
                            Id = new Guid("140b1bf7-8580-4060-94ac-702bc54f0ff4"),
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
                            Id = new Guid("1aaadb63-d5ea-424b-b542-63f4eff64153"),
                            Titulo = "C#"
                        },
                        new
                        {
                            Id = new Guid("cca7023c-f34d-43cc-b86f-0f96b7ffa074"),
                            Titulo = "HTML"
                        },
                        new
                        {
                            Id = new Guid("b689091b-2021-4bc1-8f42-bae29e047388"),
                            Titulo = "CSS"
                        },
                        new
                        {
                            Id = new Guid("30595fad-7531-40f1-9542-ec80a57672df"),
                            Titulo = "Javascript"
                        },
                        new
                        {
                            Id = new Guid("ba7e468e-2fb0-4eaf-829d-6042a0ed83f7"),
                            Titulo = "JQuery"
                        },
                        new
                        {
                            Id = new Guid("d0e8d437-3bc7-4cef-b3d0-380a12abea3b"),
                            Titulo = "Bootstrap"
                        },
                        new
                        {
                            Id = new Guid("3920ec75-7a43-4d41-aee1-858e37d5ca2c"),
                            Titulo = "ASP.NET Core"
                        },
                        new
                        {
                            Id = new Guid("f5144710-e41f-445a-bd78-b6b1957d100e"),
                            Titulo = "Entity Framework Core"
                        },
                        new
                        {
                            Id = new Guid("b42694af-53c7-4464-9692-29695702480a"),
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
