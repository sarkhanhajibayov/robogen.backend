
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using robogen.backend.Application.Repositories;
using robogen.backend.Domain.Entities.Identity;
using robogen.backend.Persistence.Contexts;
using robogen.backend.Persistence.Mapping;
using robogen.backend.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace robogen.backend.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<RobogenDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<RobogenDbContext>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IThemeReadRepository, ThemeReadRepository>();
            services.AddScoped<ISerieReadRepository, SerieReadRepository>();
            services.AddScoped<IGenderReadRepository, GenderReadRepository>();
            services.AddScoped<IAgeGroupReadRepository, AgeGroupReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddAutoMapper(typeof(MappingEntity));

        }
    }
}
