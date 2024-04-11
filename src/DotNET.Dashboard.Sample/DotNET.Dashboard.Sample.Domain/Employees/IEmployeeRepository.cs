using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET.Dashboard.Sample.Domain.Employees
{
    public interface IEmployeeRepository
    {
        Task<List<EmployeeModel>> ListEmployees();
    }
}
