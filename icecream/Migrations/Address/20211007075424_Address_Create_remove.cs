﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace icecream.Migrations.address
{
    public partial class Address_Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    houseNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.id);
                });
            migrationBuilder.CreateTable(
               name: "Order",
               columns: table => new
               {
                   id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   date = table.Column<DateTime>(type: "datetime2", nullable: false),
                   houseNumber = table.Column<int>(type: "int", nullable: false),
                   icecreamId = table.Column<int>(type: "int", nullable: false),
                   temp = table.Column<double>(type: "float", nullable: false),
                   clientFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   humidity = table.Column<double>(type: "float", nullable: false),
                   airPollution = table.Column<double>(type: "float", nullable: false),
                   status = table.Column<string>(type: "nvarchar(max)", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Order", x => x.id);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");
            migrationBuilder.DropTable(
               name: "Order");
        }
    }
}
