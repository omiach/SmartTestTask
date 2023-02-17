﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartTestTaskData;

#nullable disable

namespace SmartTestTaskData.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SmartTestTaskModel.EquipmentPlacementContract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductionPremisesId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("TypeOfEquipmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductionPremisesId");

                    b.HasIndex("TypeOfEquipmentId");

                    b.ToTable("EquipmentPlacementContract");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductionPremisesId = 1,
                            Quantity = 1,
                            TypeOfEquipmentId = 1
                        },
                        new
                        {
                            Id = 2,
                            ProductionPremisesId = 1,
                            Quantity = 1,
                            TypeOfEquipmentId = 2
                        },
                        new
                        {
                            Id = 3,
                            ProductionPremisesId = 1,
                            Quantity = 1,
                            TypeOfEquipmentId = 3
                        },
                        new
                        {
                            Id = 4,
                            ProductionPremisesId = 2,
                            Quantity = 1,
                            TypeOfEquipmentId = 4
                        },
                        new
                        {
                            Id = 5,
                            ProductionPremisesId = 2,
                            Quantity = 1,
                            TypeOfEquipmentId = 5
                        },
                        new
                        {
                            Id = 6,
                            ProductionPremisesId = 2,
                            Quantity = 1,
                            TypeOfEquipmentId = 6
                        });
                });

            modelBuilder.Entity("SmartTestTaskModel.ProductionPremises", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<double>("SpaceForEquipment")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ProductionPremises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kyiv #1",
                            SpaceForEquipment = 100.0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kyiv #2",
                            SpaceForEquipment = 200.0
                        },
                        new
                        {
                            Id = 3,
                            Name = "Kyiv #3",
                            SpaceForEquipment = 400.0
                        },
                        new
                        {
                            Id = 4,
                            Name = "Lviv #1",
                            SpaceForEquipment = 800.0
                        },
                        new
                        {
                            Id = 5,
                            Name = "Lviv #2",
                            SpaceForEquipment = 1600.0
                        },
                        new
                        {
                            Id = 6,
                            Name = "Lviv #3",
                            SpaceForEquipment = 3200.0
                        });
                });

            modelBuilder.Entity("SmartTestTaskModel.TypeOfEquipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Area")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("TypeOfEquipment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Area = 1.0,
                            Name = "Equipment #1"
                        },
                        new
                        {
                            Id = 2,
                            Area = 2.0,
                            Name = "Equipment #2"
                        },
                        new
                        {
                            Id = 3,
                            Area = 4.0,
                            Name = "Equipment #3"
                        },
                        new
                        {
                            Id = 4,
                            Area = 8.0,
                            Name = "Equipment #4"
                        },
                        new
                        {
                            Id = 5,
                            Area = 16.0,
                            Name = "Equipment #5"
                        },
                        new
                        {
                            Id = 6,
                            Area = 32.0,
                            Name = "Equipment #6"
                        });
                });

            modelBuilder.Entity("SmartTestTaskModel.EquipmentPlacementContract", b =>
                {
                    b.HasOne("SmartTestTaskModel.ProductionPremises", "ProductionPremises")
                        .WithMany()
                        .HasForeignKey("ProductionPremisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartTestTaskModel.TypeOfEquipment", "TypeOfEquipment")
                        .WithMany()
                        .HasForeignKey("TypeOfEquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductionPremises");

                    b.Navigation("TypeOfEquipment");
                });
#pragma warning restore 612, 618
        }
    }
}
