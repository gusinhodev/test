using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullStackMVC.Migrations
{
    /// <inheritdoc />
    public partial class EliminarCampoApellido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Subclientes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Subclientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
