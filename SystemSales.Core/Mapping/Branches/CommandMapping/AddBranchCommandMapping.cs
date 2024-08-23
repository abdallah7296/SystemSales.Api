using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSales.Core.Feature.Branches.Commands.Models;
using SystemSales.Data.Entities;

namespace SystemSales.Core.Mapping.Branches
{
    public partial class CustomerProfile
    {
        public void AddBranchCommandMapping()
        {
            CreateMap<CreateBranchesCommand, Branch>();
        }

    }
}
