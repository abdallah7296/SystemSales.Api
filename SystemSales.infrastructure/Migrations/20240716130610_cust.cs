using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemSales.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class cust : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customerTransactions_subCustomers_Customer_Code",
                table: "customerTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_mainCustomers_mainCurrencies_mainCurrencyCode",
                table: "mainCustomers");

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
                name: "mainCurrencies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mainCustomers",
                table: "mainCustomers");

            migrationBuilder.DropIndex(
                name: "IX_mainCustomers_mainCurrencyCode",
                table: "mainCustomers");

            migrationBuilder.DropColumn(
                name: "MainCustomerCode",
                table: "mainCustomers");

            migrationBuilder.DropColumn(
                name: "CommercialRegister",
                table: "mainCustomers");

            migrationBuilder.DropColumn(
                name: "Enterprise",
                table: "mainCustomers");

            migrationBuilder.DropColumn(
                name: "Credit",
                table: "customerTransactions");

            migrationBuilder.DropColumn(
                name: "Debit",
                table: "customerTransactions");

            migrationBuilder.DropColumn(
                name: "voucher_Date",
                table: "customerTransactions");

            migrationBuilder.RenameColumn(
                name: "mainCurrencyCode",
                table: "mainCustomers",
                newName: "CustomerCode");

            migrationBuilder.AlterColumn<string>(
                name: "TaxNumber",
                table: "mainCustomers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "mainCustomers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "mainCustomers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "mainCustomers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "mainCustomers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "mainCustomers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "mainCustomers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "customerTransactions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "voucher_Credit",
                table: "customerTransactions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "voucher_Debit",
                table: "customerTransactions",
                type: "float",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customerTransactions_mainCustomers_Customer_Code",
                table: "customerTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mainCustomers",
                table: "mainCustomers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "mainCustomers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "mainCustomers");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "mainCustomers");

            migrationBuilder.DropColumn(
                name: "city",
                table: "mainCustomers");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "mainCustomers");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "customerTransactions");

            migrationBuilder.DropColumn(
                name: "voucher_Credit",
                table: "customerTransactions");

            migrationBuilder.DropColumn(
                name: "voucher_Debit",
                table: "customerTransactions");

            migrationBuilder.RenameColumn(
                name: "CustomerCode",
                table: "mainCustomers",
                newName: "mainCurrencyCode");

            migrationBuilder.AlterColumn<string>(
                name: "TaxNumber",
                table: "mainCustomers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "mainCustomers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainCustomerCode",
                table: "mainCustomers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CommercialRegister",
                table: "mainCustomers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Enterprise",
                table: "mainCustomers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Credit",
                table: "customerTransactions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Debit",
                table: "customerTransactions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "voucher_Date",
                table: "customerTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_mainCustomers",
                table: "mainCustomers",
                column: "MainCustomerCode");

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    CollectionCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecimalCategoryPlural = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainCurrencyId = table.Column<int>(type: "int", nullable: false),
                    NumberDecimalPoints = table.Column<int>(type: "int", nullable: false),
                    SingleCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SingleDecimalCategory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mainCurrencies", x => x.MainCurrencyCode);
                });

            migrationBuilder.CreateTable(
                name: "subCustomers",
                columns: table => new
                {
                    SubCustomerCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Account = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    MainAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainCustomerCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberDayDept = table.Column<int>(type: "int", nullable: false),
                    SaleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SellingPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCustomerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCustomerPhone2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "subCurrencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainCurrencyCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ConversionFactor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Guarantors",
                columns: table => new
                {
                    GuarantorCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubCustomerCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GuarantorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    SubCustomerCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NoteCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoteName = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "IX_mainCustomers_mainCurrencyCode",
                table: "mainCustomers",
                column: "mainCurrencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_Guarantors_SubCustomerCode",
                table: "Guarantors",
                column: "SubCustomerCode");

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

            migrationBuilder.AddForeignKey(
                name: "FK_customerTransactions_subCustomers_Customer_Code",
                table: "customerTransactions",
                column: "Customer_Code",
                principalTable: "subCustomers",
                principalColumn: "SubCustomerCode");

            migrationBuilder.AddForeignKey(
                name: "FK_mainCustomers_mainCurrencies_mainCurrencyCode",
                table: "mainCustomers",
                column: "mainCurrencyCode",
                principalTable: "mainCurrencies",
                principalColumn: "MainCurrencyCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
