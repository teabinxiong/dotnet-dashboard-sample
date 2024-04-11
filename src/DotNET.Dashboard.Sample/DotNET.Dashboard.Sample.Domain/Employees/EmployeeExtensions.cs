using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET.Dashboard.Sample.Domain.Employees
{
    public static class EmployeeExtensions
    {
        public static async Task<IQueryable<EmployeeModel>> ConvertModelAsync(this IQueryable<Employee> employees)
        {
            return await Task.FromResult((from e in employees
                                          select new EmployeeModel
                                          {
                                              Id = e.Id,
                                              FirstName = e.FirstName,
                                              LastName = e.LastName,
                                              EmployeeJobTitleId = e.EmployeeJobTitleId,
                                              Email = e.Email,
                                              DateOfBirth = e.DateOfBirth,
                                              ReportToEmpId = e.Id,
                                              Gender = e.Gender,
                                              ImagePath = e.ImagePath
                                          }));

        }

        public static IQueryable<EmployeeModel> ConvertModel(this IQueryable<Employee> employees)
        {
            return (from e in employees
                    select new EmployeeModel
                    {
                        Id = e.Id,
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        EmployeeJobTitleId = e.EmployeeJobTitleId,
                        Email = e.Email,
                        DateOfBirth = e.DateOfBirth,
                        ReportToEmpId = e.ReportToEmpId,
                        Gender = e.Gender,
                        ImagePath = e.ImagePath
                    });
        }

    }
}
