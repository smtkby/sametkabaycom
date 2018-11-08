﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SametKabay.Core;

namespace SametKabay.Core.Migrations
{
    [DbContext(typeof(SametKabayDbContext))]
    [Migration("20181106184846_UniqueValueAdded")]
    partial class UniqueValueAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SametKabay.Core.Models.BlogCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ActivatedUserId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<int?>("CreatorUserId");

                    b.Property<int?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionDate");

                    b.Property<string>("Detail")
                        .HasMaxLength(256);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifierUserId");

                    b.Property<DateTime?>("ModifyDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int?>("ParentId");

                    b.Property<string>("PictureUrl")
                        .HasMaxLength(1024);

                    b.Property<string>("SafeName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("ActivatedUserId");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("DeleterUserId");

                    b.HasIndex("ModifierUserId");

                    b.HasIndex("ParentId");

                    b.ToTable("BlogCategories");
                });

            modelBuilder.Entity("SametKabay.Core.Models.BlogComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ActivatedUserId");

                    b.Property<int?>("BlogPostId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<int?>("CreatorUserId");

                    b.Property<int?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifierUserId");

                    b.Property<DateTime?>("ModifyDate");

                    b.Property<int?>("ParentId");

                    b.Property<string>("Text")
                        .HasMaxLength(1024);

                    b.HasKey("Id");

                    b.HasIndex("ActivatedUserId");

                    b.HasIndex("BlogPostId");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("DeleterUserId");

                    b.HasIndex("ModifierUserId");

                    b.HasIndex("ParentId");

                    b.ToTable("BlogComments");
                });

            modelBuilder.Entity("SametKabay.Core.Models.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ActivatedUserId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<int?>("CreatorUserId");

                    b.Property<int?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionDate");

                    b.Property<string>("Detail")
                        .HasMaxLength(256);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifierUserId");

                    b.Property<DateTime?>("ModifyDate");

                    b.Property<string>("PictureUrl")
                        .HasMaxLength(1024);

                    b.Property<string>("SafeTitle")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("ActivatedUserId");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("DeleterUserId");

                    b.HasIndex("ModifierUserId");

                    b.ToTable("BlogPosts");
                });

            modelBuilder.Entity("SametKabay.Core.Models.BlogPostCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<int>("PostId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PostId");

                    b.ToTable("BlogPostCategories");
                });

            modelBuilder.Entity("SametKabay.Core.Models.BlogPostTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BlogPostId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Text")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("BlogPostId");

                    b.ToTable("BlogPostTags");
                });

            modelBuilder.Entity("SametKabay.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasMaxLength(512);

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime?>("DeletionDate");

                    b.Property<string>("Email");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifyDate");

                    b.Property<string>("Name")
                        .HasMaxLength(32);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PasswordSalt");

                    b.Property<string>("Phone");

                    b.Property<string>("PictureUrl")
                        .HasMaxLength(1024);

                    b.Property<string>("Surname")
                        .HasMaxLength(32);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SametKabay.Core.Models.BlogCategory", b =>
                {
                    b.HasOne("SametKabay.Core.Models.User", "ActivatedUser")
                        .WithMany()
                        .HasForeignKey("ActivatedUserId");

                    b.HasOne("SametKabay.Core.Models.User", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId");

                    b.HasOne("SametKabay.Core.Models.User", "DeleterUser")
                        .WithMany()
                        .HasForeignKey("DeleterUserId");

                    b.HasOne("SametKabay.Core.Models.User", "ModifierUser")
                        .WithMany()
                        .HasForeignKey("ModifierUserId");

                    b.HasOne("SametKabay.Core.Models.BlogCategory", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("SametKabay.Core.Models.BlogComment", b =>
                {
                    b.HasOne("SametKabay.Core.Models.User", "ActivatedUser")
                        .WithMany()
                        .HasForeignKey("ActivatedUserId");

                    b.HasOne("SametKabay.Core.Models.BlogPost")
                        .WithMany("Comments")
                        .HasForeignKey("BlogPostId");

                    b.HasOne("SametKabay.Core.Models.User", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId");

                    b.HasOne("SametKabay.Core.Models.User", "DeleterUser")
                        .WithMany()
                        .HasForeignKey("DeleterUserId");

                    b.HasOne("SametKabay.Core.Models.User", "ModifierUser")
                        .WithMany()
                        .HasForeignKey("ModifierUserId");

                    b.HasOne("SametKabay.Core.Models.BlogComment", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("SametKabay.Core.Models.BlogPost", b =>
                {
                    b.HasOne("SametKabay.Core.Models.User", "ActivatedUser")
                        .WithMany()
                        .HasForeignKey("ActivatedUserId");

                    b.HasOne("SametKabay.Core.Models.User", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId");

                    b.HasOne("SametKabay.Core.Models.User", "DeleterUser")
                        .WithMany()
                        .HasForeignKey("DeleterUserId");

                    b.HasOne("SametKabay.Core.Models.User", "ModifierUser")
                        .WithMany()
                        .HasForeignKey("ModifierUserId");
                });

            modelBuilder.Entity("SametKabay.Core.Models.BlogPostCategory", b =>
                {
                    b.HasOne("SametKabay.Core.Models.BlogCategory", "Category")
                        .WithMany("PostCategory")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SametKabay.Core.Models.BlogPost", "Post")
                        .WithMany("PostCategory")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SametKabay.Core.Models.BlogPostTag", b =>
                {
                    b.HasOne("SametKabay.Core.Models.BlogPost")
                        .WithMany("Tags")
                        .HasForeignKey("BlogPostId");
                });
#pragma warning restore 612, 618
        }
    }
}
