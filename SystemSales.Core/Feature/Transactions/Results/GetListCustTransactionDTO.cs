namespace SystemSales.Core.Feature.Transactions.Results
{
    public class GetListCustTransactionDTO
    {
        public string Customer_Code { get; set; }
        public string CustomerName { get; set; }
        public double? voucher_Debit { get; set; }
        public double? voucher_Credit { get; set; }
        public string Description { get; set; }
        public string customer_Invoice_Type { get; set; }
        public DateTime record_Date { get; set; }
    }
}
