using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TicketBook.DataAccessLayer.Migrations
{
    public partial class ChangedFlightTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvaliableTicket",
                table: "Flights",
                newName: "AvailableTicket3");

            migrationBuilder.AddColumn<int>(
                name: "AvailableTicket1",
                table: "Flights",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AvailableTicket2",
                table: "Flights",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TicketPrice1",
                table: "Flights",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TicketPrice2",
                table: "Flights",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TicketPrice3",
                table: "Flights",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableTicket1",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "AvailableTicket2",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "TicketPrice1",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "TicketPrice2",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "TicketPrice3",
                table: "Flights");

            migrationBuilder.RenameColumn(
                name: "AvailableTicket3",
                table: "Flights",
                newName: "AvaliableTicket");
        }
    }
}
