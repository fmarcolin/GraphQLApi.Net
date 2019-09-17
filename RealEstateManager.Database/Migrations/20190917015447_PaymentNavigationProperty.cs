﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateManager.Database.Migrations
{
    public partial class PaymentNavigationProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Properties_PropertyId",
                table: "Payments");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyId",
                table: "Payments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Properties_PropertyId",
                table: "Payments",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Properties_PropertyId",
                table: "Payments");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyId",
                table: "Payments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Properties_PropertyId",
                table: "Payments",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
