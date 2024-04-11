using DotNET.Dashboard.Sample.Domain.Employees;
using DotNET.Dashboard.Sample.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET.Dashboard.Sample.Infrastructure.Repositories
{
    internal sealed class EmployeeRepository :  Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(SalesManagementDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<EmployeeModel>> ListEmployees()
        {
            try
            {
                return await this.ListAll().ConvertModel().ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
