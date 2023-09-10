using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DormitoryApi.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c021cae-2b6d-4264-8bc5-3e0d87b9e051");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ea1427f3-4371-456d-9444-1fb7acfea8b6", "b77711ec-60a5-4599-9d33-61e75e8b7a73" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea1427f3-4371-456d-9444-1fb7acfea8b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b77711ec-60a5-4599-9d33-61e75e8b7a73");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17ab37eb-d05d-4981-bdd9-90f1c3e71264", null, "Admin", "ADMIN" },
                    { "fe25a209-4446-4959-9cc6-3217c1a18ea3", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenEndTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6ba44d3b-3fab-406e-95c3-72970926b30d", 0, new DateTime(2023, 9, 10, 7, 56, 53, 398, DateTimeKind.Utc).AddTicks(7267), "a9a34d3c-ba29-4093-b949-6d194c9e2539", "admin@example.com", true, "default", "default", true, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEHzfeANtKxEBVhO4oI0mU38qHdVgG2BGwp3Ze23y+5MtkCIVkdRgQa1iOuv26w05Mg==", null, false, null, null, "bf3a478d-7c43-4e65-b4be-72b0da353424", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[] { "17ab37eb-d05d-4981-bdd9-90f1c3e71264", "6ba44d3b-3fab-406e-95c3-72970926b30d", "AppUserRole" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe25a209-4446-4959-9cc6-3217c1a18ea3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "17ab37eb-d05d-4981-bdd9-90f1c3e71264", "6ba44d3b-3fab-406e-95c3-72970926b30d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17ab37eb-d05d-4981-bdd9-90f1c3e71264");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ba44d3b-3fab-406e-95c3-72970926b30d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c021cae-2b6d-4264-8bc5-3e0d87b9e051", null, "User", "USER" },
                    { "ea1427f3-4371-456d-9444-1fb7acfea8b6", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenEndTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b77711ec-60a5-4599-9d33-61e75e8b7a73", 0, new DateTime(2023, 9, 10, 7, 44, 27, 584, DateTimeKind.Utc).AddTicks(6180), "9fb93792-ee82-4069-9f02-225a3da37e15", "admin@example.com", true, "default", "default", true, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEKCp4UJwT01u9eQz76veOZdRhKQ4fSFMA4y39xbe3BhqwI4bbpnPk18GZU/LPfQcBw==", null, false, null, null, "69192d23-5373-4958-8c6f-4b0bf736e95d", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[] { "ea1427f3-4371-456d-9444-1fb7acfea8b6", "b77711ec-60a5-4599-9d33-61e75e8b7a73", "AppUserRole" });
        }
    }
}
