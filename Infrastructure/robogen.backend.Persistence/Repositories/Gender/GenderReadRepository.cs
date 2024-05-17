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
    public class GenderReadRepository : ReadRepository<Gender>, IGenderReadRepository
    {
        public GenderReadRepository(RobogenDbContext context) : base(context)
        {
        }
    }
}
