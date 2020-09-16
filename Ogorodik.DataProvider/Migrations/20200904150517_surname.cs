﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Ogorodik.DataProvider.Migrations
{
    public partial class surname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Orders");
        }
    }
}
