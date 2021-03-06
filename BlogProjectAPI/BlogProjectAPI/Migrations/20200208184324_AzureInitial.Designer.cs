﻿// <auto-generated />
using System;
using BlogProjectAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogProjectAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200208184324_AzureInitial")]
    partial class AzureInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogProjectAPI.Data.Models.Authors", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorAvatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AuthorCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorSortDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BlogProjectAPI.Data.Models.ExceptionLogs", b =>
                {
                    b.Property<int>("ExceptionLogsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExceptionFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExceptionLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExceptionMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExceptionMethod")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExceptionLogsId");

                    b.ToTable("ExceptionLogs");
                });

            modelBuilder.Entity("BlogProjectAPI.Data.Models.Posts", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<int>("LastUpdatedAuthorId")
                        .HasColumnType("int");

                    b.Property<string>("PostContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCoverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PostPublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PostUpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PostId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("BlogProjectAPI.Data.Models.Roles", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BlogProjectAPI.Data.Models.Tags", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("BlogProjectAPI.Data.Models.TagsOfPosts", b =>
                {
                    b.Property<int>("TagsOfPostsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("TagsOfPostsId");

                    b.HasIndex("PostId");

                    b.HasIndex("TagId");

                    b.ToTable("TagsOfPosts");
                });

            modelBuilder.Entity("BlogProjectAPI.Data.Models.TokenAccessLogs", b =>
                {
                    b.Property<int>("TokenAccessLogsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Access")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccessRequest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AccessTrueFalse")
                        .HasColumnType("bit");

                    b.HasKey("TokenAccessLogsId");

                    b.ToTable("TokenAccessLogs");
                });

            modelBuilder.Entity("BlogProjectAPI.Data.Models.TokenUser", b =>
                {
                    b.Property<int>("TokenUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsSuspended")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TokenUserId");

                    b.HasIndex("RoleId");

                    b.ToTable("TokenUsers");
                });

            modelBuilder.Entity("BlogProjectAPI.Data.Models.Posts", b =>
                {
                    b.HasOne("BlogProjectAPI.Data.Models.Authors", "Authors")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogProjectAPI.Data.Models.TagsOfPosts", b =>
                {
                    b.HasOne("BlogProjectAPI.Data.Models.Posts", "Posts")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogProjectAPI.Data.Models.Tags", "Tags")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogProjectAPI.Data.Models.TokenUser", b =>
                {
                    b.HasOne("BlogProjectAPI.Data.Models.Roles", "Roles")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
