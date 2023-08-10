using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ETBCaseProject.Repository.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                columns: new[] { "Id", "BirthDate", "CreatedDate", "DeletedDate", "MailAddress", "Name", "PhoneNumber", "Surname", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1993, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1492), new DateTime(2023, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1520), null, "mehmetyilmaz@gmail.com", "Mehmet", "05334567891", "Yıldırım", null },
                    { 2, new DateTime(1998, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1524), new DateTime(2023, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1525), null, "cenkkilic@gmail.com", "Cenk", "05354577891", "Kılıç", null },
                    { 3, new DateTime(1983, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1529), new DateTime(2023, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1530), null, "cerenanac@gmail.com", "Ceren", "05334578681", "Anaç", null },
                    { 4, new DateTime(1983, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1532), new DateTime(2023, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1534), null, "mertaltin@gmail.com", "Mert", "05334578681", "Altın", null },
                    { 5, new DateTime(1983, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1536), new DateTime(2023, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1537), null, "hüseyindagli@gmail.com", "Hüseyin", "05334578681", "Dağlı", null },
                    { 6, new DateTime(1983, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1540), new DateTime(2023, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1541), null, "buseeren@gmail.com", "Buse", "05334578681", "Eren", null }
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
