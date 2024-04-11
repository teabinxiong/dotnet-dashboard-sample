using DotNET.Dashboard.Sample.Core.Abstractions;
using DotNET.Dashboard.Sample.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET.Dashboard.Sample.Core.Employee.ListEmployees
{
    public sealed class ListEmployeeJobTitlesQueryHandler : Handler<ListEmployeeJobTitlesQuery, ListEmployeeJobTitlesResponse>
    {

        private readonly IEmployeeJobTitleRepository _employeeJobTitleRepository;

        protected readonly IServiceProvider _serviceProvider;
        public ListEmployeeJobTitlesQueryHandler(IServiceProvider serviceProvider, IEmployeeJobTitleRepository employeeJobTitleRepository)
        {
            _serviceProvider = serviceProvider;
            _employeeJobTitleRepository = employeeJobTitleRepository;
        }

        public override async Task<ListEmployeeJobTitlesResponse> Run(ListEmployeeJobTitlesQuery query)
        {
            var employeeJobTitleList = await _employeeJobTitleRepository.ListJobTitles();

            return ListEmployeeJobTitlesResponse.From(employeeJobTitleList);
        }
    }
}
