using DotNET.Dashboard.Sample.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET.Dashboard.Sample.Domain.Employees
{
    public sealed class EmployeeJobTitle : Entity
    {

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
