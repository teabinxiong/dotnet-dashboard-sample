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

        public async Task<List<ReportToModel>> ListReportToEmployees()
        {
            try
            {
                var employees = await (from e in this._dbContext.Employees
                                       join j in this._dbContext.EmployeeJobTitles
                                       on e.EmployeeJobTitleId equals j.Id
                                       where j.Name.ToUpper() == "TL" || j.Name.ToUpper() == "SM"

                                       select new ReportToModel
                                       {
                                           ReportToEmpId = e.Id,
                                           ReportToName = e.FirstName + " "
                                                            + e.LastName.Substring(0, 1).ToUpper() + "."
                                       }).ToListAsync();

                employees.Add(new ReportToModel { ReportToEmpId = null, ReportToName = "<None>" });

                return employees.OrderBy(o => o.ReportToEmpId).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
