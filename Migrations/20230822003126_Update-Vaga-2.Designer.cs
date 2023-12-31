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
    [Migration("20230822003126_Update-Vaga-2")]
    partial class UpdateVaga2
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
                            Id = new Guid("2bb69d8e-4b67-4a60-8de9-a87e47d2fdd8"),
                            Titulo = "Vale alimentação"
                        },
                        new
                        {
                            Id = new Guid("d57b1067-e36b-4726-9857-c0e3b38fa175"),
                            Titulo = "Vale refeição"
                        },
                        new
                        {
                            Id = new Guid("bb18fc12-a597-447e-8bd3-a06f678c2d6e"),
                            Titulo = "Gympass"
                        },
                        new
                        {
                            Id = new Guid("11261f3d-2359-4f79-97f3-cb4480e3b65f"),
                            Titulo = "PLR"
                        },
                        new
                        {
                            Id = new Guid("85dd64fd-b5f5-46e2-816a-4e0dfeaaee75"),
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
                            Id = new Guid("63bf0858-873a-4714-92f2-14a623bbc468"),
                            Titulo = "C#"
                        },
                        new
                        {
                            Id = new Guid("85c53f7d-fda6-4e15-a6f7-bea08df715c9"),
                            Titulo = "HTML"
                        },
                        new
                        {
                            Id = new Guid("f3de2c30-2200-4ce2-b16a-484d173a1128"),
                            Titulo = "CSS"
                        },
                        new
                        {
                            Id = new Guid("98b1621e-5262-46de-9d7f-b65b0a6590ce"),
                            Titulo = "Javascript"
                        },
                        new
                        {
                            Id = new Guid("c826968f-e5f5-48e7-a187-8b4f06fa4ce7"),
                            Titulo = "JQuery"
                        },
                        new
                        {
                            Id = new Guid("e7ba1bf8-33f9-4714-9778-759106df3fd5"),
                            Titulo = "Bootstrap"
                        },
                        new
                        {
                            Id = new Guid("aea28668-3dd7-4472-87bd-50f9223078c0"),
                            Titulo = "ASP.NET Core"
                        },
                        new
                        {
                            Id = new Guid("e916718e-5f38-4e13-8589-acb43c9b80e9"),
                            Titulo = "Entity Framework Core"
                        },
                        new
                        {
                            Id = new Guid("2d9bd290-e5d3-4c4f-967e-dc177539fc95"),
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
