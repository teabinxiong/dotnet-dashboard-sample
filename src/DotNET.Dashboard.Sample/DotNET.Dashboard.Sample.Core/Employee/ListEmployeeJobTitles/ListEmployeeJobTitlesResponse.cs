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
    public sealed class ListEmployeeJobTitlesResponse : Response
    {
        public List<EmployeeJobTitle> EmployeeJobTitleList { get; set; }

        private ListEmployeeJobTitlesResponse(List<EmployeeJobTitle> employeeJobTitleList)
        {
            EmployeeJobTitleList = employeeJobTitleList;
        }

        public static ListEmployeeJobTitlesResponse From(List<EmployeeJobTitle> employeeJobTitleList)
        {
             return new ListEmployeeJobTitlesResponse(employeeJobTitleList);
        }
    }
}
