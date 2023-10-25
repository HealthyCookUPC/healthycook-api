using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyCook_Backend.Migrations
{
    public partial class vxd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(25)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consulta");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Recipes",
                type: "int",
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
    }
}
