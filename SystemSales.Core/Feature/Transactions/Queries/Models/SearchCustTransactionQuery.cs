using MediatR;
using SystemSales.Core.Base;
using SystemSales.Core.Feature.Transactions.Results;

namespace SystemSales.Core.Feature.Transactions.Queries.Models
{
    public class SearchCustTransactionQuery : IRequest<Response<List<GetListCustTransactionDTO>>>
    {
        public string Item { get; set; }
        public SearchCustTransactionQuery(string item)
        {

            Item = item;
        }

    }
}
