using DotNET.Dashboard.Sample.Domain.Abstractions;
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
    internal abstract class Repository<T> where T : Entity
    {

        protected readonly SalesManagementDbContext _dbContext;
        protected Repository(SalesManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> ListAll()
        {
            try
            {
                return this._dbContext.Set<T>().AsQueryable() ;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<T?> GetByIdAsync(
               long id,
               CancellationToken cancellationToken = default)
        {
            return await this._dbContext
                .Set<T>()
                .FirstOrDefaultAsync(item => item.Id == id, cancellationToken);
        }

        public void Add(T entity)
        {
            this._dbContext.Add(entity);
        }

    }
}
