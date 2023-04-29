﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestAPI.Infrastructure;

#nullable disable

namespace RestAPI.Infrastructure.Migrations
{
    [DbContext(typeof(ECommerceDBContext))]
    [Migration("20230429182059_Update-Relationships")]
    partial class UpdateRelationships
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryDtoProductDto", b =>
                {
                    b.Property<Guid>("CategoriesDtosId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductDtosId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoriesDtosId", "ProductDtosId");

                    b.HasIndex("ProductDtosId");

                    b.ToTable("ProductCategories", (string)null);
                });

            modelBuilder.Entity("RestAPI.Domain.Categories.CategoryDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("RestAPI.Domain.Product.ProductDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CategoryDtoProductDto", b =>
                {
                    b.HasOne("RestAPI.Domain.Categories.CategoryDto", null)
                        .WithMany()
                        .HasForeignKey("CategoriesDtosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestAPI.Domain.Product.ProductDto", null)
                        .WithMany()
                        .HasForeignKey("ProductDtosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}