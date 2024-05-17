
using E_CommerceAPI.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using robogen.backend.Domain.Entities;
using robogen.backend.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace robogen.backend.Application.Repositories

{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(RobogenDbContext context) : base(context)
        {
        }
    }
}
