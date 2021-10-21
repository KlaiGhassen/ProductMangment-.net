using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class enableAnnotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produts_categories_MyCategoryCategoryId",
                table: "Produts");

            migrationBuilder.DropIndex(
                name: "IX_Produts_MyCategoryCategoryId",
                table: "Produts");

            migrationBuilder.DropColumn(
                name: "ConfirmedPassword",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "MyCategoryCategoryId",
                table: "Produts");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Produts",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Produts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produts_CategoryId",
                table: "Produts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produts_categories_CategoryId",
                table: "Produts",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produts_categories_CategoryId",
                table: "Produts");

            migrationBuilder.DropIndex(
                name: "IX_Produts_CategoryId",
                table: "Produts");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Produts");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmedPassword",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Produts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AddColumn<int>(
                name: "MyCategoryCategoryId",
                table: "Produts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produts_MyCategoryCategoryId",
                table: "Produts",
                column: "MyCategoryCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produts_categories_MyCategoryCategoryId",
                table: "Produts",
                column: "MyCategoryCategoryId",
                principalTable: "categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
