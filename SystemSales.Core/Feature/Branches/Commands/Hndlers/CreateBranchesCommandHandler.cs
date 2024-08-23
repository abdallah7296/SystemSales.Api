using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSales.Core.Base;
using SystemSales.Core.Feature.Branches.Commands.Models;
using SystemSales.Data.Entities;
using SystemSales.infrastructure.Abstracts;
using SystemSales.infrastructure.Context;
using SystemSales.Service.Abstracts;

namespace SystemSales.Core.Feature.Branches.Commands.Handlers
{
    public class CreateSubCustomerCommandHandler : ResponseHandler ,IRequestHandler<CreateBranchesCommand, Response<string>>
    {
        private readonly ApplicationDbContext _context;
        private readonly IBranchService _branchService;
        private readonly IMapper _mapper;

        public CreateSubCustomerCommandHandler(ApplicationDbContext context, IBranchService branchService , IMapper mapper)
        {
            _context = context;
            _branchService = branchService;
            _mapper = mapper;
        }

        public async Task<Response<string>> Handle(CreateBranchesCommand request, CancellationToken cancellationToken)
        {
            var branch = _mapper.Map<Branch>(request);
            var result = await _branchService.AddBranchAsync(branch);

            if (result == "Success")
            {
                return Created(result);
            }

            return BadRequest<string>();
        }
    }

}
