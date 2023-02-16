﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsRosters.Data;

#nullable disable

namespace SportsRosters.Migrations
{
    [DbContext(typeof(SportsRostersContext))]
    partial class SportsRostersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SportsRosters.Models.BaseballRoster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bats")
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(55)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("Throws")
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("Id");

                    b.ToTable("BaseballRoster");
                });
#pragma warning restore 612, 618
        }
    }
}
