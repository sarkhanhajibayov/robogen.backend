using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using robogen.backend.Domain.Entities;
using robogen.backend.Domain.Entities.Common;
using robogen.backend.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robogen.backend.Persistence.Contexts
{
    public class RobogenDbContext : IdentityDbContext<AppUser,AppRole,string>
    {
        public RobogenDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<AgeGroup> AgeGroups { get; set; }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach(var entity in datas)
            {
                _ = entity.State switch
                {
                    EntityState.Added => entity.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => entity.Entity.UpdatedDate = DateTime.UtcNow,
                    EntityState.Deleted => entity.Entity.UpdatedDate = DateTime.UtcNow,

                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
