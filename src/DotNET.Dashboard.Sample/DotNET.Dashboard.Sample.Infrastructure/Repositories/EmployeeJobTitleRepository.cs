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
    internal sealed class EmployeeJobTitleRepository :  Repository<EmployeeJobTitle>, IEmployeeJobTitleRepository
    {
        public EmployeeJobTitleRepository(SalesManagementDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<EmployeeJobTitle>> ListJobTitles()
        {
            try
            {
                return await this.ListAll().ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
