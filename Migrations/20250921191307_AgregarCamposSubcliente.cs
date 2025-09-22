using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullStackMVC.Migrations
{
    /// <inheritdoc />
    public partial class AgregarCamposSubcliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subclientes_Clientes_ClienteId",
                table: "Subclientes");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Subclientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Subclientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Subclientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Empresa",
                table: "Subclientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Subclientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Subclientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Subclientes_Clientes_ClienteId",
                table: "Subclientes",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subclientes_Clientes_ClienteId",
                table: "Subclientes");

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Subclientes");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Subclientes");

            migrationBuilder.DropColumn(
                name: "Empresa",
                table: "Subclientes");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Subclientes");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Subclientes");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Subclientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Subclientes_Clientes_ClienteId",
                table: "Subclientes",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");
        }
    }
}
