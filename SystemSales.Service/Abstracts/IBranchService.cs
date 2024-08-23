using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSales.Data.Entities;

namespace SystemSales.Service.Abstracts
{
    public interface IBranchService
    {
        public Task<string> AddBranchAsync(Branch branch);
    }
}
