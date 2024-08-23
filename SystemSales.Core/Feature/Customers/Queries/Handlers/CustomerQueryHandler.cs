using AutoMapper;
using MediatR;
using SystemSales.Core.Base;
using SystemSales.Core.Feature.Customers.Queries.Models;
using SystemSales.Core.Feature.Customers.Results;
using SystemSales.Service.Abstracts;

namespace SystemSales.Core.Feature.Customers.Queries.Handlers
{
    public class CustomerQueryHandler : ResponseHandler, IRequestHandler<GetCustomerQuery, Response<IEnumerable<GetCustomerQueryDTO>>>
                                                       , IRequestHandler<GetCustomerByCodeQuery, Response<GetSingleCustomerDTO>>
    {

        #region Fields 
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public CustomerQueryHandler(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }
        #endregion

        #region Handle Functions

        public async Task<Response<IEnumerable<GetCustomerQueryDTO>>> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var customers = await _customerService.SearchAsync(request.item);
            if (customers.Count == 0) return BadRequest<IEnumerable<GetCustomerQueryDTO>>("لا يوجد عملاء بهذا الأسم ");
            if (customers == null) return BadRequest<IEnumerable<GetCustomerQueryDTO>>("من فضلك ادخل اسم العميل");
            var customerDtos = _mapper.Map<IEnumerable<GetCustomerQueryDTO>>(customers);
            return Success<IEnumerable<GetCustomerQueryDTO>>(customerDtos, "Get Successfully");
        }

        public async Task<Response<GetSingleCustomerDTO>> Handle(GetCustomerByCodeQuery request, CancellationToken cancellationToken)
        {
            var customer = await _customerService.GetByCode(request.Code);
            if (customer == null) return NotFound<GetSingleCustomerDTO>();
            var result = _mapper.Map<GetSingleCustomerDTO>(customer);
            return Success(result);
        }

        #endregion


    }
}
