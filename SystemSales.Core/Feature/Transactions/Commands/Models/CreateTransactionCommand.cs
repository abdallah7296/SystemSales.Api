using MediatR;
using SystemSales.Core.Base;

namespace SystemSales.Core.Feature.Transactions.Commands.Models
{
    public class CreateTransactionCommand : IRequest<Response<string>>
    {
        public string CustomerCode { get; set; }
        public double? voucher_Debit { get; set; }
        public double? voucher_Credit { get; set; }
        public string Description { get; set; }

    }
}
