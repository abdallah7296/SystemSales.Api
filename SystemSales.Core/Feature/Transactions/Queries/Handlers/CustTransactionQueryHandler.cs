using AutoMapper;
using MediatR;
using SystemSales.Core.Base;
using SystemSales.Core.Feature.Transactions.Queries.Models;
using SystemSales.Core.Feature.Transactions.Results;
using SystemSales.Service.Abstracts;

namespace SystemSales.Core.Feature.Transactions.Queries.Handlers
{
    public class CustTransactionQueryHandler : ResponseHandler, IRequestHandler<GetTransactionByCodeQuery, Response<TransactionDetailsDTO>>
                                                          , IRequestHandler<GetListCustTransactionQuery, Response<List<GetListCustTransactionDTO>>>
                                                          , IRequestHandler<SearchCustTransactionQuery, Response<List<GetListCustTransactionDTO>>>
    {
        #region Fields
        private readonly ICustTransactionService _transactionsService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructo
        public CustTransactionQueryHandler(ICustTransactionService transactionsService, IMapper mapper)
        {
            _transactionsService = transactionsService;
            _mapper = mapper;
        }
        #endregion
        #region Handle Function

        public async Task<Response<TransactionDetailsDTO>> Handle(GetTransactionByCodeQuery request, CancellationToken cancellationToken)
        {
            var customerDetails = await _transactionsService.GetCustomerDetailsAsync(request.Code);

            if (customerDetails == null) return NotFound<TransactionDetailsDTO>();

            var customerDetailsDto = _mapper.Map<TransactionDetailsDTO>(customerDetails);

            return Success(customerDetailsDto);
        }

        public async Task<Response<List<GetListCustTransactionDTO>>> Handle(GetListCustTransactionQuery request, CancellationToken cancellationToken)
        {
            var CustTransactionList = await _transactionsService.GetListsAsync();
            var ListMapping = _mapper.Map<List<GetListCustTransactionDTO>>(CustTransactionList);
            if (ListMapping == null) return NotFound<List<GetListCustTransactionDTO>>();
            return Success(ListMapping);
        }

        public async Task<Response<List<GetListCustTransactionDTO>>> Handle(SearchCustTransactionQuery request, CancellationToken cancellationToken)
        {
            var searchCustTrans = await _transactionsService.SearchAsync(request.Item);
            if (searchCustTrans.Count == 0) return BadRequest<List<GetListCustTransactionDTO>>("لا يوجد عملاء بهذا الأسم ");
            if (searchCustTrans == null) return BadRequest<List<GetListCustTransactionDTO>>("من فضلك ادخل اسم العميل");
            var searchCustTransMapping = _mapper.Map<List<GetListCustTransactionDTO>>(searchCustTrans);
            return Success<List<GetListCustTransactionDTO>>(searchCustTransMapping, "Get Successfully");

        }



        #endregion
    }

}
