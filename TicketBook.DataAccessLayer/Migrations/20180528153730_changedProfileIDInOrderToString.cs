using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TicketBook.DataAccessLayer.Migrations
{
    public partial class changedProfileIDInOrderToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Profiles_ProfileId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Profiles",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Sex",
                table: "Profiles",
                newName: "TwoFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Profiles",
                newName: "SecurityStamp");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Profiles",
                newName: "AccessFailedCount");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Profiles",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Profiles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Profiles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Profiles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "ProfileId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Profiles_ProfileId",
                table: "Orders",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Profiles_ProfileId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Profiles");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Profiles",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "Profiles",
                newName: "Sex");

            migrationBuilder.RenameColumn(
                name: "SecurityStamp",
                table: "Profiles",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "AccessFailedCount",
                table: "Profiles",
                newName: "Age");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Profiles",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "ProfileId",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Profiles_ProfileId",
                table: "Orders",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
