using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TicketBook.DataAccessLayer.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_City_ArrivalCityId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_City_DepartureCityId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Profiles_ProfileId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Order_OrderId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameIndex(
                name: "IX_Order_ProfileId",
                table: "Orders",
                newName: "IX_Orders_ProfileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Cities_ArrivalCityId",
                table: "Flights",
                column: "ArrivalCityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Cities_DepartureCityId",
                table: "Flights",
                column: "DepartureCityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Profiles_ProfileId",
                table: "Orders",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Orders_OrderId",
                table: "Tickets",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Cities_ArrivalCityId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Cities_DepartureCityId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Profiles_ProfileId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Orders_OrderId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ProfileId",
                table: "Order",
                newName: "IX_Order_ProfileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_City_ArrivalCityId",
                table: "Flights",
                column: "ArrivalCityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_City_DepartureCityId",
                table: "Flights",
                column: "DepartureCityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Profiles_ProfileId",
                table: "Order",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Order_OrderId",
                table: "Tickets",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
