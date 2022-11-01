using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCProjects.Models;

namespace MVCProjects.Data
{
    public class MVCProjectsContext : DbContext
    {
        public MVCProjectsContext (DbContextOptions<MVCProjectsContext> options)
            : base(options)
        {
        }

        public DbSet<MVCProjects.Models.Class1s> Class1s { get; set; } = default!;
    }
}
