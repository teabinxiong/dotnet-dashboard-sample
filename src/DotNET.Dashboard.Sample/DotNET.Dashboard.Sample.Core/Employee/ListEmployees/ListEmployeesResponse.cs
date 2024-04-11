using DotNET.Dashboard.Sample.Core.Abstractions;
using DotNET.Dashboard.Sample.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DotNET.Dashboard.Sample.Core.Employee.ListEmployees
{
    public sealed class ListEmployeesResponse : Response
    {
        public List<EmployeeModel> EmployeeList { get; set; }

        private ListEmployeesResponse(List<EmployeeModel> employeeList)
        {
            EmployeeList = employeeList;
        }

        public static ListEmployeesResponse From(List<EmployeeModel> employeeList)
        {
             return new ListEmployeesResponse(employeeList);
        }
    }
}
