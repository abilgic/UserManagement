using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagement.Migrations
{
    public partial class usermanagementdb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserPasswords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserIdentityCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserPasswords_UserId",
                table: "UserPasswords",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserIdentityCards_UserId",
                table: "UserIdentityCards",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserIdentityCards_Users_UserId",
                table: "UserIdentityCards",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPasswords_Users_UserId",
                table: "UserPasswords",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserIdentityCards_Users_UserId",
                table: "UserIdentityCards");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPasswords_Users_UserId",
                table: "UserPasswords");

            migrationBuilder.DropIndex(
                name: "IX_UserPasswords_UserId",
                table: "UserPasswords");

            migrationBuilder.DropIndex(
                name: "IX_UserIdentityCards_UserId",
                table: "UserIdentityCards");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserPasswords");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserIdentityCards");
        }
    }
}
