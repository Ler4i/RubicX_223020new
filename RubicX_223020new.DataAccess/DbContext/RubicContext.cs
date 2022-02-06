using Microsoft.EntityFrameworkCore;
using RubicX_223020new.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RubicX_223020new.DataAccess.DbContext
{
    public class RubicContext : Microsoft.EntityFrameworkCore.DbContext, IDisposable, IAsyncDisposable
    {
        public RubicContext(DbContextOptions<RubicContext> options) : base(options)//БД
        {

        }

        public DbSet<UserRto> Users { get; set; }
        //public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) { }
        //public DbSet<UserRoleRto> UserRoles { get; set; }
    }
}
