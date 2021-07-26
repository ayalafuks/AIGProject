using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class UpdateLacture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Lectures",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_CategoryId",
                table: "Lectures",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_Categories_CategoryId",
                table: "Lectures",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_Categories_CategoryId",
                table: "Lectures");

            migrationBuilder.DropIndex(
                name: "IX_Lectures_CategoryId",
                table: "Lectures");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Lectures",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }
    }
}
