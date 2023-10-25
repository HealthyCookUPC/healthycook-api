using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyCook_Backend.Migrations
{
    public partial class v20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Recipes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryID",
                table: "Recipes",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Category_CategoryID",
                table: "Recipes",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Category_CategoryID",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_CategoryID",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Recipes");
        }
    }
}
