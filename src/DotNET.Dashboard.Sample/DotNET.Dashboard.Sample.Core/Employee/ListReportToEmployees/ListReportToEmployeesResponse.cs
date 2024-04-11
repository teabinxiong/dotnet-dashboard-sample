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
    public sealed class ListReportToEmployeesResponse : Response
    {
        public List<ReportToModel> ReportToEmployeeList { get; set; }

        private ListReportToEmployeesResponse(List<ReportToModel> reportToEmployeeList)
        {
            ReportToEmployeeList = reportToEmployeeList;
        }

        public static ListReportToEmployeesResponse From(List<ReportToModel> reportToEmployeeList)
        {
             return new ListReportToEmployeesResponse(reportToEmployeeList);
        }
    }
}
