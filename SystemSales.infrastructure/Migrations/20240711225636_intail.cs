using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemSales.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class intail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mainCurrencies",
                columns: table => new
                {
                    MainCurrencyCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MainCurrencyId = table.Column<int>(type: "int", nullable: false),
                    CurrencyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SingleCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectionCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SingleDecimalCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecimalCategoryPlural = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberDecimalPoints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mainCurrencies", x => x.MainCurrencyCode);
                });

            migrationBuilder.CreateTable(
                name: "mainCustomers",
                columns: table => new
                {
                    MainCustomerCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Enterprise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommercialRegister = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mainCurrencyCode = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mainCustomers", x => x.MainCustomerCode);
                    table.ForeignKey(
                        name: "FK_mainCustomers_mainCurrencies_mainCurrencyCode",
                        column: x => x.mainCurrencyCode,
                        principalTable: "mainCurrencies",
                        principalColumn: "MainCurrencyCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "subCurrencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConversionFactor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainCurrencyCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subCurrencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subCurrencies_mainCurrencies_MainCurrencyCode",
                        column: x => x.MainCurrencyCode,
                        principalTable: "mainCurrencies",
                        principalColumn: "MainCurrencyCode");
                });

            migrationBuilder.CreateTable(
                name: "subCustomers",
                columns: table => new
                {
                    SubCustomerCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    SubCustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCustomerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCustomerPhone2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SellingPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumberDayDept = table.Column<int>(type: "int", nullable: false),
                    Account = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainCustomerCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subCustomers", x => x.SubCustomerCode);
                    table.ForeignKey(
                        name: "FK_subCustomers_mainCustomers_MainCustomerCode",
                        column: x => x.MainCustomerCode,
                        principalTable: "mainCustomers",
                        principalColumn: "MainCustomerCode");
                });

            migrationBuilder.CreateTable(
                name: "customerTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Code = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    voucher_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customer_Invoice_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    voucher_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debit = table.Column<double>(type: "float", nullable: false),
                    Credit = table.Column<double>(type: "float", nullable: false),
                    record_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_customerTransactions_subCustomers_Customer_Code",
                        column: x => x.Customer_Code,
                        principalTable: "subCustomers",
                        principalColumn: "SubCustomerCode");
                });

            migrationBuilder.CreateTable(
                name: "Guarantors",
                columns: table => new
                {
                    GuarantorCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    GuarantorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCustomerCode = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guarantors", x => x.GuarantorCode);
                    table.ForeignKey(
                        name: "FK_Guarantors_subCustomers_SubCustomerCode",
                        column: x => x.SubCustomerCode,
                        principalTable: "subCustomers",
                        principalColumn: "SubCustomerCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "noteGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoteCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoteName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCustomerCode = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_noteGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_noteGroups_subCustomers_SubCustomerCode",
                        column: x => x.SubCustomerCode,
                        principalTable: "subCustomers",
                        principalColumn: "SubCustomerCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customerTransactions_Customer_Code",
                table: "customerTransactions",
                column: "Customer_Code");

            migrationBuilder.CreateIndex(
                name: "IX_Guarantors_SubCustomerCode",
                table: "Guarantors",
                column: "SubCustomerCode");

            migrationBuilder.CreateIndex(
                name: "IX_mainCustomers_mainCurrencyCode",
                table: "mainCustomers",
                column: "mainCurrencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_noteGroups_SubCustomerCode",
                table: "noteGroups",
                column: "SubCustomerCode");

            migrationBuilder.CreateIndex(
                name: "IX_subCurrencies_MainCurrencyCode",
                table: "subCurrencies",
                column: "MainCurrencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_subCustomers_MainCustomerCode",
                table: "subCustomers",
                column: "MainCustomerCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "branches");

            migrationBuilder.DropTable(
                name: "customerTransactions");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "Guarantors");

            migrationBuilder.DropTable(
                name: "noteGroups");

            migrationBuilder.DropTable(
                name: "subCurrencies");

            migrationBuilder.DropTable(
                name: "subCustomers");

            migrationBuilder.DropTable(
                name: "mainCustomers");

            migrationBuilder.DropTable(
                name: "mainCurrencies");
        }
    }
}
