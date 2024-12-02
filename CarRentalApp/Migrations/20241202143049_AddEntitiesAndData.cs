using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalApp.Migrations
{
    /// <inheritdoc />
    public partial class AddEntitiesAndData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmedAt = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PricePerDay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ReservationStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateOnly>(type: "date", nullable: false),
                    UpdatedAt = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Country", "DateOfBirth", "DriversLicenseNumber", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5", 0, "123 Main St", null, "New York", "eba34bde-488c-4f50-87fb-f00a358e7490", "USA", null, "D123456", "john.doe@example.com", false, "John", "Doe", false, null, null, null, null, null, false, "b6343510-2c8d-470c-af17-858068487195", false, "john.doe" },
                    { "6", 0, "456 Maple Ave", null, "Los Angeles", "9ccdae58-686e-4165-8b7b-d10753335eb9", "USA", null, "D654321", "jane.smith@example.com", false, "Jane", "Smith", false, null, null, null, null, null, false, "f9ac0278-811e-45b5-bb2d-61fca9b42ec5", false, "jane.smith" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "ConfirmedAt", "EndDate", "ReservationId", "StartDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateOnly(2023, 10, 31), new DateOnly(2023, 11, 5), 1, new DateOnly(2023, 11, 1), "Confirmed" },
                    { 2, new DateOnly(2023, 11, 30), new DateOnly(2023, 12, 10), 2, new DateOnly(2023, 12, 1), "Pending" },
                    { 3, new DateOnly(2023, 12, 31), new DateOnly(2024, 1, 5), 3, new DateOnly(2024, 1, 1), "Cancelled" },
                    { 4, new DateOnly(2024, 1, 30), new DateOnly(2024, 2, 7), 4, new DateOnly(2024, 2, 1), "Confirmed" },
                    { 5, new DateOnly(2024, 2, 28), new DateOnly(2024, 3, 5), 5, new DateOnly(2024, 3, 1), "Pending" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "LicensePlate", "Location", "Manufacturer", "Model", "PricePerDay", "Status", "Year" },
                values: new object[,]
                {
                    { 1, "ABC123", "New York", "Toyota", "Corolla", 50m, "Available", 2020 },
                    { 2, "XYZ789", "Los Angeles", "Ford", "Focus", 60m, "Available", 2021 },
                    { 3, "DEF456", "Chicago", "Honda", "Civic", 55m, "Available", 2019 },
                    { 4, "TESLA1", "San Francisco", "Tesla", "Model 3", 120m, "Available", 2022 },
                    { 5, "CHEVRO", "Houston", "Chevrolet", "Malibu", 65m, "Available", 2020 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "BookingId", "CarId", "Cost", "CreatedAt", "EndDate", "ReservationStatus", "StartDate", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1, 250m, new DateOnly(2023, 10, 30), new DateOnly(2023, 11, 5), "Confirmed", new DateOnly(2023, 11, 1), new DateOnly(2023, 10, 30), "5" },
                    { 2, 2, 2, 600m, new DateOnly(2023, 11, 29), new DateOnly(2023, 12, 10), "Pending", new DateOnly(2023, 12, 1), new DateOnly(2023, 11, 29), "6" },
                    { 3, 3, 3, 275m, new DateOnly(2023, 12, 31), new DateOnly(2024, 1, 5), "Cancelled", new DateOnly(2024, 1, 1), new DateOnly(2023, 12, 31), "5" },
                    { 4, 4, 4, 840m, new DateOnly(2024, 1, 29), new DateOnly(2024, 2, 7), "Confirmed", new DateOnly(2024, 2, 1), new DateOnly(2024, 1, 29), "6" },
                    { 5, 5, 5, 325m, new DateOnly(2024, 2, 28), new DateOnly(2024, 3, 5), "Pending", new DateOnly(2024, 3, 1), new DateOnly(2024, 2, 28), "5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_BookingId",
                table: "Reservations",
                column: "BookingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CarId",
                table: "Reservations",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");
        }
    }
}
