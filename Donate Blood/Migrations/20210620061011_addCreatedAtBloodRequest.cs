using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DonateBlood.Migrations
{
    public partial class addCreatedAtBloodRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodRequests_AspNetUsers_UserId",
                table: "BloodRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Inbox_AspNetUsers_UserId",
                table: "Inbox");

            migrationBuilder.DropIndex(
                name: "IX_Inbox_UserId",
                table: "Inbox");

            migrationBuilder.DropIndex(
                name: "IX_BloodRequests_UserId",
                table: "BloodRequests");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Inbox");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BloodRequests");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "BloodRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Inbox_AplicationUserId",
                table: "Inbox",
                column: "AplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodRequests_AplicationUserId",
                table: "BloodRequests",
                column: "AplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BloodRequests_AspNetUsers_AplicationUserId",
                table: "BloodRequests",
                column: "AplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inbox_AspNetUsers_AplicationUserId",
                table: "Inbox",
                column: "AplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodRequests_AspNetUsers_AplicationUserId",
                table: "BloodRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Inbox_AspNetUsers_AplicationUserId",
                table: "Inbox");

            migrationBuilder.DropIndex(
                name: "IX_Inbox_AplicationUserId",
                table: "Inbox");

            migrationBuilder.DropIndex(
                name: "IX_BloodRequests_AplicationUserId",
                table: "BloodRequests");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "BloodRequests");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Inbox",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "BloodRequests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inbox_UserId",
                table: "Inbox",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodRequests_UserId",
                table: "BloodRequests",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BloodRequests_AspNetUsers_UserId",
                table: "BloodRequests",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inbox_AspNetUsers_UserId",
                table: "Inbox",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
