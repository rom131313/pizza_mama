﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pizza_mama.Data;

#nullable disable

namespace pizza_mama.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250216120110_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("pizza_mama.Models.Pizza", b =>
                {
                    b.Property<int>("PizzaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ingredients")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("prix")
                        .HasColumnType("REAL");

                    b.Property<bool>("vegetarienne")
                        .HasColumnType("INTEGER");

                    b.HasKey("PizzaId");

                    b.ToTable("Pizzas");
                });
#pragma warning restore 612, 618
        }
    }
}
