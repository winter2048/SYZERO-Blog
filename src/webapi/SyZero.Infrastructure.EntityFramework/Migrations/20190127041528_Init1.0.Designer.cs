﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SyZero.Infrastructure.EntityFramework;

namespace SyZero.Infrastructure.EntityFramework.Migrations
{
    [DbContext(typeof(SyDbContext))]
    [Migration("20190127041528_Init1.0")]
    partial class Init10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SyZero.Domain.Model.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("Headimg")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("LastTime");

                    b.Property<string>("Mail")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<string>("Paw")
                        .HasMaxLength(200);

                    b.Property<string>("Phone")
                        .HasMaxLength(200);

                    b.Property<string>("Sex")
                        .HasMaxLength(200);

                    b.Property<int>("State");

                    b.Property<int>("Utype");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
