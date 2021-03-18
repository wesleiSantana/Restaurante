﻿// <auto-generated />
using System;
using GarcomAnotacoes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GarcomAnotacoes.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GarcomAnotacoes.Models.Copa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("PedidoId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Copas");
                });

            modelBuilder.Entity("GarcomAnotacoes.Models.Cozinha", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("PedidoId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Cozinhas");
                });

            modelBuilder.Entity("GarcomAnotacoes.Models.Pedido", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CopaId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CozinhaId")
                        .HasColumnType("bigint");

                    b.Property<string>("NomeDaBabida")
                        .HasColumnName("Bebida")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("NomeDoPrato")
                        .HasColumnName("Prato")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("NomeDocliente")
                        .IsRequired()
                        .HasColumnName("Cliente")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("NumeDaMesa")
                        .HasColumnName("Mesa")
                        .HasColumnType("INT");

                    b.Property<int>("QuantidaDeBebidas")
                        .HasColumnName("Qtd Bebidas")
                        .HasColumnType("INT");

                    b.Property<int>("QuantidadeDePratos")
                        .HasColumnName("Qtd Pratos")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("CopaId");

                    b.HasIndex("CozinhaId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("GarcomAnotacoes.Models.Pedido", b =>
                {
                    b.HasOne("GarcomAnotacoes.Models.Copa", null)
                        .WithMany("Pedido")
                        .HasForeignKey("CopaId");

                    b.HasOne("GarcomAnotacoes.Models.Cozinha", null)
                        .WithMany("Pedido")
                        .HasForeignKey("CozinhaId");
                });
#pragma warning restore 612, 618
        }
    }
}