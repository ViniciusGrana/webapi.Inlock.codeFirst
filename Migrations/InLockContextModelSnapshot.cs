﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi.Inlock.codeFirst.manha.Contexts;

#nullable disable

namespace webapi.Inlock.codeFirst.manha.Migrations
{
    [DbContext(typeof(InLockContext))]
    partial class InLockContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webapi.Inlock.codeFirst.manha.Domain.Estudio", b =>
                {
                    b.Property<Guid>("IdEstudio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdEstudio");

                    b.ToTable("Estudio");
                });

            modelBuilder.Entity("webapi.Inlock.codeFirst.manha.Domain.Jogo", b =>
                {
                    b.Property<Guid>("IdJogo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("DATE");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("IdEstudio")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR (100)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("Decimal(4,2)");

                    b.HasKey("IdJogo");

                    b.HasIndex("IdEstudio");

                    b.ToTable("Jogo");
                });

            modelBuilder.Entity("webapi.Inlock.codeFirst.manha.Domain.TipoUsuario", b =>
                {
                    b.Property<Guid>("IdTipoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdTipoUsuario");

                    b.ToTable("TIposUsuario");
                });

            modelBuilder.Entity("webapi.Inlock.codeFirst.manha.Domain.Usuario", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<Guid>("IdTipoUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("IdTipoUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("webapi.Inlock.codeFirst.manha.Domain.Jogo", b =>
                {
                    b.HasOne("webapi.Inlock.codeFirst.manha.Domain.Estudio", "Estudio")
                        .WithMany("Jogos")
                        .HasForeignKey("IdEstudio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estudio");
                });

            modelBuilder.Entity("webapi.Inlock.codeFirst.manha.Domain.Usuario", b =>
                {
                    b.HasOne("webapi.Inlock.codeFirst.manha.Domain.TipoUsuario", "TipoUsuario")
                        .WithMany()
                        .HasForeignKey("IdTipoUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoUsuario");
                });

            modelBuilder.Entity("webapi.Inlock.codeFirst.manha.Domain.Estudio", b =>
                {
                    b.Navigation("Jogos");
                });
#pragma warning restore 612, 618
        }
    }
}
