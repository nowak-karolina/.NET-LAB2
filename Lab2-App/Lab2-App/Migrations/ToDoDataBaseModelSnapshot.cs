﻿// <auto-generated />
using App;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab2_App.Migrations
{
    [DbContext(typeof(ToDoDataBase))]
    partial class ToDoDataBaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("App.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("accessibility")
                        .HasColumnType("REAL");

                    b.Property<string>("activity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("key")
                        .HasColumnType("TEXT");

                    b.Property<string>("link")
                        .HasColumnType("TEXT");

                    b.Property<float>("participants")
                        .HasColumnType("REAL");

                    b.Property<float>("price")
                        .HasColumnType("REAL");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("todos");
                });
#pragma warning restore 612, 618
        }
    }
}
