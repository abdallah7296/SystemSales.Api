using Microsoft.EntityFrameworkCore;
using SystemSales.Data.Entities;

namespace SystemSales.infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Branch> branches { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<CustomerTransactions> customerTransactions { get; set; }
        public DbSet<Suppliers> suppliers2 { get; set; }
        public DbSet<SuppliersTransaction> suppliersTransactions { get; set; }


    }
}
