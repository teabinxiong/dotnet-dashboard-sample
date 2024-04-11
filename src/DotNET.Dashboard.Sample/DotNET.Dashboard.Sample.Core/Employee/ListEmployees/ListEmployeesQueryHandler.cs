using DotNET.Dashboard.Sample.Core.Abstractions;
using DotNET.Dashboard.Sample.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET.Dashboard.Sample.Core.Employee.ListEmployees
{
    public sealed class ListEmployeesQueryHandler : Handler<ListEmployeesQuery, ListEmployeesResponse>
    {

        private readonly IEmployeeRepository _employeeRepository;

        protected readonly IServiceProvider _serviceProvider;
        public ListEmployeesQueryHandler(IServiceProvider serviceProvider, IEmployeeRepository employeeRepository)
        {
            _serviceProvider = serviceProvider;
            _employeeRepository = employeeRepository;
        }

        public override async Task<ListEmployeesResponse> Run(ListEmployeesQuery query)
        {
            var employeeList = await _employeeRepository.ListEmployees();

            return ListEmployeesResponse.From(employeeList);
        }
    }
}
