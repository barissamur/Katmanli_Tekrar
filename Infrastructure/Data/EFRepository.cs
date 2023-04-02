using ApplicationCore.Interfaces;
using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class EFRepository<T> : RepositoryBase<T>, IRepository<T> where T : class
    {
        public EFRepository(UygulamaDbContext dbContext) : base(dbContext)
        {

        }
    }
}
