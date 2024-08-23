using MediatR;
using SystemSales.Core.Base;
using SystemSales.Core.Feature.Transactions.Results;

namespace SystemSales.Core.Feature.Transactions.Queries.Models
{
    public class GetTransactionByCodeQuery : IRequest<Response<TransactionDetailsDTO>>
    {
        public string Code { get; set; }
        public GetTransactionByCodeQuery(string code)
        { Code = code; }
    }
}
