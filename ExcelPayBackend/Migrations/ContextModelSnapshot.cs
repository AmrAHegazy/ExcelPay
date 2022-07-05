﻿// <auto-generated />
using System;
using ExcelPayBackend.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExcelPayBackend.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ExcelPayBackend.models.ClientSecret", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ClientSecrets");
                });

            modelBuilder.Entity("ExcelPayBackend.models.Iframe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("merchantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("merchantId");

                    b.ToTable("Iframes");
                });

            modelBuilder.Entity("ExcelPayBackend.models.Intention", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<Guid?>("ClientSecretId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("MerchantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientSecretId");

                    b.HasIndex("MerchantId");

                    b.ToTable("Intentions");
                });

            modelBuilder.Entity("ExcelPayBackend.models.merchant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecretKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Merchants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Amr",
                            PublicKey = "MEgCQQCow/N0auA7kNHXM8i4XEveHr+b1aGBHrdYAo9tWb51mxDbfHjB5sgdpgIW5EoA39yVzObqQSbTCXldK7zRc52fAgMBAAE=",
                            SecretKey = "MIIBOwIBAAJBAKjD83Rq4DuQ0dczyLhcS94ev5vVoYEet1gCj21ZvnWbENt8eMHmyB2mAhbkSgDf3JXM5upBJtMJeV0rvNFznZ8CAwEAAQJAfzad+H5rolrq4pZFUjs4cSmqc5RYVpVJzQy5AsuoVssc6H6OHDpSaGTimR45d3yz0e6VgBLp4i4+bSj6TyJN6QIhAPDV3aaxMaQKLUQj6i2egCnjYn91/pwSXOhNZemgGnJVAiEAs2RbV3AHnEaiAHNlI3g8c/7isYtMHRAirb4J84ySDCMCIQC3bItmO6ptH3seXKQsnn1Kae5I2ZtTTwEHxHsMFm5OCQIhAI7ORjR992D9jXtEYW/yCFXiwv3JQQcl0CV1UiCyd5T3AiBdDPt0gotUwgI7MMdpaK0rmTiNlZZpkAGH+5Cu94XIZA=="
                        });
                });

            modelBuilder.Entity("ExcelPayBackend.models.Iframe", b =>
                {
                    b.HasOne("ExcelPayBackend.models.merchant", null)
                        .WithMany("Iframes")
                        .HasForeignKey("merchantId");
                });

            modelBuilder.Entity("ExcelPayBackend.models.Intention", b =>
                {
                    b.HasOne("ExcelPayBackend.models.ClientSecret", "ClientSecret")
                        .WithMany()
                        .HasForeignKey("ClientSecretId");

                    b.HasOne("ExcelPayBackend.models.merchant", "Merchant")
                        .WithMany("Intentions")
                        .HasForeignKey("MerchantId");

                    b.Navigation("ClientSecret");

                    b.Navigation("Merchant");
                });

            modelBuilder.Entity("ExcelPayBackend.models.merchant", b =>
                {
                    b.Navigation("Iframes");

                    b.Navigation("Intentions");
                });
#pragma warning restore 612, 618
        }
    }
}