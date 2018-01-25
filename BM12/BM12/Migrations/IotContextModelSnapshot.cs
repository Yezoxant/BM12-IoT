﻿// <auto-generated />
using BM12;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BM12Webapplication.Migrations
{
    [DbContext(typeof(IotContext))]
    partial class IotContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Classname")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("Year")
                        .HasMaxLength(1);

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("BM12.Models.FeedbackAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("FeedbackQuestionId");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Stars");

                    b.Property<int?>("userId");

                    b.HasKey("Id");

                    b.HasIndex("FeedbackQuestionId");

                    b.HasIndex("userId");

                    b.ToTable("Feedbackanswers");
                });

            modelBuilder.Entity("BM12.Models.FeedbackQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Question")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("FeedbackQuestions");
                });

            modelBuilder.Entity("BM12.Models.PictureData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Attention");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Emotion");

                    b.Property<DateTime>("Time");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PictureData");
                });

            modelBuilder.Entity("BM12.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Agreement");

                    b.Property<int?>("ClassId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BM12.Models.UserPresence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Course")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CourseActivity")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("Time");

                    b.Property<int>("Week")
                        .HasMaxLength(2);

                    b.Property<int?>("userId");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("Userpresence");
                });

            modelBuilder.Entity("BM12.Models.FeedbackAnswer", b =>
                {
                    b.HasOne("BM12.Models.FeedbackQuestion", "FeedbackQuestion")
                        .WithMany("FeedbackAnswer")
                        .HasForeignKey("FeedbackQuestionId");

                    b.HasOne("BM12.Models.User", "user")
                        .WithMany("FeedbackAnswer")
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("BM12.Models.PictureData", b =>
                {
                    b.HasOne("BM12.Models.User", "User")
                        .WithMany("PictureData")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BM12.Models.User", b =>
                {
                    b.HasOne("BM12.Models.Class", "Class")
                        .WithMany("Users")
                        .HasForeignKey("ClassId");
                });

            modelBuilder.Entity("BM12.Models.UserPresence", b =>
                {
                    b.HasOne("BM12.Models.User", "user")
                        .WithMany("UserPresence")
                        .HasForeignKey("userId");
                });
#pragma warning restore 612, 618
        }
    }
}
