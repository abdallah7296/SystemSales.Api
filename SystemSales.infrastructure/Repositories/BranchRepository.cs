using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSales.Data.Entities;
using SystemSales.infrastructure.Abstracts;
using SystemSales.infrastructure.Context;
using SystemSales.infrastructure.infrastructure;

namespace SystemSales.infrastructure.Repositories
{
    public class BranchRepository : GenericRepositoryAsync<Branch>, IBranchRepository
    {
        #region Fieleds
        private readonly DbSet<Branch> _students;
        #endregion

        #region Constructor
        public BranchRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _students = dbContext.Set<Branch>();
        }
        #endregion
        #region Handels Function
        #endregion
    }
}
