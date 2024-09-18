using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiData.Migrations
{
    /// <inheritdoc />
    public partial class updatetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketNo",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "LaneId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LaneId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "TicketNo",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
