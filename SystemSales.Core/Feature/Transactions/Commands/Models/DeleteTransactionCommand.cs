using MediatR;
using SystemSales.Core.Base;

namespace SystemSales.Core.Feature.Transactions.Commands.Models
{
    public class DeleteTransactionCommand : IRequest<Response<string>>
    {
        public string Code { get; set; }
        public DeleteTransactionCommand(string code)
        { Code = code; }
    }
}
