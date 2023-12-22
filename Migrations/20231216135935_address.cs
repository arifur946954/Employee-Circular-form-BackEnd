using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreRelation.Migrations
{
    public partial class address : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "customerAddresses");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "customerAddresses");

            migrationBuilder.CreateTable(
                name: "permanentAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Thana = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permanentAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_permanentAddresses_customerAddresses_CustomerAddressId",
                        column: x => x.CustomerAddressId,
                        principalTable: "customerAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "presentAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Thana = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_presentAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_presentAddress_customerAddresses_CustomerAddressId",
                        column: x => x.CustomerAddressId,
                        principalTable: "customerAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_permanentAddresses_CustomerAddressId",
                table: "permanentAddresses",
                column: "CustomerAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_presentAddress_CustomerAddressId",
                table: "presentAddress",
                column: "CustomerAddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "permanentAddresses");

            migrationBuilder.DropTable(
                name: "presentAddress");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "customerAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "customerAddresses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
