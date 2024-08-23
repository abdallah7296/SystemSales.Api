using AutoMapper;
using MediatR;
using SystemSales.Core.Base;
using SystemSales.Core.Feature.Customers.Commands.Models;
using SystemSales.Data.Entities;
using SystemSales.infrastructure.Context;
using SystemSales.Service.Abstracts;

namespace SystemSales.Core.Feature.Customers.Commands.Handlers
{
    public class CreateSubCustomerCommandHandler : ResponseHandler, IRequestHandler<CreateCustomerCommand, Response<string>>
                                                                  , IRequestHandler<DeleteCustomerCommand, Response<string>>
    {
        private readonly ApplicationDbContext _context;
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CreateSubCustomerCommandHandler(ApplicationDbContext context, ICustomerService customerService, IMapper mapper)
        {
            _context = context;
            _customerService = customerService;

            _mapper = mapper;
        }

        public async Task<Response<string>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<Customer>(request.Customer);
            var transaction = new CustomerTransactions
            {
                voucher_Credit = request.Customer.VoucherCredit,
                voucher_Debit = request.Customer.VoucherDebit,
                CustomerName = request.Customer.CustomerName,
                voucher_Code = await _customerService.GenerateCodeAsync(),
                Customer = customer
            };

            customer.Transactions.Add(transaction);
            var result = await _customerService.AddAsync(customer);
            if (result == "Exist") return UnprocessableEntity<string>("The Name Is Exist");
            else if (result == "Success") return Created<string>("Customer created successfully");
            else return BadRequest<string>("Failed to create customer");

        }

        public async Task<Response<string>> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _customerService.GetByCode(request.CustomerCode);
            if (customer == null) return BadRequest<string>("لا يوجد هذا العميل");
            var result = await _customerService.DeleteAsync(customer);
            if (result == "BadRequest") return BadRequest<string>("عفوا لا يمكن حذف العميل يوجد مستحقات ماديه يجب دفعها اولا");
            if (result == "deleted") return Deleted<string>();
            else return BadRequest<string>();
        }
    }
}
