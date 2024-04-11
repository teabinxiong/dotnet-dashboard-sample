using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET.Dashboard.Sample.Domain.Employees
{
    public sealed class ReportToModel
    {
        public long? ReportToEmpId { get; set; }

        public string ReportToName { get; set; }
    }
}
