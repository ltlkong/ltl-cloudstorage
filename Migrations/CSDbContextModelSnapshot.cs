﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ltl_cloudstorage.Models;

namespace ltl_cloudstorage.Migrations
{
    [DbContext(typeof(CSDbContext))]
    partial class CSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<int>("RolesId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("ltl_cloudstorage.Models.LtlDirectory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int?>("ParentDirId")
                        .HasColumnType("int");

                    b.Property<string>("UniqueId")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("UserInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentDirId");

                    b.HasIndex("UniqueId")
                        .IsUnique();

                    b.HasIndex("UserInfoId");

                    b.ToTable("LtlDirectories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 9, 12, 16, 46, 25, 619, DateTimeKind.Local).AddTicks(5244),
                            Name = "Default",
                            UniqueId = "13c44ee6-0628-4cfc-9690-5c6bfb357df6",
                            UserInfoId = 1
                        });
                });

            modelBuilder.Entity("ltl_cloudstorage.Models.LtlFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DirectoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Path")
                        .HasColumnType("text");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("UniqueId")
                        .HasColumnType("varchar(767)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("DirectoryId");

                    b.HasIndex("UniqueId")
                        .IsUnique();

                    b.ToTable("LtlFiles");
                });

            modelBuilder.Entity("ltl_cloudstorage.Models.Membership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("varchar(600)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Memberships");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "linear-gradient(90deg, rgb(195, 88, 43) 0%, rgb(255, 182, 117) 50%, rgb(195, 88, 43) 100%)",
                            Description = "# Bronze",
                            Name = "Bronze",
                            Price = 10.0
                        },
                        new
                        {
                            Id = 2,
                            Color = "linear-gradient(90deg, rgba(151,150,149,1) 0%, rgba(210,210,210,1) 50%, rgba(151,150,149,1) 100%)",
                            Description = "",
                            Name = "Silver",
                            Price = 15.0
                        },
                        new
                        {
                            Id = 3,
                            Color = "linear-gradient(90deg, rgba(249,194,56,1) 0%, rgba(255,236,188,1) 50%, rgba(249,194,56,1) 100%)",
                            Description = "",
                            Name = "Gold",
                            Price = 20.0
                        });
                });

            modelBuilder.Entity("ltl_cloudstorage.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Role");
                });

            modelBuilder.Entity("ltl_cloudstorage.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<DateTime>("LastLoginAt")
                        .HasColumnType("datetime");

                    b.Property<int?>("MembershipId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("MembershipId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 9, 12, 16, 46, 25, 619, DateTimeKind.Local).AddTicks(1058),
                            DisplayName = "public",
                            Email = "public@public.com",
                            LastLoginAt = new DateTime(2021, 9, 12, 16, 46, 25, 619, DateTimeKind.Local).AddTicks(1077),
                            MembershipId = 1,
                            Name = "public",
                            PasswordHash = "public"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 7, 26, 23, 0, 48, 0, DateTimeKind.Unspecified),
                            DisplayName = "ltl",
                            Email = "tielinli@yahoo.com",
                            LastLoginAt = new DateTime(2021, 7, 27, 8, 19, 4, 0, DateTimeKind.Unspecified),
                            MembershipId = 2,
                            Name = "ltl",
                            PasswordHash = "oIn5JKeGBFsnpRAekK4jTQ=="
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 7, 27, 7, 11, 41, 0, DateTimeKind.Unspecified),
                            DisplayName = "LisaLee",
                            Email = "1248988727@qq.com",
                            LastLoginAt = new DateTime(2021, 7, 27, 7, 11, 41, 0, DateTimeKind.Unspecified),
                            MembershipId = 2,
                            Name = "LisaLee",
                            PasswordHash = "eMoP6zKEDM9eDMEYtFm4VA=="
                        });
                });

            modelBuilder.Entity("ltl_cloudstorage.Models.UserInfo", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Introduction")
                        .HasColumnType("text");

                    b.Property<int>("Reputation")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("UserInfos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 9, 12, 16, 46, 25, 619, DateTimeKind.Local).AddTicks(2375),
                            Introduction = "# Public test user",
                            Reputation = 100,
                            UpdatedAt = new DateTime(2021, 9, 12, 16, 46, 25, 619, DateTimeKind.Local).AddTicks(3384)
                        });
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("ltl_cloudstorage.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ltl_cloudstorage.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ltl_cloudstorage.Models.LtlDirectory", b =>
                {
                    b.HasOne("ltl_cloudstorage.Models.LtlDirectory", "ParentDir")
                        .WithMany("ChildDirs")
                        .HasForeignKey("ParentDirId");

                    b.HasOne("ltl_cloudstorage.Models.UserInfo", "UserInfo")
                        .WithMany("LtlDirectories")
                        .HasForeignKey("UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParentDir");

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("ltl_cloudstorage.Models.LtlFile", b =>
                {
                    b.HasOne("ltl_cloudstorage.Models.LtlDirectory", "Directory")
                        .WithMany("Files")
                        .HasForeignKey("DirectoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Directory");
                });

            modelBuilder.Entity("ltl_cloudstorage.Models.User", b =>
                {
                    b.HasOne("ltl_cloudstorage.Models.Membership", "Membership")
                        .WithMany()
                        .HasForeignKey("MembershipId");

                    b.Navigation("Membership");
                });

            modelBuilder.Entity("ltl_cloudstorage.Models.UserInfo", b =>
                {
                    b.HasOne("ltl_cloudstorage.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ltl_cloudstorage.Models.LtlDirectory", b =>
                {
                    b.Navigation("ChildDirs");

                    b.Navigation("Files");
                });

            modelBuilder.Entity("ltl_cloudstorage.Models.UserInfo", b =>
                {
                    b.Navigation("LtlDirectories");
                });
#pragma warning restore 612, 618
        }
    }
}
