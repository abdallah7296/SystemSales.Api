using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSales.Data.Entities;
using SystemSales.infrastructure.infrastructure;

namespace SystemSales.infrastructure.Abstracts
{
    public interface IBranchRepository : IGenericRepositoryAsync<Branch>
    {

    }
}
