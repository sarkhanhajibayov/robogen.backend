using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using robogen.backend.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<RobogenDbContext>
    {
        public RobogenDbContext CreateDbContext(string[] args)
        {

            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            builder.UseNpgsql(Configuration.ConnectionString);
            return new(builder.Options);
        }
    }
}
