﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ApplicationCore.Entity.Asset.BankSavingAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("InputCurrency")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("InputMoneyAmount")
                        .HasColumnType("double precision");

                    b.Property<double>("InterestRate")
                        .HasColumnType("double precision");

                    b.Property<bool>("IsGoingToReinState")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("TermRange")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("BankSavingAssets");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CashAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("CurrentAmount")
                        .HasColumnType("double precision");

                    b.Property<string>("InputCurrency")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("InputMoneyAmount")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("CashAssets");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CustomInterestAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CustomInterestAssetInfoId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("InputCurrency")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("InputMoneyAmount")
                        .HasColumnType("double precision");

                    b.Property<double>("InterestRate")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("TermRange")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CustomInterestAssetInfoId");

                    b.HasIndex("UserId");

                    b.ToTable("CustomInterestAssets");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CustomInterestAssetInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("CustomInterestAssetInfos");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.RealEstateAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("CurrentPrice")
                        .HasColumnType("double precision");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("InputCurrency")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("InputMoneyAmount")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RealEstateAssets");
                });

            modelBuilder.Entity("ApplicationCore.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.BankSavingAsset", b =>
                {
                    b.HasOne("ApplicationCore.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CashAsset", b =>
                {
                    b.HasOne("ApplicationCore.Entity.User", "User")
                        .WithOne("CashAsset")
                        .HasForeignKey("ApplicationCore.Entity.Asset.CashAsset", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CustomInterestAsset", b =>
                {
                    b.HasOne("ApplicationCore.Entity.Asset.CustomInterestAssetInfo", "CustomInterestAssetInfo")
                        .WithMany()
                        .HasForeignKey("CustomInterestAssetInfoId");

                    b.HasOne("ApplicationCore.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomInterestAssetInfo");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CustomInterestAssetInfo", b =>
                {
                    b.HasOne("ApplicationCore.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.RealEstateAsset", b =>
                {
                    b.HasOne("ApplicationCore.Entity.User", "User")
                        .WithMany("RealEstateAssets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApplicationCore.Entity.User", b =>
                {
                    b.Navigation("CashAsset");

                    b.Navigation("RealEstateAssets");
                });
#pragma warning restore 612, 618
        }
    }
}
