using DotNET.Dashboard.Sample.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET.Dashboard.Sample.Domain.Employees
{
    public sealed class Employee : Entity
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long? ReportToEmpId { get; set; }
        public string ImagePath { get; set; }
        public int EmployeeJobTitleId { get; set; }
    }
}
