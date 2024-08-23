using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSales.Data.Entities
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }
        public string? BranchName { get; set; }
        public string? BranchCode { get; set; }
    }
  
}
