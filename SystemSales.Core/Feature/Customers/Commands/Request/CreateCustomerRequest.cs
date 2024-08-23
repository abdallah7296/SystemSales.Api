using System.ComponentModel.DataAnnotations;

namespace SystemSales.Core.Feature.Customers.Commands.Request
{
    public class CreateCustomerRequest
    {
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string? Phone { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? TaxNumber { get; set; }
        public string? Notes { get; set; }
        public double VoucherCredit { get; set; }
        public double VoucherDebit { get; set; }
    }
}
