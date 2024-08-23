using System.ComponentModel.DataAnnotations;

namespace SystemSales.Data.Entities
{
    public class Suppliers
    {
        public Suppliers()
        {
            Transaction = new HashSet<SuppliersTransaction>();
        }
        [Key]
        public string Suppliers_Code { get; set; }
        public string Suppliers_Name { get; set; }
        public string? Country { get; set; }
        public string? Address { get; set; }
        [Phone]
        public string? Phone { get; set; }
        [EmailAddress]
        public string? Email { get; set; }

        public ICollection<SuppliersTransaction> Transaction { get; set; }

    }

}
