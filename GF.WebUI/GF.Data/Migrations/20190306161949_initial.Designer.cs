﻿// <auto-generated />
using System;
using GF.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GF.Data.Migrations
{
    [DbContext(typeof(GFDbContext))]
    [Migration("20190306161949_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GF.Domain.Models.Date", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DayOfEvent");

                    b.Property<string>("Description");

                    b.Property<int>("PlannerId");

                    b.HasKey("Id");

                    b.HasIndex("PlannerId");

                    b.ToTable("Dates");
                });

            modelBuilder.Entity("GF.Domain.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MOTD");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("GF.Domain.Models.GroupJoinTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("GroupJoinTables");
                });

            modelBuilder.Entity("GF.Domain.Models.JoinRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<int>("GroupId");

                    b.Property<int>("JoinRequestStatusId");

                    b.Property<string>("Title");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("JoinRequestStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("JoinRequests");
                });

            modelBuilder.Entity("GF.Domain.Models.JoinRequestStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("JoinRequestStatuses");
                });

            modelBuilder.Entity("GF.Domain.Models.Planner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Planners");
                });

            modelBuilder.Entity("GF.Domain.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("ScreenName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GF.Domain.Models.Date", b =>
                {
                    b.HasOne("GF.Domain.Models.Planner", "Planner")
                        .WithMany()
                        .HasForeignKey("PlannerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GF.Domain.Models.GroupJoinTable", b =>
                {
                    b.HasOne("GF.Domain.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GF.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("GF.Domain.Models.JoinRequest", b =>
                {
                    b.HasOne("GF.Domain.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GF.Domain.Models.JoinRequestStatus", "JoinRequestStatus")
                        .WithMany()
                        .HasForeignKey("JoinRequestStatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GF.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("GF.Domain.Models.Planner", b =>
                {
                    b.HasOne("GF.Domain.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
