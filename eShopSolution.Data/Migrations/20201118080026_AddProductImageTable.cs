using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 17, 17, 22, 1, 763, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 17, 17, 22, 1, 763, DateTimeKind.Local).AddTicks(2757),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("20c47b1c-ac29-43be-9266-a40c88153d78"),
                column: "ConcurrencyStamp",
                value: "7b3f172a-6800-481e-9fc6-c14e542575cd");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2daa5799-db87-4285-a1c0-18939c5b3aae"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da7bfc3d-7ec4-4dec-84a9-d96bda83e079", "AQAAAAEAACcQAAAAECIW9Eo4YyU0Tqnc52TKzkNkbsWAq+t5WyPAAfYecht0Cn/vJfuNK7DFm4oQ9HDBCg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 17, 17, 22, 1, 776, DateTimeKind.Local).AddTicks(3706));
        }
    }
}
