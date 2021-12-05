using Microsoft.EntityFrameworkCore;
using RubicX_223020new.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RubicX_223020new.DataAccess.Core.Interfaces.DbContext
{
    public interface IRubicContext : IDisposable, IAsyncDisposable //подключили возможность асинхронности  (одновременно)
    {
        DbSet<UserRto> Users { get; set; }//тип имя св-во
        DbSet<UserRoleRto> UserRoles { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
