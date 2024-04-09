using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robogen.backend.Persistence.Contexts
{
    public class RobogenDbContext : DbContext
    {
        public RobogenDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
