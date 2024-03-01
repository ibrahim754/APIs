using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiDemo.Migrations
{
    /// <inheritdoc />
    public partial class Updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "agency",
                table: "Emps",
                newName: "age");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Emps",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "age",
                table: "Emps",
                newName: "agency");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Emps",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);
        }
    }
}
