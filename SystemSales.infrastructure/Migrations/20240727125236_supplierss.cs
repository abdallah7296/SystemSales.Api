using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemSales.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class supplierss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "suppliers2",
                columns: table => new
                {
                    Suppliers_Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Suppliers_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers2", x => x.Suppliers_Code);
                });

            migrationBuilder.CreateTable(
                name: "suppliersTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Supplier_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Suplier_Invoice_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    voucherDebit = table.Column<double>(type: "float", nullable: true),
                    voucherCredit = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    record_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    supplier_Code = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliersTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_suppliersTransactions_suppliers2_supplier_Code",
                        column: x => x.supplier_Code,
                        principalTable: "suppliers2",
                        principalColumn: "Suppliers_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_suppliersTransactions_supplier_Code",
                table: "suppliersTransactions",
                column: "supplier_Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "suppliersTransactions");

            migrationBuilder.DropTable(
                name: "suppliers2");
        }
    }
}
