﻿// <auto-generated />
using System;
using FridgeManager.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FridgeManager.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230410140332_AddRelations")]
    partial class AddRelations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FridgeManager.DAL.Entities.FridgeModel", b =>
                {
                    b.Property<Guid>("FridgeModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FridgeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("year")
                        .HasColumnType("int");

                    b.HasKey("FridgeModelId");

                    b.HasIndex("FridgeId")
                        .IsUnique();

                    b.ToTable("FridgeModels");
                });

            modelBuilder.Entity("FridgeManager.DAL.Fridge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fridges");
                });

            modelBuilder.Entity("FridgeManager.DAL.Entities.FridgeModel", b =>
                {
                    b.HasOne("FridgeManager.DAL.Fridge", "Fridge")
                        .WithOne("Model")
                        .HasForeignKey("FridgeManager.DAL.Entities.FridgeModel", "FridgeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fridge");
                });

            modelBuilder.Entity("FridgeManager.DAL.Fridge", b =>
                {
                    b.Navigation("Model")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
