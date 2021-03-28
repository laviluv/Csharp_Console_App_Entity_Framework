﻿// <auto-generated />
using System;
using MP_EF_Lavinia_Bleoca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MP_EF_Lavinia_Bleoca.Migrations
{
    [DbContext(typeof(AssetsContext))]
    [Migration("20210328223007_IsDeprecatedinterface")]
    partial class IsDeprecatedinterface
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MP_EF_Lavinia_Bleoca.CellPhones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Purchased")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResourceType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.ToTable("CellPhones");
                });

            modelBuilder.Entity("MP_EF_Lavinia_Bleoca.Computers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Purchased")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResourceType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.ToTable("Computers");
                });

            modelBuilder.Entity("MP_EF_Lavinia_Bleoca.DiverseAssets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Purchased")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResourceType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.ToTable("DiverseAssets");
                });

            modelBuilder.Entity("MP_EF_Lavinia_Bleoca.Offices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("MP_EF_Lavinia_Bleoca.CellPhones", b =>
                {
                    b.HasOne("MP_EF_Lavinia_Bleoca.Offices", "Office")
                        .WithMany("CellPhones")
                        .HasForeignKey("OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("MP_EF_Lavinia_Bleoca.Computers", b =>
                {
                    b.HasOne("MP_EF_Lavinia_Bleoca.Offices", "Office")
                        .WithMany("Computers")
                        .HasForeignKey("OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("MP_EF_Lavinia_Bleoca.DiverseAssets", b =>
                {
                    b.HasOne("MP_EF_Lavinia_Bleoca.Offices", "Office")
                        .WithMany("DiverseAssets")
                        .HasForeignKey("OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("MP_EF_Lavinia_Bleoca.Offices", b =>
                {
                    b.Navigation("CellPhones");

                    b.Navigation("Computers");

                    b.Navigation("DiverseAssets");
                });
#pragma warning restore 612, 618
        }
    }
}