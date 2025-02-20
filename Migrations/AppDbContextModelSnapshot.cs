﻿// <auto-generated />
using System;
using FunctionAppTest.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FunctionAppTest.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FunctionAppTest.DAL.Model.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Count = 1,
                            ItemName = "Item_P1_I1",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            Count = 2,
                            ItemName = "Item_P1_I2",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 3,
                            Count = 3,
                            ItemName = "Item_P1_I3",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 4,
                            Count = 1,
                            ItemName = "Item_P2_I1",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 5,
                            Count = 2,
                            ItemName = "Item_P2_I2",
                            ProductId = 2
                        });
                });

            modelBuilder.Entity("FunctionAppTest.DAL.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Chandan",
                            CreatedOn = new DateTime(2025, 2, 20, 14, 30, 58, 570, DateTimeKind.Local).AddTicks(1784),
                            ModifiedBy = "Chandan",
                            ModifiedOn = new DateTime(2025, 2, 20, 14, 30, 58, 570, DateTimeKind.Local).AddTicks(1803),
                            ProductName = "DefaultP1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Amit",
                            CreatedOn = new DateTime(2025, 2, 20, 14, 30, 58, 570, DateTimeKind.Local).AddTicks(1836),
                            ModifiedBy = "Amit",
                            ModifiedOn = new DateTime(2025, 2, 20, 14, 30, 58, 570, DateTimeKind.Local).AddTicks(1836),
                            ProductName = "DefaultP2"
                        });
                });

            modelBuilder.Entity("FunctionAppTest.DAL.Model.Item", b =>
                {
                    b.HasOne("FunctionAppTest.DAL.Model.Product", "Product")
                        .WithMany("Items")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FunctionAppTest.DAL.Model.Product", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
