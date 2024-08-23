using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemSales.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class cust2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customerTransactions_mainCustomers_Customer_Code",
                table: "customerTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mainCustomers",
                table: "mainCustomers");

            migrationBuilder.RenameTable(
                name: "mainCustomers",
                newName: "customers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customers",
                table: "customers",
                column: "CustomerCode");

            migrationBuilder.AddForeignKey(
                name: "FK_customerTransactions_customers_Customer_Code",
                table: "customerTransactions",
                column: "Customer_Code",
                principalTable: "customers",
                principalColumn: "CustomerCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customerTransactions_customers_Customer_Code",
                table: "customerTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customers",
                table: "customers");

            migrationBuilder.RenameTable(
                name: "customers",
                newName: "mainCustomers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mainCustomers",
                table: "mainCustomers",
                column: "CustomerCode");

            migrationBuilder.AddForeignKey(
                name: "FK_customerTransactions_mainCustomers_Customer_Code",
                table: "customerTransactions",
                column: "Customer_Code",
                principalTable: "mainCustomers",
                principalColumn: "CustomerCode");
        }
    }
}
