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
    [Migration("20221021182042_colunas adicionadas a tabela conta")]
    partial class colunasadicionadasatabelaconta
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GerenciadorDeRendaDomain.Entidades.Categorias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataAlteracao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<int>("EntradaId")
                        .HasColumnType("integer");

                    b.Property<int>("SaidaId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Saldo")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Conta");
                });

            modelBuilder.Entity("GerenciadorDeRendaDomain.Entidades.Entrada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ContaId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("ContaId");

                    b.ToTable("Entrada");
                });

            modelBuilder.Entity("GerenciadorDeRendaDomain.Entidades.Previsao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("GerenciadorDeRendaDomain.Entidades.Saida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ContaId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("ContaId");

                    b.ToTable("Saida");
                });

            modelBuilder.Entity("GerenciadorDeRendaDomain.Entidades.Entrada", b =>
                {
                    b.HasOne("GerenciadorDeRendaDomain.Entidades.Conta", "Conta")
                        .WithMany("Entrada")
                        .HasForeignKey("ContaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conta");
                });

            modelBuilder.Entity("GerenciadorDeRendaDomain.Entidades.Saida", b =>
                {
                    b.HasOne("GerenciadorDeRendaDomain.Entidades.Conta", "Conta")
                        .WithMany("Saida")
                        .HasForeignKey("ContaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conta");
                });

            modelBuilder.Entity("GerenciadorDeRendaDomain.Entidades.Conta", b =>
                {
                    b.Navigation("Entrada");

                    b.Navigation("Saida");
                });
#pragma warning restore 612, 618
        }
    }
}
