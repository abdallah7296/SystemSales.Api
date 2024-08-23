using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSales.Core.Base;

namespace SystemSales.Core.Feature.Branches.Commands.Models
{
    public class CreateBranchesCommand : IRequest<Response<string>>
    {
        [Required]
        public string? BranchName { get; set; }
    }
}
