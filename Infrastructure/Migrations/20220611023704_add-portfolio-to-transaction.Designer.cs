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
    [Migration("20220611023704_add-portfolio-to-transaction")]
    partial class addportfoliototransaction
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

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

                    b.Property<decimal>("CurrentPrice")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

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

                    b.Property<bool>("IsDeleted")
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

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

                    b.Property<decimal?>("CurrentPrice")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("InvestFunds");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AssetId")
                        .HasColumnType("integer");

                    b.Property<string>("AssetName")
                        .HasColumnType("text");

                    b.Property<string>("AssetType")
                        .HasColumnType("text");

                    b.Property<string>("CoinCode")
                        .HasColumnType("text");

                    b.Property<string>("Currency")
                        .HasColumnType("text");

                    b.Property<decimal>("HighThreadHoldAmount")
                        .HasColumnType("numeric");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsHighOn")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsLowOn")
                        .HasColumnType("boolean");

                    b.Property<decimal>("LowThreadHoldAmount")
                        .HasColumnType("numeric");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.Property<string>("StockCode")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

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

                    b.Property<decimal?>("AmountInDestinationAssetUnit")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CurrencyCode")
                        .HasColumnType("text");

                    b.Property<decimal?>("Fee")
                        .HasColumnType("numeric");

                    b.Property<int>("InvestFundId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsIngoing")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.Property<int?>("ReferentialAssetId")
                        .HasColumnType("integer");

                    b.Property<string>("ReferentialAssetName")
                        .HasColumnType("text");

                    b.Property<string>("ReferentialAssetType")
                        .HasColumnType("text");

                    b.Property<decimal?>("Tax")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("InvestFundId");

                    b.HasIndex("PortfolioId");

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

                    b.Property<decimal?>("AmountInDestinationAssetUnit")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CurrencyCode")
                        .HasColumnType("text");

                    b.Property<decimal>("DestinationAmount")
                        .HasColumnType("numeric");

                    b.Property<int?>("DestinationAssetId")
                        .HasColumnType("integer");

                    b.Property<string>("DestinationAssetName")
                        .HasColumnType("text");

                    b.Property<string>("DestinationAssetType")
                        .HasColumnType("text");

                    b.Property<string>("DestinationCurrency")
                        .HasColumnType("text");

                    b.Property<decimal?>("Fee")
                        .HasColumnType("numeric");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.Property<int?>("ReferentialAssetId")
                        .HasColumnType("integer");

                    b.Property<string>("ReferentialAssetName")
                        .HasColumnType("text");

                    b.Property<string>("ReferentialAssetType")
                        .HasColumnType("text");

                    b.Property<int>("SingleAssetTransactionType")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Tax")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ApplicationCore.Entity.UserNotification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AssetId")
                        .HasColumnType("integer");

                    b.Property<string>("AssetName")
                        .HasColumnType("text");

                    b.Property<string>("AssetType")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Currency")
                        .HasColumnType("text");

                    b.Property<decimal>("HighThreadHoldAmount")
                        .HasColumnType("numeric");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsRead")
                        .HasColumnType("boolean");

                    b.Property<decimal>("LowThreadHoldAmount")
                        .HasColumnType("numeric");

                    b.Property<string>("NotificationType")
                        .HasColumnType("text");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("UserNotifications");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Utilities.UserMobileFcmCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FcmCode")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("UserMobileFcmCodes");
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

                    b.HasOne("ApplicationCore.Entity.Portfolio", "Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InvestFund");

                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Transactions.SingleAssetTransaction", b =>
                {
                    b.HasOne("ApplicationCore.Entity.Portfolio", "Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CustomInterestAssetInfo", b =>
                {
                    b.Navigation("CustomInterestAssets");
                });
#pragma warning restore 612, 618
        }
    }
}
