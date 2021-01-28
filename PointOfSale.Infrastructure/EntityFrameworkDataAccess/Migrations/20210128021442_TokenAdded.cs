using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSale.Infrastructure.EntityFrameworkDataAccess.Migrations
{
    public partial class TokenAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Token",
                table: "Product",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Token",
                table: "Organization",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Token",
                table: "Catalog",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Token",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Organization");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Catalog");
        }
    }
}
