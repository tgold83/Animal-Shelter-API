﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 7,
                            Name = "Scully",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 6,
                            Name = "Blaze",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 13,
                            Name = "Kitty",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 1,
                            Name = "Newt",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 4,
                            Name = "Ripley",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 14,
                            Name = "Kevin",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 12,
                            Name = "Tank",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 8,
                            Age = 1,
                            Name = "Yuzu",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 9,
                            Age = 2,
                            Name = "Tzufie",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 10,
                            Age = 9,
                            Name = "Lou",
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
