﻿// <auto-generated />
using System;
using billsbuddy.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace billsbuddy.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231108184303_AddAmttargetAmtenterTableToDb")]
    partial class AddAmttargetAmtenterTableToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("billsbuddy.Models.Amount_enter", b =>
                {
                    b.Property<int>("Id_amt_enter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_amt_enter"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_amt_target")
                        .HasColumnType("int");

                    b.Property<double>("car")
                        .HasColumnType("float");

                    b.Property<double>("donation")
                        .HasColumnType("float");

                    b.Property<double>("eat_outside")
                        .HasColumnType("float");

                    b.Property<double>("emergency_money")
                        .HasColumnType("float");

                    b.Property<double>("grocery")
                        .HasColumnType("float");

                    b.Property<double>("house")
                        .HasColumnType("float");

                    b.Property<double>("petrol")
                        .HasColumnType("float");

                    b.Property<double>("saving")
                        .HasColumnType("float");

                    b.Property<double>("utility")
                        .HasColumnType("float");

                    b.HasKey("Id_amt_enter");

                    b.HasIndex("Id_amt_target");

                    b.ToTable("Amount_enter");
                });

            modelBuilder.Entity("billsbuddy.Models.Amount_target", b =>
                {
                    b.Property<int>("Id_amt_target")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_amt_target"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_user")
                        .HasColumnType("int");

                    b.Property<double>("car")
                        .HasColumnType("float");

                    b.Property<double>("donation")
                        .HasColumnType("float");

                    b.Property<double>("eat_outside")
                        .HasColumnType("float");

                    b.Property<double>("emergency_money")
                        .HasColumnType("float");

                    b.Property<double>("grocery")
                        .HasColumnType("float");

                    b.Property<double>("house")
                        .HasColumnType("float");

                    b.Property<double>("petrol")
                        .HasColumnType("float");

                    b.Property<double>("saving")
                        .HasColumnType("float");

                    b.Property<double>("utility")
                        .HasColumnType("float");

                    b.HasKey("Id_amt_target");

                    b.HasIndex("Id_user");

                    b.ToTable("Amount_target");
                });

            modelBuilder.Entity("billsbuddy.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("billsbuddy.Models.Net_salary", b =>
                {
                    b.Property<int>("Id_net_salary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_net_salary"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_user")
                        .HasColumnType("int");

                    b.Property<double>("amount")
                        .HasColumnType("float");

                    b.HasKey("Id_net_salary");

                    b.HasIndex("Id_user");

                    b.ToTable("Net_Salary");
                });

            modelBuilder.Entity("billsbuddy.Models.Users", b =>
                {
                    b.Property<int>("Id_user")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_user"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id_user");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("billsbuddy.Models.Amount_enter", b =>
                {
                    b.HasOne("billsbuddy.Models.Amount_target", "Amount_Target")
                        .WithMany()
                        .HasForeignKey("Id_amt_target")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amount_Target");
                });

            modelBuilder.Entity("billsbuddy.Models.Amount_target", b =>
                {
                    b.HasOne("billsbuddy.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("Id_user")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("billsbuddy.Models.Net_salary", b =>
                {
                    b.HasOne("billsbuddy.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("Id_user")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
