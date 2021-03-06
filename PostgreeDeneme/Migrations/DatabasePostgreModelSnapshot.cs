﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PostgreeDeneme;
using System;

namespace PostgreeDeneme.Migrations
{
    [DbContext(typeof(DatabasePostgre))]
    partial class DatabasePostgreModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("PostgreeDeneme.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adi");

                    b.Property<string>("Soyadi");

                    b.Property<int>("TCKimlikNo");

                    b.HasKey("OgrenciId");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("PostgreeDeneme.Veli", b =>
                {
                    b.Property<int>("VeliId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adi");

                    b.Property<string>("GSM");

                    b.Property<int>("OgrenciId");

                    b.Property<string>("Soyadi");

                    b.Property<string>("TagID");

                    b.HasKey("VeliId");

                    b.HasIndex("OgrenciId");

                    b.ToTable("Veliler");
                });

            modelBuilder.Entity("PostgreeDeneme.Veli", b =>
                {
                    b.HasOne("PostgreeDeneme.Ogrenci", "Ogrenci")
                        .WithMany("Veliler")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
