using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Ualmarti.Models
{
    public class UalmartiContext : DbContext
    {
        public UalmartiContext (DbContextOptions<UalmartiContext> options)
            : base(options)
        {
        }

        public DbSet<Ualmarti.Models.Departament> Departament { get; set; }
    }
}
