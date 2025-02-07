﻿// <auto-generated />
using System;
using EntityFramework;
using EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EntityFrameworkCore.Migrations
{
    [DbContext(typeof(ContextBase))]
    [Migration("20210906091427_AddNewsType")]
    partial class AddNewsType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "6.0.0-preview.6.21352.1")
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

            modelBuilder.Entity("Entity.Account", b =>
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

            modelBuilder.Entity("Entity.AccountExtend", b =>
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

            modelBuilder.Entity("Entity.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uuid");

                    b.Property<int>("ArticleType")
                        .HasColumnType("integer");

                    b.Property<string>("AuthorName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<Guid?>("CatalogId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("ExtendId")
                        .HasColumnType("uuid");

                    b.Property<bool?>("IsPrivate")
                        .HasColumnType("boolean");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Summary")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Tags")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTimeOffset>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("ArticleType");

                    b.HasIndex("CatalogId");

                    b.HasIndex("CreatedTime");

                    b.HasIndex("ExtendId");

                    b.HasIndex("Title");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Entity.ArticleCatalog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<short>("Level")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<Guid?>("ParentId")
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

                    b.ToTable("ArticleCatalog");
                });

            modelBuilder.Entity("Entity.ArticleExtend", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("ArticleExtends");
                });

            modelBuilder.Entity("Entity.CodeSnippet", b =>
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

            modelBuilder.Entity("Entity.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ArticleId")
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("ArticleId");

                    b.HasIndex("CreatedTime");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Entity.Library", b =>
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

            modelBuilder.Entity("Entity.LibraryCatalog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<short>("Level")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<Guid?>("ParentId")
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

                    b.ToTable("LibraryCatalogs");
                });

            modelBuilder.Entity("Entity.Role", b =>
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

            modelBuilder.Entity("Entity.ThirdNews", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AuthorAvatar")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("AuthorName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Category")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Content")
                        .HasMaxLength(8000)
                        .HasColumnType("character varying(8000)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DatePublished")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .HasColumnType("character varying(5000)");

                    b.Property<string>("IdentityId")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("NewsType")
                        .HasColumnType("integer");

                    b.Property<string>("Provider")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("ThumbnailUrl")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("Title")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Url")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.HasKey("Id");

                    b.HasIndex("Category");

                    b.HasIndex("DatePublished");

                    b.HasIndex("IdentityId");

                    b.HasIndex("NewsType");

                    b.HasIndex("Provider");

                    b.HasIndex("Title");

                    b.HasIndex("Type");

                    b.ToTable("ThirdNews");
                });

            modelBuilder.Entity("AccountRole", b =>
                {
                    b.HasOne("Entity.Account", null)
                        .WithMany()
                        .HasForeignKey("AccountsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Account", b =>
                {
                    b.HasOne("Entity.AccountExtend", "Extend")
                        .WithMany()
                        .HasForeignKey("ExtendId");

                    b.Navigation("Extend");
                });

            modelBuilder.Entity("Entity.Article", b =>
                {
                    b.HasOne("Entity.Account", "Account")
                        .WithMany("Articles")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.ArticleCatalog", "Catalog")
                        .WithMany("Articles")
                        .HasForeignKey("CatalogId");

                    b.HasOne("Entity.ArticleExtend", "Extend")
                        .WithMany()
                        .HasForeignKey("ExtendId");

                    b.Navigation("Account");

                    b.Navigation("Catalog");

                    b.Navigation("Extend");
                });

            modelBuilder.Entity("Entity.ArticleCatalog", b =>
                {
                    b.HasOne("Entity.Account", "Account")
                        .WithMany("ArticleCatalogs")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.ArticleCatalog", "Parent")
                        .WithMany("Catalogs")
                        .HasForeignKey("ParentId");

                    b.Navigation("Account");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Entity.CodeSnippet", b =>
                {
                    b.HasOne("Entity.Library", "Library")
                        .WithMany("Snippets")
                        .HasForeignKey("LibraryId");

                    b.Navigation("Library");
                });

            modelBuilder.Entity("Entity.Comment", b =>
                {
                    b.HasOne("Entity.Account", "Account")
                        .WithMany("Comments")
                        .HasForeignKey("AccountId");

                    b.HasOne("Entity.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId");

                    b.Navigation("Account");

                    b.Navigation("Article");
                });

            modelBuilder.Entity("Entity.Library", b =>
                {
                    b.HasOne("Entity.LibraryCatalog", "Catalog")
                        .WithMany()
                        .HasForeignKey("CatalogId");

                    b.HasOne("Entity.Account", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Catalog");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entity.LibraryCatalog", b =>
                {
                    b.HasOne("Entity.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.LibraryCatalog", "Parent")
                        .WithMany("Catalogs")
                        .HasForeignKey("ParentId");

                    b.Navigation("Account");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Entity.Account", b =>
                {
                    b.Navigation("ArticleCatalogs");

                    b.Navigation("Articles");

                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Entity.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Entity.ArticleCatalog", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Catalogs");
                });

            modelBuilder.Entity("Entity.Library", b =>
                {
                    b.Navigation("Snippets");
                });

            modelBuilder.Entity("Entity.LibraryCatalog", b =>
                {
                    b.Navigation("Catalogs");
                });
#pragma warning restore 612, 618
        }
    }
}
