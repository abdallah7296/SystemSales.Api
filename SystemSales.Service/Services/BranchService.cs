using SystemSales.Data.Entities;
using SystemSales.infrastructure.Abstracts;
using SystemSales.Service.Abstracts;
namespace SystemSales.Service.Services
{
    public class BranchService : IBranchService
    {
        #region fields
        private readonly IBranchRepository _branchRepository;
        #endregion

        #region Constructor
        public BranchService(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }



        #endregion

        #region Hndel Functions

        public async Task<string> AddBranchAsync(Branch branch)
        {
            string prefix = "BR";

            // Define a lambda function to select the property name
            Func<Branch, string> codePropertySelector = entity => nameof(entity.BranchCode);

            var result = await _branchRepository.AddWithCodeAsync<int>(branch, prefix, codePropertySelector);

            return result != null ? "Success" : "Please enter Branch details correctly";
        }


        #endregion

    }
}
