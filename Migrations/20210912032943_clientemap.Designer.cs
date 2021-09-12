﻿// <auto-generated />
using System;
using FESTA_FACIL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FESTA_FACIL.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210912032943_clientemap")]
    partial class clientemap
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FESTA_FACIL.Models.Dominio.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("cpf")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("email")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int>("idade")
                        .HasColumnType("int");

                    b.Property<string>("municipio")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("FESTA_FACIL.Models.Dominio.Kit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cilindros")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mesa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Painel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Kits");
                });

            modelBuilder.Entity("FESTA_FACIL.Models.Dominio.Mobilia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Mobilias");
                });

            modelBuilder.Entity("FESTA_FACIL.Models.Dominio.Tema", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KitsID")
                        .HasColumnType("int");

                    b.Property<int?>("MobiliaID")
                        .HasColumnType("int");

                    b.Property<string>("NomeTema")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumItens")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KitsID");

                    b.HasIndex("MobiliaID");

                    b.ToTable("Temas");
                });

            modelBuilder.Entity("FESTA_FACIL.Models.Dominio.Tema", b =>
                {
                    b.HasOne("FESTA_FACIL.Models.Dominio.Kit", "Kits")
                        .WithMany()
                        .HasForeignKey("KitsID");

                    b.HasOne("FESTA_FACIL.Models.Dominio.Mobilia", "Mobilia")
                        .WithMany()
                        .HasForeignKey("MobiliaID");

                    b.Navigation("Kits");

                    b.Navigation("Mobilia");
                });
#pragma warning restore 612, 618
        }
    }
}
