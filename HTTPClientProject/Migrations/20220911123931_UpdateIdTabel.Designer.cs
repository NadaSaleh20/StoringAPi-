﻿// <auto-generated />
using HTTPClientProject.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HTTPClientProject.Migrations
{
    [DbContext(typeof(AplicationDBContext))]
    [Migration("20220911123931_UpdateIdTabel")]
    partial class UpdateIdTabel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HTTPClientProject.Db.Emoloyee", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<int>("employee_age")
                        .HasColumnType("int");

                    b.Property<string>("employee_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("employee_salary")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Emoloyee");
                });
#pragma warning restore 612, 618
        }
    }
}