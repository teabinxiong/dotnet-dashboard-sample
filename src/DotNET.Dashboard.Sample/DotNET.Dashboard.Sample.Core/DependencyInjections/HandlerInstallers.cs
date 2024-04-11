using DotNET.Dashboard.Sample.Core.Abstractions;
using DotNET.Dashboard.Sample.Core.Employee.ListEmployees;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET.Dashboard.Sample.Core.DependencyInjections
{
    public static class HandlerInstallers
    {
        public static IServiceCollection AddHandlers(
                 this IServiceCollection services,
                 IConfiguration configuration)
        {
            services.AddTransient(typeof(ListEmployeesQueryHandler));
            services.AddTransient(typeof(ListEmployeeJobTitlesQueryHandler));
            services.AddTransient(typeof(ListReportToEmployeesQueryHandler));
            return services;
        }
    }
}
