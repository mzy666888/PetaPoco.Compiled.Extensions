using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetaPoco.Compiled.Extensions.MvcTest.DBContexts
{
    using Microsoft.EntityFrameworkCore;

    public class EfDBContext:DbContext
    {
        public EfDBContext(DbContextOptions<EfDBContext> options):base(options)
        {
            
        }

        //public DbSet<>
    }
}
