﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectPAW;

namespace ProiectPAW.Migrations
{
    [DbContext(typeof(TransportContext))]
    [Migration("20200529170810_Transport1")]
    partial class Transport1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("ProiectPAW.Masina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Denumire")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumarMasina")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Masini");
                });

            modelBuilder.Entity("ProiectPAW.Sofer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAngajare")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeSofer")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Soferi");
                });

            modelBuilder.Entity("ProiectPAW.Transport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DenumireIncarcatura")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MasinaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Oras")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SoferId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MasinaId");

                    b.HasIndex("SoferId");

                    b.ToTable("Transporturi");
                });

            modelBuilder.Entity("ProiectPAW.Transport", b =>
                {
                    b.HasOne("ProiectPAW.Masina", "Masina")
                        .WithMany()
                        .HasForeignKey("MasinaId");

                    b.HasOne("ProiectPAW.Sofer", "Sofer")
                        .WithMany()
                        .HasForeignKey("SoferId");
                });
#pragma warning restore 612, 618
        }
    }
}
