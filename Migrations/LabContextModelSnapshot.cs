﻿// <auto-generated />
using Lab.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace Lab.Migrations
{
    [DbContext(typeof(LabContext))]
    partial class LabContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Lab.Models.Persona", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Materno");

                    b.Property<string>("Nombre");

                    b.Property<string>("Paterno");

                    b.Property<string>("Rut");

                    b.HasKey("ID");

                    b.ToTable("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}
