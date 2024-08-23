using MediatR;
using SystemSales.Core.Base;
using SystemSales.Core.Feature.Transactions.Results;

namespace SystemSales.Core.Feature.Transactions.Queries.Models
{
    public class GetListCustTransactionQuery : IRequest<Response<List<GetListCustTransactionDTO>>>
    {
    }
}
