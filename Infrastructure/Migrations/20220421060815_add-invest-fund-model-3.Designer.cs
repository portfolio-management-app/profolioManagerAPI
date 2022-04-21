﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220421060815_add-invest-fund-model-3")]
    partial class addinvestfundmodel3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("BankCode")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("InputCurrency")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("InputMoneyAmount")
                        .HasColumnType("numeric");

                    b.Property<decimal>("InterestRate")
                        .HasColumnType("numeric");

                    b.Property<bool>("IsGoingToReinState")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.Property<int>("TermRange")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("BankSavingAssets");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CashAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<string>("CurrencyCode")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("CashAssets");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.Crypto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CryptoCoinCode")
                        .HasColumnType("text");

                    b.Property<string>("CurrencyCode")
                        .HasColumnType("text");

                    b.Property<decimal>("CurrentAmountHolding")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("Cryptos");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CustomInterestAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CustomInterestAssetInfoId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("InputCurrency")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("InputMoneyAmount")
                        .HasColumnType("numeric");

                    b.Property<decimal>("InterestRate")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.Property<int>("TermRange")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CustomInterestAssetInfoId");

                    b.HasIndex("PortfolioId");

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

                    b.Property<decimal>("CurrentPrice")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("InputCurrency")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("InputMoneyAmount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("RealEstateAssets");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CurrencyCode")
                        .HasColumnType("text");

                    b.Property<decimal>("CurrentAmountHolding")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("MarketCode")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("numeric");

                    b.Property<string>("StockCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("ApplicationCore.Entity.InvestFund", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("CurrentAmount")
                        .HasColumnType("numeric");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("InvestFunds");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Portfolio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("InitialCash")
                        .HasColumnType("numeric");

                    b.Property<string>("InitialCurrency")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Portfolios");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Transactions.InvestFundTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CurrencyCode")
                        .HasColumnType("text");

                    b.Property<int>("InvestFundId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsIngoing")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ReferentialAssetId")
                        .HasColumnType("integer");

                    b.Property<string>("ReferentialAssetType")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("InvestFundId");

                    b.ToTable("InvestFundTransactions");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Transactions.SingleAssetTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CurrencyCode")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ReferentialAssetId")
                        .HasColumnType("integer");

                    b.Property<string>("ReferentialAssetType")
                        .HasColumnType("text");

                    b.Property<int>("SingleAssetTransactionType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("SingleAssetTransactions");
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
                    b.HasOne("ApplicationCore.Entity.Portfolio", "Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CashAsset", b =>
                {
                    b.HasOne("ApplicationCore.Entity.Portfolio", "Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.Crypto", b =>
                {
                    b.HasOne("ApplicationCore.Entity.Portfolio", "Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CustomInterestAsset", b =>
                {
                    b.HasOne("ApplicationCore.Entity.Asset.CustomInterestAssetInfo", "CustomInterestAssetInfo")
                        .WithMany("CustomInterestAssets")
                        .HasForeignKey("CustomInterestAssetInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entity.Portfolio", "Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomInterestAssetInfo");

                    b.Navigation("Portfolio");
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
                    b.HasOne("ApplicationCore.Entity.Portfolio", "Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.Stock", b =>
                {
                    b.HasOne("ApplicationCore.Entity.Portfolio", "Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("ApplicationCore.Entity.InvestFund", b =>
                {
                    b.HasOne("ApplicationCore.Entity.Portfolio", "Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Portfolio", b =>
                {
                    b.HasOne("ApplicationCore.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Transactions.InvestFundTransaction", b =>
                {
                    b.HasOne("ApplicationCore.Entity.InvestFund", "InvestFund")
                        .WithMany()
                        .HasForeignKey("InvestFundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InvestFund");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CustomInterestAssetInfo", b =>
                {
                    b.Navigation("CustomInterestAssets");
                });
#pragma warning restore 612, 618
        }
    }
}
