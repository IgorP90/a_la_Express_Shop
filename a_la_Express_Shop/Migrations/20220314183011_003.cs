using Microsoft.EntityFrameworkCore.Migrations;

namespace a_la_Express_Shop.Migrations
{
    public partial class _003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "Product_Id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "Order_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Product_Id",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Order_Id",
                table: "Orders",
                newName: "Id");
        }
    }
}
