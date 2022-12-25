using Microsoft.EntityFrameworkCore.Migrations;

namespace Books.Migrations
{
    public partial class delete_user_ratting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rattings_AspNetUsers_UserId",
                table: "Rattings");

            migrationBuilder.DropIndex(
                name: "IX_Rattings_UserId",
                table: "Rattings");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Rattings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Rattings",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rattings_UserId",
                table: "Rattings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rattings_AspNetUsers_UserId",
                table: "Rattings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
