using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("20c47b1c-ac29-43be-9266-a40c88153d78"),
                column: "ConcurrencyStamp",
                value: "23877f55-b169-4cec-ba4c-288db5eb94e0");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2daa5799-db87-4285-a1c0-18939c5b3aae"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0b6a8bf-fe32-49ea-b510-ec68a5a26c56", "AQAAAAEAACcQAAAAEGGjokA6aRGqYmMeRBQDo3qJvL4Bm4iGN7HuKwNMDBn9vA3F+VfeH7YrkA1Q/6iUag==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 18, 16, 18, 41, 589, DateTimeKind.Local).AddTicks(6361));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("20c47b1c-ac29-43be-9266-a40c88153d78"),
                column: "ConcurrencyStamp",
                value: "780c4048-83e2-49bd-b34a-fd147a20ca78");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2daa5799-db87-4285-a1c0-18939c5b3aae"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0b6340e0-4624-4b3e-b2ee-1fe6808e791a", "AQAAAAEAACcQAAAAEMnOoNtQzqXRosDMuhMsCjxkysGKgiI+neXWMxERrsI0Ss+AE2lbvBWYodk623SgAw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 18, 15, 0, 25, 555, DateTimeKind.Local).AddTicks(9851));
        }
    }
}
