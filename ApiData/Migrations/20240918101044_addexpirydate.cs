using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiData.Migrations
{
    /// <inheritdoc />
    public partial class addexpirydate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ExiryDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExiryDateTime",
                table: "Users");
        }
    }
}
