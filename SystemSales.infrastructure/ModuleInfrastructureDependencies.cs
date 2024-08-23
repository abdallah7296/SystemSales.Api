using Microsoft.Extensions.DependencyInjection;
using SystemSales.infrastructure.Abstracts;
using SystemSales.infrastructure.infrastructure;
using SystemSales.infrastructure.Repositories;

namespace SystemSales.infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IBranchRepository, BranchRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<ICustTransactionsRepository, CustTransactionsRepository>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            return services;
        }
    }
}
