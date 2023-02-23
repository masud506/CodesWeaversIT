﻿// <auto-generated />
using System;
using CodesWeaverNew.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodesWeaverNew.Migrations
{
    [DbContext(typeof(CodesWeaverNewContext))]
    [Migration("20230218091413_about1")]
    partial class about1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodesWeaverNew.Models.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Boolet1Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Boolet1TitleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Boolet2Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Boolet2TitleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Boolet3Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Boolet3TitleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Image2")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Image3")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("MissionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VissionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("willshown")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("About");
                });

            modelBuilder.Entity("CodesWeaverNew.Models.Sliders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("willshown")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Sliders");
                });
#pragma warning restore 612, 618
        }
    }
}
