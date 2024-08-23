using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSales.Core.Mapping.Branches
{
    public partial class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            AddBranchCommandMapping();
        }
        
    }
}
