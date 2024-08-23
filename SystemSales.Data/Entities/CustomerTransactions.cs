using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemSales.Data.Entities
{
    public class CustomerTransactions
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Customer")]
        public string? Customer_Code { get; set; }
        public string? voucher_Code { get; set; }
        public string? customer_Invoice_Type { get; set; }
        public string? Description { get; set; }
        public double? voucher_Debit { get; set; }
        public double? voucher_Credit { get; set; }
        public DateTime record_Date { get; set; } = DateTime.Now;
        public Customer? Customer { get; set; }
        public string? CustomerName { get; set; }

    }
}
