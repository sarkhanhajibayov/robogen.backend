using E_CommerceAPI.Persistence.Repositories;
using robogen.backend.Application.Repositories;
using robogen.backend.Domain.Entities;
using robogen.backend.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robogen.backend.Persistence.Repositories
{
    public class AgeGroupReadRepository : ReadRepository<AgeGroup>, IAgeGroupReadRepository
    {
        public AgeGroupReadRepository(RobogenDbContext context) : base(context)
        {
        }
    }
}
