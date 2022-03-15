using Microsoft.EntityFrameworkCore.Migrations;

namespace a_la_Express_Shop.Migrations
{
    public partial class Add_Product_Id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Product_Id",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product_Id",
                table: "Orders");
        }
    }
}
