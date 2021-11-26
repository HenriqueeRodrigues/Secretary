using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ClassePessoaSemAsPK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Idade",
                table: "PESSOA");

            migrationBuilder.RenameColumn(
                name: "ÉBatizado",
                table: "PESSOA",
                newName: "Ungido");

            migrationBuilder.AddColumn<bool>(
                name: "Anciao",
                table: "PESSOA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Congregacao",
                table: "PESSOA",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "PESSOA",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Databatismo",
                table: "PESSOA",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "PioneiroRegular",
                table: "PESSOA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ServoMinisterial",
                table: "PESSOA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SobreNome",
                table: "PESSOA",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Anciao",
                table: "PESSOA");

            migrationBuilder.DropColumn(
                name: "Congregacao",
                table: "PESSOA");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "PESSOA");

            migrationBuilder.DropColumn(
                name: "Databatismo",
                table: "PESSOA");

            migrationBuilder.DropColumn(
                name: "PioneiroRegular",
                table: "PESSOA");

            migrationBuilder.DropColumn(
                name: "ServoMinisterial",
                table: "PESSOA");

            migrationBuilder.DropColumn(
                name: "SobreNome",
                table: "PESSOA");

            migrationBuilder.RenameColumn(
                name: "Ungido",
                table: "PESSOA",
                newName: "ÉBatizado");

            migrationBuilder.AddColumn<int>(
                name: "Idade",
                table: "PESSOA",
                type: "int",
                maxLength: 500,
                nullable: false,
                defaultValue: 0);
        }
    }
}
