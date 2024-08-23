using AutoMapper;
using MediatR;
using SystemSales.Core.Base;
using SystemSales.Core.Feature.Transactions.Commands.Models;
using SystemSales.Data.Entities;
using SystemSales.Service.Abstracts;

namespace SystemSales.Core.Feature.Transactions.Commands.Handlers
{
    internal class TransactionCommandHandler : ResponseHandler, IRequestHandler<CreateTransactionCommand, Response<string>>



    {
        private readonly ICustTransactionService _transactionsService;
        private readonly IMapper _mapper;
        #region Fields
        #endregion
        public TransactionCommandHandler(ICustTransactionService transactionsService, IMapper mapper)
        {
            _transactionsService = transactionsService;
            _mapper = mapper;
        }
        #region Constructor

        #endregion


        #region handle function

        public async Task<Response<string>> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
        {

            var customerDetails = await _transactionsService.GetCustomerDetailsAsync(request.CustomerCode);

            if (customerDetails == null) return BadRequest<string>("Customer not found");

            var transaction = _mapper.Map<CustomerTransactions>(request);
            transaction.Customer_Code = request.CustomerCode;
            transaction.CustomerName = customerDetails.CustomerName;


            if (request.voucher_Debit.HasValue && request.voucher_Debit > 0)
            {
                transaction.customer_Invoice_Type = "تسجيل مديونية";
                transaction.voucher_Debit += customerDetails.voucher_Debit;
            }
            else
            {
                transaction.customer_Invoice_Type = "استلام مبلغ نقدي";
                transaction.voucher_Debit = customerDetails.voucher_Debit - request.voucher_Credit;
            }

            await _transactionsService.AddTransactionAsync(transaction);

            return Success("Transaction created successfully");
        }
        #endregion
    }
}
