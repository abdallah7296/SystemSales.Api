namespace SystemSales.Core.Feature.Customers.Results
{
    public class GetSingleCustomerDTO
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string? phone { get; set; }
        public string? city { get; set; }
        public string? Country { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? TaxNumber { get; set; }
        public string? Notes { get; set; }
    }
}
