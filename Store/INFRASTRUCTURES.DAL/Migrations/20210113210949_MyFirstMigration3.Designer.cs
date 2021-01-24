﻿// <auto-generated />
using System;
using Infrastructures.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace INFRASTRUCTURES.DAL.Migrations
{
    [DbContext(typeof(ContextMed))]
    [Migration("20210113210949_MyFirstMigration3")]
    partial class MyFirstMigration3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CORE.DOMAIN.Entities.ImageProduct", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("productID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("productID");

                    b.ToTable("imgeProducts");
                });

            modelBuilder.Entity("CORE.DOMAIN.Entities.ProductInfo", b =>
                {
                    b.Property<int>("ProductInfoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Value")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("key")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int>("productID")
                        .HasColumnType("int");

                    b.HasKey("ProductInfoID");

                    b.HasIndex("productID");

                    b.ToTable("ProductInfo");
                });

            modelBuilder.Entity("Core.Domian.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("parentId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("CategoryName")
                        .IsUnique();

                    b.HasIndex("parentId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Core.Domian.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("count")
                        .HasColumnType("int");

                    b.Property<bool>("isShow")
                        .HasColumnType("bit");

                    b.Property<string>("mainImages")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Core.Domian.productSingleImageCore", b =>
                {
                    b.Property<int>("productSingleImageCoreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("mainImages")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("productSingleImageCoreID");

                    b.ToTable("productSingleImageCores");
                });

            modelBuilder.Entity("CORE.DOMAIN.Entities.ImageProduct", b =>
                {
                    b.HasOne("Core.Domian.Product", "product")
                        .WithMany("imageProducts")
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("CORE.DOMAIN.Entities.ProductInfo", b =>
                {
                    b.HasOne("Core.Domian.Product", "product")
                        .WithMany("ProductInfos")
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("Core.Domian.Category", b =>
                {
                    b.HasOne("Core.Domian.Category", "Parent")
                        .WithMany("Childeren")
                        .HasForeignKey("parentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Core.Domian.Product", b =>
                {
                    b.HasOne("Core.Domian.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Core.Domian.Category", b =>
                {
                    b.Navigation("Childeren");
                });

            modelBuilder.Entity("Core.Domian.Product", b =>
                {
                    b.Navigation("imageProducts");

                    b.Navigation("ProductInfos");
                });
#pragma warning restore 612, 618
        }
    }
}