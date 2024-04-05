using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesMVC.Migrations
{
    /// <inheritdoc />
    public partial class SeedTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SelesRecord_Seller_SellerId",
                table: "SelesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SelesRecord",
                table: "SelesRecord");

            migrationBuilder.RenameTable(
                name: "SelesRecord",
                newName: "SalesRecord");

            migrationBuilder.RenameIndex(
                name: "IX_SelesRecord_SellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord");

            migrationBuilder.RenameTable(
                name: "SalesRecord",
                newName: "SelesRecord");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SelesRecord",
                newName: "IX_SelesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SelesRecord",
                table: "SelesRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SelesRecord_Seller_SellerId",
                table: "SelesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
