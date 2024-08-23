using System.ComponentModel.DataAnnotations.Schema;

namespace SystemSales.Data.Entities
{
    public class SuppliersTransaction
    {
        public int Id { get; set; }
        public string Supplier_Name { get; set; }
        public string Suplier_Invoice_Type { get; set; }
        public double? voucherDebit { get; set; }
        public double? voucherCredit { get; set; }
        public string? Description { get; set; }
        public DateTime? record_Date { get; set; }
        [ForeignKey(nameof(Suppliers))]
        public string supplier_Code { get; set; }
        public Suppliers Suppliers { get; set; }

    }
}
