﻿// <auto-generated />
using BM12;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace BM12Webapplication.Migrations
{
    [DbContext(typeof(IotContext))]
    [Migration("20180201142228_Databaseiskut")]
    partial class Databaseiskut
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BM12.Models.Activity", b =>
                {
                    b.Property<int>("ActivityID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActivityName");

                    b.HasKey("ActivityID");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("BM12.Models.Beacon", b =>
                {
                    b.Property<string>("UID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassRoom");

                    b.Property<string>("FirmwareVersion");

                    b.Property<string>("Modelnumber");

                    b.HasKey("UID");

                    b.ToTable("Beacons");
                });

            modelBuilder.Entity("BM12.Models.Class", b =>
                {
                    b.Property<int>("ClassID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Classname")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("Year")
                        .HasMaxLength(1);

                    b.HasKey("ClassID");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("BM12.Models.ClassCourse", b =>
                {
                    b.Property<int>("ClassCourseID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClassID");

                    b.Property<int>("CourseID");

                    b.HasKey("ClassCourseID");

                    b.HasIndex("ClassID");

                    b.HasIndex("CourseID");

                    b.ToTable("ClassCourse");
                });

            modelBuilder.Entity("BM12.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Blocknumber");

                    b.Property<string>("CourseName")
                        .IsRequired();

                    b.HasKey("CourseID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("BM12.Models.PictureData", b =>
                {
                    b.Property<int>("PictureDataID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Attention");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Emotion");

                    b.HasKey("PictureDataID");

                    b.ToTable("PictureData");
                });

            modelBuilder.Entity("BM12.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Agreement");

                    b.Property<string>("IdentityId");

                    b.HasKey("UserID");

                    b.HasIndex("IdentityId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BM12.Models.UserActivity", b =>
                {
                    b.Property<int>("UserActivityID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActivityID");

                    b.Property<string>("Comment");

                    b.Property<int>("PictureDataID");

                    b.Property<bool>("Presence");

                    b.Property<DateTime>("PresenceDatetime");

                    b.Property<int>("Stars");

                    b.Property<int>("UserID");

                    b.HasKey("UserActivityID");

                    b.HasIndex("ActivityID");

                    b.HasIndex("PictureDataID");

                    b.HasIndex("UserID");

                    b.ToTable("UserActivity");
                });

            modelBuilder.Entity("BM12.Models.UserClass", b =>
                {
                    b.Property<int>("UserClassID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClassID");

                    b.Property<int>("UserID");

                    b.HasKey("UserClassID");

                    b.HasIndex("ClassID");

                    b.HasIndex("UserID");

                    b.ToTable("UserClass");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BM12.Models.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.ToTable("AppUser");

                    b.HasDiscriminator().HasValue("AppUser");
                });

            modelBuilder.Entity("BM12.Models.ClassCourse", b =>
                {
                    b.HasOne("BM12.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BM12.Models.Course", "Course")
                        .WithMany("ClassCourse")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BM12.Models.User", b =>
                {
                    b.HasOne("BM12.Models.AppUser", "Identity")
                        .WithMany()
                        .HasForeignKey("IdentityId");
                });

            modelBuilder.Entity("BM12.Models.UserActivity", b =>
                {
                    b.HasOne("BM12.Models.Activity", "Activity")
                        .WithMany("UserActivity")
                        .HasForeignKey("ActivityID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BM12.Models.PictureData", "PictureData")
                        .WithMany("UserActivity")
                        .HasForeignKey("PictureDataID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BM12.Models.User", "User")
                        .WithMany("UserActivity")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BM12.Models.UserClass", b =>
                {
                    b.HasOne("BM12.Models.Class", "Class")
                        .WithMany("UserClass")
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BM12.Models.User", "User")
                        .WithMany("UserClass")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
