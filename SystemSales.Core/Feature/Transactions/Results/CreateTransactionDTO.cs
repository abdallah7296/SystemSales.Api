namespace SystemSales.Core.Feature.Transactions.Results
{
    public class CreateTransactionDTO
    {
        public string Customer_Code { get; set; }
        public string? customer_Invoice_Type { get; set; } = "استلام مبلغ نقدي";
        public string? Description { get; set; }
        public double? voucher_Debit { get; set; }
        public double? voucher_Credit { get; set; }

    }
}
