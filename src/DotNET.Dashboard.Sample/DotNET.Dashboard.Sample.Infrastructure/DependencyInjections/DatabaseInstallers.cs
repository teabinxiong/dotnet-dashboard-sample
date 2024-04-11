using DotNET.Dashboard.Sample.Domain.Abstractions;
using DotNET.Dashboard.Sample.Domain.Employees;
using DotNET.Dashboard.Sample.Infrastructure.Data;
using DotNET.Dashboard.Sample.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET.Dashboard.Sample.Infrastructure.DependencyInjections
{
    public static class DatabaseInstaller
    {
        public static IServiceCollection AddDatabase(
            this IServiceCollection services,
            IConfiguration configuration)
        {

            var conString = configuration.GetConnectionString("SalesManagementDbConntection") ??
                throw new ArgumentNullException(nameof(configuration));

            services.AddDbContext<SalesManagementDbContext>(options =>
            {
                options.UseSqlServer(conString, x => x.MigrationsAssembly("DotNET.Dashboard.Sample.Infrastructure"));
            });
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeJobTitleRepository, EmployeeJobTitleRepository>();
            services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<SalesManagementDbContext>());

            return services;
        }
    }
}
