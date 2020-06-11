﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial1_Ap2_Nuñez.DAL;

namespace Parcial1_Ap2_Nuñez.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200611004323_PrimerParcial")]
    partial class PrimerParcial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("Parcial1_Ap2_Nuñez.Models.Producto", b =>
                {
                    b.Property<int>("ArticulosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Costo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<int>("Existencia")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ValorInventario")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArticulosId");

                    b.ToTable("productos");
                });
#pragma warning restore 612, 618
        }
    }
}
