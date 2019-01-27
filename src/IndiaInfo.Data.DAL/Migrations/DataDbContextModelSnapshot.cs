﻿// <auto-generated />
using System;
using IndiaInfo.Data.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IndiaInfo.Data.DAL.Migrations
{
    [DbContext(typeof(DataDbContext))]
    partial class DataDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IndiaInfo.Data.DAL.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminZone")
                        .HasColumnName("AdminZone")
                        .HasColumnType("char(1)")
                        .HasMaxLength(1);

                    b.Property<string>("DivisionType")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)))
                        .HasColumnName("DivisionType")
                        .HasColumnType("char(1)")
                        .HasMaxLength(1);

                    b.Property<string>("IsoCode")
                        .IsRequired()
                        .HasColumnName("IsoCode")
                        .HasColumnType("char(5)")
                        .HasMaxLength(5);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("StatehoodDate");

                    b.Property<string>("VehicleCode")
                        .IsRequired()
                        .HasColumnName("VehicleCode")
                        .HasColumnType("char(2)")
                        .HasMaxLength(2);

                    b.HasKey("StateId");

                    b.ToTable("State","Core");
                });
#pragma warning restore 612, 618
        }
    }
}
