﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetBuddy;

namespace PetBuddy.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20191025150555_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

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
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "69eb98f0-cd75-4c89-802d-b36ec6b80317",
                            ConcurrencyStamp = "6b76bd81-e887-4c07-b929-5f9ecf300469",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "0e84fe7a-1d13-4be4-a77b-a7564678b3c3",
                            ConcurrencyStamp = "fe4a6827-0c6f-47d8-a13d-5108a0dd1be5",
                            Name = "Guest",
                            NormalizedName = "GUEST"
                        });
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

            modelBuilder.Entity("PetBuddy.Models.AnimalType", b =>
                {
                    b.Property<long>("AnimalTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("PlaceId");

                    b.Property<string>("Type");

                    b.HasKey("AnimalTypeId");

                    b.HasIndex("PlaceId");

                    b.ToTable("AnimalTypes");
                });

            modelBuilder.Entity("PetBuddy.Models.Pet", b =>
                {
                    b.Property<long>("PetId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PetDescription");

                    b.Property<string>("PetName");

                    b.Property<string>("PetType");

                    b.Property<string>("PetUri");

                    b.Property<string>("UserId");

                    b.HasKey("PetId");

                    b.HasIndex("UserId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("PetBuddy.Models.Place", b =>
                {
                    b.Property<long>("PlaceId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AverageRating");

                    b.Property<string>("City");

                    b.Property<string>("PlaceUri");

                    b.Property<int>("Price");

                    b.Property<string>("UserId");

                    b.HasKey("PlaceId");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("PetBuddy.Models.Review", b =>
                {
                    b.Property<long>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("PlaceId");

                    b.Property<int>("Rating");

                    b.Property<string>("Text");

                    b.Property<string>("UserId");

                    b.HasKey("ReviewId");

                    b.HasIndex("PlaceId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("PetBuddy.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

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

                    b.Property<string>("UserUri");

                    b.Property<long>("placeId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
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
                    b.HasOne("PetBuddy.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PetBuddy.Models.User")
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

                    b.HasOne("PetBuddy.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PetBuddy.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PetBuddy.Models.AnimalType", b =>
                {
                    b.HasOne("PetBuddy.Models.Place")
                        .WithMany("Animals")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PetBuddy.Models.Pet", b =>
                {
                    b.HasOne("PetBuddy.Models.User")
                        .WithMany("Pets")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("PetBuddy.Models.Review", b =>
                {
                    b.HasOne("PetBuddy.Models.Place")
                        .WithMany("Reviews")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
