using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiData.Migrations
{
    /// <inheritdoc />
    public partial class addexpirydt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExiryDateTime",
                table: "Users",
                newName: "ExpiryDateTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpiryDateTime",
                table: "Users",
                newName: "ExiryDateTime");
        }
    }
}
