using Microsoft.EntityFrameworkCore;
using RubicX_223020new.DataAccess.Core.Interfaces.DbContext;
using RubicX_223020new.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubicX_223020new.DataAccess.DbContext
{
    public class RubicContext : Microsoft.EntityFrameworkCore.DbContext, IRubicContext
    {
        public RubicContext(DbContextOptions<RubicContext> options) : base(options)
        {

        }

        public DbSet<UserRto> Users { get; set; }
        public DbSet<UserRoleRto> UserRoles { get; set; }
    }
}
