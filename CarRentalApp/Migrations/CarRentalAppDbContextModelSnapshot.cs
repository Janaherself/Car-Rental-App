﻿// <auto-generated />
using System;
using CarRentalApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarRentalApp.Migrations
{
    [DbContext(typeof(CarRentalAppDbContext))]
    partial class CarRentalAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarRentalApp.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("DriversLicenseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "5",
                            AccessFailedCount = 0,
                            AddressLine1 = "123 Main St",
                            City = "New York",
                            ConcurrencyStamp = "eba34bde-488c-4f50-87fb-f00a358e7490",
                            Country = "USA",
                            DriversLicenseNumber = "D123456",
                            Email = "john.doe@example.com",
                            EmailConfirmed = false,
                            FirstName = "John",
                            LastName = "Doe",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b6343510-2c8d-470c-af17-858068487195",
                            TwoFactorEnabled = false,
                            UserName = "john.doe"
                        },
                        new
                        {
                            Id = "6",
                            AccessFailedCount = 0,
                            AddressLine1 = "456 Maple Ave",
                            City = "Los Angeles",
                            ConcurrencyStamp = "9ccdae58-686e-4165-8b7b-d10753335eb9",
                            Country = "USA",
                            DriversLicenseNumber = "D654321",
                            Email = "jane.smith@example.com",
                            EmailConfirmed = false,
                            FirstName = "Jane",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f9ac0278-811e-45b5-bb2d-61fca9b42ec5",
                            TwoFactorEnabled = false,
                            UserName = "jane.smith"
                        });
                });

            modelBuilder.Entity("CarRentalApp.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<DateOnly>("ConfirmedAt")
                        .HasColumnType("date");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingId");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            BookingId = 1,
                            ConfirmedAt = new DateOnly(2023, 10, 31),
                            EndDate = new DateOnly(2023, 11, 5),
                            ReservationId = 1,
                            StartDate = new DateOnly(2023, 11, 1),
                            Status = "Confirmed"
                        },
                        new
                        {
                            BookingId = 2,
                            ConfirmedAt = new DateOnly(2023, 11, 30),
                            EndDate = new DateOnly(2023, 12, 10),
                            ReservationId = 2,
                            StartDate = new DateOnly(2023, 12, 1),
                            Status = "Pending"
                        },
                        new
                        {
                            BookingId = 3,
                            ConfirmedAt = new DateOnly(2023, 12, 31),
                            EndDate = new DateOnly(2024, 1, 5),
                            ReservationId = 3,
                            StartDate = new DateOnly(2024, 1, 1),
                            Status = "Cancelled"
                        },
                        new
                        {
                            BookingId = 4,
                            ConfirmedAt = new DateOnly(2024, 1, 30),
                            EndDate = new DateOnly(2024, 2, 7),
                            ReservationId = 4,
                            StartDate = new DateOnly(2024, 2, 1),
                            Status = "Confirmed"
                        },
                        new
                        {
                            BookingId = 5,
                            ConfirmedAt = new DateOnly(2024, 2, 28),
                            EndDate = new DateOnly(2024, 3, 5),
                            ReservationId = 5,
                            StartDate = new DateOnly(2024, 3, 1),
                            Status = "Pending"
                        });
                });

            modelBuilder.Entity("CarRentalApp.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"));

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PricePerDay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("CarId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            CarId = 1,
                            LicensePlate = "ABC123",
                            Location = "New York",
                            Manufacturer = "Toyota",
                            Model = "Corolla",
                            PricePerDay = 50m,
                            Status = "Available",
                            Year = 2020
                        },
                        new
                        {
                            CarId = 2,
                            LicensePlate = "XYZ789",
                            Location = "Los Angeles",
                            Manufacturer = "Ford",
                            Model = "Focus",
                            PricePerDay = 60m,
                            Status = "Available",
                            Year = 2021
                        },
                        new
                        {
                            CarId = 3,
                            LicensePlate = "DEF456",
                            Location = "Chicago",
                            Manufacturer = "Honda",
                            Model = "Civic",
                            PricePerDay = 55m,
                            Status = "Available",
                            Year = 2019
                        },
                        new
                        {
                            CarId = 4,
                            LicensePlate = "TESLA1",
                            Location = "San Francisco",
                            Manufacturer = "Tesla",
                            Model = "Model 3",
                            PricePerDay = 120m,
                            Status = "Available",
                            Year = 2022
                        },
                        new
                        {
                            CarId = 5,
                            LicensePlate = "CHEVRO",
                            Location = "Houston",
                            Manufacturer = "Chevrolet",
                            Model = "Malibu",
                            PricePerDay = 65m,
                            Status = "Available",
                            Year = 2020
                        });
                });

            modelBuilder.Entity("CarRentalApp.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateOnly>("CreatedAt")
                        .HasColumnType("date");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("ReservationStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("UpdatedAt")
                        .HasColumnType("date");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ReservationId");

                    b.HasIndex("BookingId")
                        .IsUnique();

                    b.HasIndex("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            ReservationId = 1,
                            BookingId = 1,
                            CarId = 1,
                            Cost = 250m,
                            CreatedAt = new DateOnly(2023, 10, 30),
                            EndDate = new DateOnly(2023, 11, 5),
                            ReservationStatus = "Confirmed",
                            StartDate = new DateOnly(2023, 11, 1),
                            UpdatedAt = new DateOnly(2023, 10, 30),
                            UserId = "5"
                        },
                        new
                        {
                            ReservationId = 2,
                            BookingId = 2,
                            CarId = 2,
                            Cost = 600m,
                            CreatedAt = new DateOnly(2023, 11, 29),
                            EndDate = new DateOnly(2023, 12, 10),
                            ReservationStatus = "Pending",
                            StartDate = new DateOnly(2023, 12, 1),
                            UpdatedAt = new DateOnly(2023, 11, 29),
                            UserId = "6"
                        },
                        new
                        {
                            ReservationId = 3,
                            BookingId = 3,
                            CarId = 3,
                            Cost = 275m,
                            CreatedAt = new DateOnly(2023, 12, 31),
                            EndDate = new DateOnly(2024, 1, 5),
                            ReservationStatus = "Cancelled",
                            StartDate = new DateOnly(2024, 1, 1),
                            UpdatedAt = new DateOnly(2023, 12, 31),
                            UserId = "5"
                        },
                        new
                        {
                            ReservationId = 4,
                            BookingId = 4,
                            CarId = 4,
                            Cost = 840m,
                            CreatedAt = new DateOnly(2024, 1, 29),
                            EndDate = new DateOnly(2024, 2, 7),
                            ReservationStatus = "Confirmed",
                            StartDate = new DateOnly(2024, 2, 1),
                            UpdatedAt = new DateOnly(2024, 1, 29),
                            UserId = "6"
                        },
                        new
                        {
                            ReservationId = 5,
                            BookingId = 5,
                            CarId = 5,
                            Cost = 325m,
                            CreatedAt = new DateOnly(2024, 2, 28),
                            EndDate = new DateOnly(2024, 3, 5),
                            ReservationStatus = "Pending",
                            StartDate = new DateOnly(2024, 3, 1),
                            UpdatedAt = new DateOnly(2024, 2, 28),
                            UserId = "5"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CarRentalApp.Models.Reservation", b =>
                {
                    b.HasOne("CarRentalApp.Models.Booking", "Booking")
                        .WithOne("Reservation")
                        .HasForeignKey("CarRentalApp.Models.Reservation", "BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRentalApp.Models.Car", "Car")
                        .WithMany("Reservations")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRentalApp.Models.AppUser", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Car");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CarRentalApp.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CarRentalApp.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRentalApp.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CarRentalApp.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarRentalApp.Models.AppUser", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("CarRentalApp.Models.Booking", b =>
                {
                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("CarRentalApp.Models.Car", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
