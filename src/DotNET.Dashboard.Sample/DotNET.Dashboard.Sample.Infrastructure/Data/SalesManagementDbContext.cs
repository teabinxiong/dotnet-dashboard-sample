using DotNET.Dashboard.Sample.Domain.Abstractions;
using DotNET.Dashboard.Sample.Domain.Employees;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DotNET.Dashboard.Sample.Infrastructure.Data
{
    public class SalesManagementDbContext : DbContext, IUnitOfWork
    {
        public SalesManagementDbContext(DbContextOptions<SalesManagementDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData.AddEmployeeRecords(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await base.SaveChangesAsync(cancellationToken);

                return result;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new ApplicationException("Concurrency exception occurred.", ex);
            }
        }



        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeJobTitle> EmployeeJobTitles { get; set; }
    }
}
