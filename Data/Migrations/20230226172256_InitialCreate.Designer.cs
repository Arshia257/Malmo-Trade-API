﻿// <auto-generated />
using MalmöTradera.api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MalmöTradera.api.Data.Migrations
{
    [DbContext(typeof(MalmöTraderaContext))]
    [Migration("20230226172256_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("MalmöTradera.api.Model.Items", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ISSold")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("value")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Item");
                });
#pragma warning restore 612, 618
        }
    }
}