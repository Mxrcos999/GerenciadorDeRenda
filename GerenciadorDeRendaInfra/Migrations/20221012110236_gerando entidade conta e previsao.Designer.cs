﻿// <auto-generated />
using System;
using System.Collections.Generic;
using GerenciadorDeRendaInfra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GerenciadorDeRendaInfra.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221012110236_gerando entidade conta e previsao")]
    partial class gerandoentidadecontaeprevisao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GerenciadorDeRendaDomain.Entidades.Categorias", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<List<string>>("Compras")
                        .HasColumnType("text[]");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<string>("NomeCategoria")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("GerenciadorDeRendaDomain.Entidades.Conta", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal?>("Entrada")
                        .HasColumnType("numeric");

                    b.Property<string>("PrevisaoId")
                        .HasColumnType("text");

                    b.Property<decimal?>("Saida")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("Saldo")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("PrevisaoId");

                    b.ToTable("Conta");
                });

            modelBuilder.Entity("GerenciadorDeRendaDomain.Entidades.Previsao", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("ProxEntrada")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ProxSaida")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal?>("Valor")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Previsao");
                });

            modelBuilder.Entity("GerenciadorDeRendaDomain.Entidades.Conta", b =>
                {
                    b.HasOne("GerenciadorDeRendaDomain.Entidades.Previsao", "Previsao")
                        .WithMany()
                        .HasForeignKey("PrevisaoId");

                    b.Navigation("Previsao");
                });
#pragma warning restore 612, 618
        }
    }
}
