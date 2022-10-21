﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RiderBlasorWebinar.Shared.Models;

#nullable disable

namespace RiderBlasorWebinar.Shared.Migrations
{
    [DbContext(typeof(SampleDb))]
    [Migration("20221020141931_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("RiderBlasorWebinar.Shared.Models.WorkOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Somevalue")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Workdate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WorkOrders");
                });
#pragma warning restore 612, 618
        }
    }
}