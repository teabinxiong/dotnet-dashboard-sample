using DotNET.Dashboard.Sample.Core.Abstractions;
using DotNET.Dashboard.Sample.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET.Dashboard.Sample.Core.Employee.ListEmployees
{
    public sealed class ListReportToEmployeesQueryHandler : Handler<ListReportToEmployeesQuery, ListReportToEmployeesResponse>
    {

        private readonly IEmployeeRepository _employeeRepository;

        protected readonly IServiceProvider _serviceProvider;
        public ListReportToEmployeesQueryHandler(IServiceProvider serviceProvider, IEmployeeRepository employeeRepository)
        {
            _serviceProvider = serviceProvider;
            _employeeRepository = employeeRepository;
        }

        public override async Task<ListReportToEmployeesResponse> Run(ListReportToEmployeesQuery query)
        {
            var reportToEmployeeList = await _employeeRepository.ListReportToEmployees();

            return ListReportToEmployeesResponse.From(reportToEmployeeList);
        }
    }
}
