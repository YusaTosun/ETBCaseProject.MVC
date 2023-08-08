using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ETBCaseProject.Repository.Migrations
{
    /// <inheritdoc />
    public partial class DeletedColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "DeletedDate", "FullName", "MailAddress", "PhoneNumber", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1993, 8, 8, 20, 42, 1, 83, DateTimeKind.Local).AddTicks(9199), new DateTime(2023, 8, 8, 20, 42, 1, 83, DateTimeKind.Local).AddTicks(9221), null, "Mehmet Yılmaz", "mehmetyilmaz@gmail.com", "05334567891", null },
                    { 2, new DateTime(1998, 8, 8, 20, 42, 1, 83, DateTimeKind.Local).AddTicks(9225), new DateTime(2023, 8, 8, 20, 42, 1, 83, DateTimeKind.Local).AddTicks(9226), null, "Cenk Kılıç", "cenkkilic@gmail.com", "05354577891", null },
                    { 3, new DateTime(1983, 8, 8, 20, 42, 1, 83, DateTimeKind.Local).AddTicks(9228), new DateTime(2023, 8, 8, 20, 42, 1, 83, DateTimeKind.Local).AddTicks(9229), null, "Mehmet Yılmaz", "mehmetyilmaz@gmail.com", "05334578681", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
