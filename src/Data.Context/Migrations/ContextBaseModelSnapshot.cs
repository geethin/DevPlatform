﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Data.Context.Migrations
{
    [DbContext(typeof(ContextBase))]
    partial class ContextBaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("AccountRole", b =>
                {
                    b.Property<Guid>("AccountsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RolesId")
                        .HasColumnType("uuid");

                    b.HasKey("AccountsId", "RolesId");

                    b.HasIndex("RolesId");

                    b.ToTable("AccountRole");
                });

            modelBuilder.Entity("Core.Entity.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Avatar")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(120)
                        .HasColumnType("character varying(120)");

                    b.Property<bool>("EmailConfirm")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ExtendId")
                        .HasColumnType("uuid");

                    b.Property<string>("HashSalt")
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LastLoginTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Password")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<string>("Phone")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<bool>("PhoneConfirm")
                        .HasColumnType("boolean");

                    b.Property<int>("RetryCount")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Username")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedTime");

                    b.HasIndex("Email");

                    b.HasIndex("EmailConfirm");

                    b.HasIndex("ExtendId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("Phone");

                    b.HasIndex("PhoneConfirm");

                    b.HasIndex("Username");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Core.Entity.AccountExtend", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("AddressDetail")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTimeOffset?>("Birthday")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("City")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Country")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("County")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NickName")
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<string>("Province")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("RealName")
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Street")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<DateTimeOffset>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("WXAvatar")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("WXOpenId")
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<string>("WXUnionId")
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.HasKey("Id");

                    b.HasIndex("City");

                    b.HasIndex("Country");

                    b.HasIndex("Province");

                    b.HasIndex("RealName");

                    b.ToTable("AccountExtends");
                });

            modelBuilder.Entity("Core.Entity.Catalog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<short>("Level")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uuid");

                    b.Property<short>("Sort")
                        .HasColumnType("smallint");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTimeOffset>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("Level");

                    b.HasIndex("Name");

                    b.HasIndex("ParentId");

                    b.HasIndex("Sort");

                    b.HasIndex("Type");

                    b.ToTable("Catalogs");
                });

            modelBuilder.Entity("Core.Entity.CodeSnippet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("CodeType")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<int>("Language")
                        .HasColumnType("integer");

                    b.Property<Guid?>("LibraryId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CodeType");

                    b.HasIndex("CreatedTime");

                    b.HasIndex("Language");

                    b.HasIndex("LibraryId");

                    b.HasIndex("Name");

                    b.HasIndex("Status");

                    b.ToTable("CodeSnippets");
                });

            modelBuilder.Entity("Core.Entity.Library", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CatalogId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsValid")
                        .HasColumnType("boolean");

                    b.Property<string>("Language")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Namespace")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CatalogId");

                    b.HasIndex("CreatedTime");

                    b.HasIndex("IsPublic");

                    b.HasIndex("IsValid");

                    b.HasIndex("Language");

                    b.HasIndex("Namespace");

                    b.HasIndex("UserId");

                    b.ToTable("Libraries");
                });

            modelBuilder.Entity("Core.Entity.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Icon")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.HasIndex("Status");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("AccountRole", b =>
                {
                    b.HasOne("Core.Entity.Account", null)
                        .WithMany()
                        .HasForeignKey("AccountsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entity.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Entity.Account", b =>
                {
                    b.HasOne("Core.Entity.AccountExtend", "Extend")
                        .WithMany()
                        .HasForeignKey("ExtendId");

                    b.Navigation("Extend");
                });

            modelBuilder.Entity("Core.Entity.Catalog", b =>
                {
                    b.HasOne("Core.Entity.Account", "Account")
                        .WithMany("Catalogs")
                        .HasForeignKey("AccountId");

                    b.HasOne("Core.Entity.Catalog", "Parent")
                        .WithMany("Catalogs")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Core.Entity.CodeSnippet", b =>
                {
                    b.HasOne("Core.Entity.Library", "Library")
                        .WithMany("Snippets")
                        .HasForeignKey("LibraryId");

                    b.Navigation("Library");
                });

            modelBuilder.Entity("Core.Entity.Library", b =>
                {
                    b.HasOne("Core.Entity.Catalog", "Catalog")
                        .WithMany("Libs")
                        .HasForeignKey("CatalogId");

                    b.HasOne("Core.Entity.Account", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Catalog");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Entity.Account", b =>
                {
                    b.Navigation("Catalogs");
                });

            modelBuilder.Entity("Core.Entity.Catalog", b =>
                {
                    b.Navigation("Catalogs");

                    b.Navigation("Libs");
                });

            modelBuilder.Entity("Core.Entity.Library", b =>
                {
                    b.Navigation("Snippets");
                });
#pragma warning restore 612, 618
        }
    }
}
