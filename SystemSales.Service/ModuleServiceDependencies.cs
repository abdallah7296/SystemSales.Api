using Microsoft.Extensions.DependencyInjection;
using SystemSales.Service.Abstracts;
using SystemSales.Service.Services;

namespace SystemSales.Service
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IBranchService, BranchService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<ICustTransactionService, CustTransactionsService>();
            return services;
        }

    }
}
