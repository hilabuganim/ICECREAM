using Microsoft.EntityFrameworkCore.Migrations;

namespace icecream.Migrations.Order
{
    public partial class order_Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "address",
                table: "Order",
                newName: "icecreamId");

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "houseNumber",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "street",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "city",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "houseNumber",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "street",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "icecreamId",
                table: "Order",
                newName: "address");
        }
    }
}
