using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 17, 17, 22, 1, 763, DateTimeKind.Local).AddTicks(2757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 17, 16, 22, 48, 254, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("20c47b1c-ac29-43be-9266-a40c88153d78"), "7b3f172a-6800-481e-9fc6-c14e542575cd", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("2daa5799-db87-4285-a1c0-18939c5b3aae"), new Guid("20c47b1c-ac29-43be-9266-a40c88153d78") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("2daa5799-db87-4285-a1c0-18939c5b3aae"), 0, "da7bfc3d-7ec4-4dec-84a9-d96bda83e079", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyentantrung3006@gmail.com", true, "Trung", "Nguyen", false, null, "nguyentantrung3006@gmail.com", "admin", "AQAAAAEAACcQAAAAECIW9Eo4YyU0Tqnc52TKzkNkbsWAq+t5WyPAAfYecht0Cn/vJfuNK7DFm4oQ9HDBCg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 17, 17, 22, 1, 776, DateTimeKind.Local).AddTicks(3706));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("20c47b1c-ac29-43be-9266-a40c88153d78"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("2daa5799-db87-4285-a1c0-18939c5b3aae"), new Guid("20c47b1c-ac29-43be-9266-a40c88153d78") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2daa5799-db87-4285-a1c0-18939c5b3aae"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 17, 16, 22, 48, 254, DateTimeKind.Local).AddTicks(8890),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 17, 17, 22, 1, 763, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 17, 16, 22, 48, 267, DateTimeKind.Local).AddTicks(6235));
        }
    }
}
