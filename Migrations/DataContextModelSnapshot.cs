﻿// <auto-generated />
using System;
using BlueHorizon.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace BlueHorizon.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlueHorizon.Models.Atualizacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Cidade");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DataAtualizacao");

                    b.Property<string>("Fosfato")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Fosfato");

                    b.Property<string>("Microplasticos")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Microplasticos");

                    b.Property<string>("Nitrato")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Nitrato");

                    b.Property<string>("OxigenioDissolvido")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("OxigenioDissolvido");

                    b.Property<string>("Porto")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Porto");

                    b.Property<string>("Salinidade")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Salinidade");

                    b.Property<string>("pH")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("pH");

                    b.HasKey("Id");

                    b.ToTable("Tabela_De_Atualizacoes");
                });

            modelBuilder.Entity("BlueHorizon.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateRegister")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("Data_do_registro");

                    b.Property<string>("FotoUrl")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Foto_De_Perfil");

                    b.Property<bool>("IsActive")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("Usuario_Ativo");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Nick");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Hash_da_senha");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Email");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Nome_De_Usuario");

                    b.HasKey("Id");

                    b.ToTable("Tabela_Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
