
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using robogen.backend.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<RobogenDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        }
    }
}
