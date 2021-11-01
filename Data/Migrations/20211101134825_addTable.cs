using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Produts_ProductsProductId",
                table: "ProductProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Providers_ProvidersId",
                table: "ProductProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_Produts_categories_CategoryId",
                table: "Produts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductProvider",
                table: "ProductProvider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "StreetAdress",
                table: "Produts");

            migrationBuilder.RenameTable(
                name: "ProductProvider",
                newName: "Product_provider");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "MyCategories");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Produts",
                newName: "MyCity");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProvider_ProvidersId",
                table: "Product_provider",
                newName: "IX_Product_provider_ProvidersId");

            migrationBuilder.AddColumn<string>(
                name: "MyAdress",
                table: "Produts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MyCategories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product_provider",
                table: "Product_provider",
                columns: new[] { "ProductsProductId", "ProvidersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyCategories",
                table: "MyCategories",
                column: "CategoryId");

            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    Cin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateNaissence = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.Cin);
                });

            migrationBuilder.CreateTable(
                name: "factures",
                columns: table => new
                {
                    ProductFk = table.Column<int>(type: "int", nullable: false),
                    ClientFk = table.Column<int>(type: "int", nullable: false),
                    DateAchat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    prix = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_factures", x => new { x.ProductFk, x.ClientFk, x.DateAchat });
                    table.ForeignKey(
                        name: "FK_factures_clients_ClientFk",
                        column: x => x.ClientFk,
                        principalTable: "clients",
                        principalColumn: "Cin",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_factures_Produts_ProductFk",
                        column: x => x.ProductFk,
                        principalTable: "Produts",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_factures_ClientFk",
                table: "factures",
                column: "ClientFk");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_provider_Produts_ProductsProductId",
                table: "Product_provider",
                column: "ProductsProductId",
                principalTable: "Produts",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_provider_Providers_ProvidersId",
                table: "Product_provider",
                column: "ProvidersId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produts_MyCategories_CategoryId",
                table: "Produts",
                column: "CategoryId",
                principalTable: "MyCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_provider_Produts_ProductsProductId",
                table: "Product_provider");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_provider_Providers_ProvidersId",
                table: "Product_provider");

            migrationBuilder.DropForeignKey(
                name: "FK_Produts_MyCategories_CategoryId",
                table: "Produts");

            migrationBuilder.DropTable(
                name: "factures");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product_provider",
                table: "Product_provider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyCategories",
                table: "MyCategories");

            migrationBuilder.DropColumn(
                name: "MyAdress",
                table: "Produts");

            migrationBuilder.RenameTable(
                name: "Product_provider",
                newName: "ProductProvider");

            migrationBuilder.RenameTable(
                name: "MyCategories",
                newName: "categories");

            migrationBuilder.RenameColumn(
                name: "MyCity",
                table: "Produts",
                newName: "City");

            migrationBuilder.RenameIndex(
                name: "IX_Product_provider_ProvidersId",
                table: "ProductProvider",
                newName: "IX_ProductProvider_ProvidersId");

            migrationBuilder.AddColumn<string>(
                name: "StreetAdress",
                table: "Produts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductProvider",
                table: "ProductProvider",
                columns: new[] { "ProductsProductId", "ProvidersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                table: "categories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Produts_ProductsProductId",
                table: "ProductProvider",
                column: "ProductsProductId",
                principalTable: "Produts",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Providers_ProvidersId",
                table: "ProductProvider",
                column: "ProvidersId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produts_categories_CategoryId",
                table: "Produts",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
